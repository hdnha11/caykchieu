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
            tree.Insert(Convert.ToDouble(txtX.Text), Convert.ToDouble(txtY.Text));
            Graphics g = ptbTree.CreateGraphics();
            g.Clear(ptbTree.BackColor);
            DrawTree(g, tree, XPIXEL, YPIXEL, doDoiX, doDoiY);
        }

        private void DrawTree(Graphics g, Tree t, int xPixel, int yPixel, int xMove, int yMove)
        {
            int h = t.Height(t.Root) + 1;
            int soNut = Convert.ToInt32(Math.Pow(2, h));
            t.DrawTree(t.Root, g, soNut / 2, soNut / 2, xPixel, yPixel, xMove, yMove);
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
    }
}
