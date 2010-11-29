using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CayKChieu
{
    public partial class FormMain : Form
    {
        const int XPIXEL = 55;
        const int YPIXEL = 80;

        Tree tree;
        Point diemBD = new Point();
        int doDoiX = 0, doDoiY = 0;
        int doDoiXHT = 0, doDoiYHT = 0;
        //RangeSearch
        Point centre = new Point();
        int radius = 0;
        FormRangeSearch frmRangeSearch;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tree = new Tree();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtX.Text != String.Empty && txtY.Text != String.Empty)
            {
                tree.ResetTree(tree.Root);
                tree.IsRangeSearch = false;
                try
                {
                    tree.Insert(Convert.ToDouble(txtX.Text), Convert.ToDouble(txtY.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Node nodeFind = tree.Search(Convert.ToDouble(txtX.Text), Convert.ToDouble(txtY.Text));
                    if (nodeFind != null)
                    {
                        nodeFind.IsFind = true;
                    }
                }
                Graphics g = ptbTree.CreateGraphics();
                g.Clear(ptbTree.BackColor);
                DrawTree(g, tree, XPIXEL, YPIXEL, doDoiX, doDoiY);
                DrawPartitionArea();
            }
            else
            {
                MessageBox.Show("Chưa nhập giá trị X, Y cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DrawTree(Graphics g, Tree t, int xPixel, int yPixel, int xMove, int yMove)
        {
            int h = t.Height(t.Root) + 1;
            int soNut = Convert.ToInt32(Math.Pow(2, h));
            t.DrawTree(t.Root, g, soNut / 2, soNut / 2, xPixel, yPixel, xMove, yMove);
        }

        private void DrawPartitionArea()
        {
            GDB p = new GDB(ptbGrid.Width, ptbGrid.Height);
            Graphics g = p.Store();
            g.Clear(ptbGrid.BackColor);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (tree.Root != null)
            {                
                tree.DrawPartitionArea(tree.Root, g, ptbGrid.Width, ptbGrid.Height);
                if (tree.IsRangeSearch == true)
                {
                    //Lấy giá trị tọa độ lớn nhất hiện tại trên cây
                    double maxCoordinate = tree.GetXValMax(tree.Root);
                    if (maxCoordinate < tree.GetYValMax(tree.Root))
                        maxCoordinate = tree.GetYValMax(tree.Root);
                    double xScale = (ptbGrid.Width - (ptbGrid.Width - (ptbGrid.Height - 20))) / maxCoordinate; //Bằng ptbGrid.Height - 20
                    double yScale = (ptbGrid.Height - 20) / maxCoordinate;
                    Point realCentre = new Point(Convert.ToInt32(centre.X * xScale), Convert.ToInt32(centre.Y * yScale));
                    //Ước lượng tỷ lệ tương đối cho realRadius (Không chính xác lắm)
                    int realRadius = Convert.ToInt32(radius * ((xScale + yScale) / 2));
                    Pen myPen = new Pen(Color.Green, 2);
                    Brush myBrush = new SolidBrush(Color.Green);
                    g.DrawEllipse(myPen, realCentre.X - realRadius, ptbGrid.Height - realCentre.Y - realRadius, realRadius * 2, realRadius * 2);
                    g.FillEllipse(myBrush, realCentre.X - 5, ptbGrid.Height - realCentre.Y - 5, 10, 10);
                    g.DrawLine(myPen, realCentre.X, ptbGrid.Height - realCentre.Y, realCentre.X + realRadius, ptbGrid.Height - realCentre.Y);
                    g.DrawString(String.Format("O({0}, {1})", centre.X, centre.Y), new Font("Arial", 8), myBrush, realCentre.X - 30, ptbGrid.Height - realCentre.Y + 5);
                    g.DrawString(String.Format("R={0}", radius), new Font("Arial", 8), myBrush, (realCentre.X + realCentre.X + realRadius) / 2 - 15, ptbGrid.Height - realCentre.Y - 14);
                }
                p.Paint(ptbGrid);
                p.Dispone();
            }
        }

        private void ptbTree_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Cursor = Cursors.NoMove2D;
                diemBD = new Point(e.X, e.Y);
            }
        }

        private void ptbTree_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point diemHT = new Point(e.X, e.Y);
                doDoiXHT = doDoiX + (diemHT.X - diemBD.X);
                doDoiYHT = doDoiY + (diemHT.Y - diemBD.Y);
                GDB p = new GDB(ptbTree.Width, ptbTree.Height);
                Graphics g = p.Store();
                g.Clear(ptbTree.BackColor);
                DrawTree(g, tree, XPIXEL, YPIXEL, doDoiXHT, doDoiYHT);
                p.Paint(ptbTree);
                p.Dispone();
            }
        }

        private void ptbTree_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Cursor = Cursors.SizeAll;
                Point diemHT = new Point(e.X, e.Y);
                doDoiX = doDoiXHT;
                doDoiY = doDoiYHT;
            }
        }

        private void btnDeleteTree_Click(object sender, EventArgs e)
        {
            tree = new Tree();
            Graphics g = ptbTree.CreateGraphics();
            g.Clear(ptbTree.BackColor);
            //DrawPartitionArea(); //Gọi hàm nhưng không thực hiện vì root lúc này bằng null
            ptbGrid.CreateGraphics().Clear(ptbGrid.BackColor);
            doDoiX = doDoiY = 0;
        }

        private void ptbTree_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
        }

        private void ptbTree_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtX.Text != String.Empty && txtY.Text != String.Empty)
            {
                if (tree.Root != null)
                {
                    tree.ResetTree(tree.Root);
                    tree.IsRangeSearch = false;
                    Node nodeFind = tree.Search(Convert.ToDouble(txtX.Text), Convert.ToDouble(txtY.Text));
                    if (nodeFind != null)
                    {
                        nodeFind.IsFind = true;
                        Graphics g = ptbTree.CreateGraphics();
                        g.Clear(ptbTree.BackColor);
                        DrawTree(g, tree, XPIXEL, YPIXEL, doDoiX, doDoiY);
                        DrawPartitionArea();
                    }
                    else
                    {
                        MessageBox.Show(String.Format("Không tìm thấy nút ({0}, {1})", txtX.Text, txtY.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tree.ResetTree(tree.Root);
                        tree.IsRangeSearch = false;
                        Graphics g = ptbTree.CreateGraphics();
                        g.Clear(ptbTree.BackColor);
                        DrawTree(g, tree, XPIXEL, YPIXEL, doDoiX, doDoiY);
                        DrawPartitionArea();
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập giá trị X, Y cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnResetLocation_Click(object sender, EventArgs e)
        {
            doDoiX = doDoiY = 0;
            Graphics g = ptbTree.CreateGraphics();
            g.Clear(ptbTree.BackColor);
            DrawTree(g, tree, XPIXEL, YPIXEL, doDoiX, doDoiY);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtX.Text != String.Empty && txtY.Text != String.Empty)
            {
                if (tree.Root != null)
                {
                    tree.ResetTree(tree.Root);
                    tree.IsRangeSearch = false;
                    if (tree.Delete(Convert.ToDouble(txtX.Text), Convert.ToDouble(txtY.Text)))
                    {
                        Graphics g = ptbTree.CreateGraphics();
                        g.Clear(ptbTree.BackColor);
                        DrawTree(g, tree, XPIXEL, YPIXEL, doDoiX, doDoiY);
                        DrawPartitionArea();
                        //Đề phòng trường hợp nút gốc bằng null phương thức DrawPartitionArea() không được gọi
                        if (tree.Root == null)
                            ptbGrid.CreateGraphics().Clear(ptbGrid.BackColor);
                    }
                    else
                    {
                        MessageBox.Show(String.Format("Không tồn tại nút ({0}, {1})", txtX.Text, txtY.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Graphics g = ptbTree.CreateGraphics();
                        g.Clear(ptbTree.BackColor);
                        DrawTree(g, tree, XPIXEL, YPIXEL, doDoiX, doDoiY);
                        DrawPartitionArea();
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập giá trị X, Y cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Vẽ lại cây trong 2 PictureBox (chưa hoạt động được với ptbTree)
        private void ReDrawTree()
        {
            if (ptbTree.Width != 0 && ptbTree.Height != 0 && ptbGrid.Width != 0 && ptbGrid.Height != 0)
            {
                GDB p = new GDB(ptbTree.Width, ptbTree.Height);
                Graphics g = p.Store();
                g.Clear(ptbTree.BackColor);
                DrawTree(g, tree, XPIXEL, YPIXEL, doDoiX, doDoiY);
                p.Paint(ptbTree);
                p.Dispone();
                DrawPartitionArea();
                //ptbTree.Invalidate();
                this.Invalidate();
            }
        }

        private void ptbTree_Paint(object sender, PaintEventArgs e)
        {
            ReDrawTree();
        }

        private void btnRangeSearch_Click(object sender, EventArgs e)
        {
            frmRangeSearch = new FormRangeSearch();
            frmRangeSearch.FormClosing += new FormClosingEventHandler(frmRangeSearch_FormClosing);
            frmRangeSearch.ShowDialog();
        }

        void frmRangeSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmRangeSearch.IsSearch)
            {
                centre = frmRangeSearch.Centre;
                radius = frmRangeSearch.Radius;
                if (tree.Root != null)
                {
                    tree.ResetTree(tree.Root);
                    tree.IsRangeSearch = false;
                    tree.RangeSearch(tree.Root, centre, radius, ptbGrid.Width, ptbGrid.Height);
                    tree.IsRangeSearch = true;
                    Graphics g = ptbTree.CreateGraphics();
                    g.Clear(ptbTree.BackColor);
                    DrawTree(g, tree, XPIXEL, YPIXEL, doDoiX, doDoiY);
                    DrawPartitionArea();
                }
            }
        }
    }
}
