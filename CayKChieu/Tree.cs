using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CayKChieu
{
    public class Tree
    {
        private Node root;
        private bool isRangeSearch = false;

        //Thuộc tính
        public Node Root
        {
            get { return root; }
            set { root = value; }
        }

        public bool IsRangeSearch
        {
            get { return isRangeSearch; }
            set { isRangeSearch = value; }
        }

        //Phương thức xây dựng
        public Tree()
        {
            root = null;
        }

        //Phương thức tìm một nút trên cây
        public Node Search(double xVal, double yVal)
        {
            Node current = root;

            while (current.XVal != xVal || current.YVal != yVal)
            {
                if ((current.Level % 2 == 0 && xVal < current.XVal) || (current.Level % 2 != 0 && yVal < current.YVal))
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
                if (current == null)
                {
                    return null;
                }
            }
            
            return current;
        }

        //Thêm nút
        public void Insert(double xVal, double yVal)
        {
            Node newNode = new Node(xVal, yVal);
            if (root == null)
            {
                root = newNode;
                root.Level = 0;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    if (current.XVal == xVal && current.YVal == yVal)
                    {
                        //break;
                        throw new Exception(String.Format("Nút ({0}, {1}) đã tồn tại trên cây", xVal, yVal));
                    }
                    else
                    {
                        parent = current;
                        if ((current.Level % 2 == 0 && xVal < current.XVal) || (current.Level % 2 != 0 && yVal < current.YVal))
                        {
                            current = current.Left;
                            if (current == null)
                            {
                                parent.Left = newNode;
                                parent.Left.Parent = parent;
                                parent.Left.Level = parent.Level + 1;
                                break;
                            }
                        }
                        else
                        {
                            current = current.Right;
                            if (current == null)
                            {
                                parent.Right = newNode;
                                parent.Right.Parent = parent;
                                parent.Right.Level = parent.Level + 1;
                                break;
                            }
                        }
                    }
                }
            }
        }

        //Tính chiều cao cây
        public int Height(Node theRoot)
        {
            int hl = 0, hr = 0;
            if (theRoot == null)
            {
                return 0;
            }
            if (theRoot.Left == null && theRoot.Right == null)
            {
                return theRoot.Level;
            }
            hl = Height(theRoot.Left);
            hr = Height(theRoot.Right);

            return hl > hr ? hl : hr;
        }

        //Vẽ cây
        public void DrawTree(Node theRoot, Graphics g, int col, int d, int xPixel, int yPixel, int xMove, int yMove)
        {
            if (theRoot == null)
            {
                return;
            }
            //Vẽ đường nối giữa 2 con
            Node child = theRoot;
            //Con trái
            child = theRoot.Left;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen myPen = new Pen(Color.Blue, 3);
            myPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            if (child != null)
            {
                g.DrawLine(myPen, col * xPixel + xMove - 25, (theRoot.Level + 1) * yPixel + yMove + 15, (col - d / 2) * xPixel + xMove, (child.Level + 1) * yPixel + yMove - 30);
            }
            else
            {
                g.FillEllipse(new SolidBrush(Color.Black), col * xPixel + xMove - 25 - 5, (theRoot.Level + 1) * yPixel + yMove + 15 - 5, 10, 10);
            }
            //Con phải
            child = theRoot.Right;
            if (child != null)
            {
                g.DrawLine(myPen, col * xPixel + xMove + 25, (theRoot.Level + 1) * yPixel + yMove + 15, (col + d / 2) * xPixel + xMove, (child.Level + 1) * yPixel + yMove - 30);
            }
            else
            {
                g.FillEllipse(new SolidBrush(Color.Black), col * xPixel + xMove + 25 - 5, (theRoot.Level + 1) * yPixel + yMove + 15 - 5, 10, 10);
            }
            //Vẽ nút
            theRoot.DrawNode(g, col, xPixel, yPixel, xMove, yMove);
            //Đệ quy
            DrawTree(theRoot.Left, g, col - d / 2, d / 2, xPixel, yPixel, xMove, yMove);
            DrawTree(theRoot.Right, g, col + d / 2, d / 2, xPixel, yPixel, xMove, yMove);
        }

        //Đặt lại trạng thái lúc chưa tìm kiếm cho cây
        public void ResetTree(Node theRoot)
        {
            if (theRoot != null)
            {
                theRoot.IsFind = false;
                ResetTree(theRoot.Left);
                ResetTree(theRoot.Right);
            }
        }

        //Tìm nút có giá trị Min
        private Node FindMin(Node node, bool isXVal)
        {            
            if (node == null)
            {
                return new Node(double.MaxValue, double.MaxValue);
            }
            if (node.Left == null && node.Right == null)
            {
                return node;
            }

            Node nl = FindMin(node.Left, isXVal);
            Node nr = FindMin(node.Right, isXVal);

            Node min = new Node(double.MaxValue, double.MaxValue);
            if ((isXVal && (node.XVal < min.XVal)) || (!isXVal && (node.YVal < min.YVal)))
            {
                min = node;
            }
            if ((isXVal && (nl.XVal < min.XVal)) || (!isXVal && (nl.YVal < min.YVal)))
            {
                min = nl;
            }
            if ((isXVal && (nr.XVal < min.XVal)) || (!isXVal && (nr.YVal < min.YVal)))
            {
                min = nr;
            }
            
            return min;
        }

        //Xóa nút
        public bool Delete(double xVal, double yVal)
        {
            Node current = root;
            Node parent = root;
            bool isLeftChild = true;
            //Tìm nút trên cây
            while (current.XVal != xVal || current.YVal != yVal)
            {
                parent = current;
                if ((current.Level % 2 == 0 && xVal < current.XVal) || (current.Level % 2 != 0 && yVal < current.YVal))
                {
                    isLeftChild = true;
                    current = current.Left;
                }
                else
                {
                    isLeftChild = false;
                    current = current.Right;
                }
                if (current == null)
                {
                    return false;
                }
            }
            //Trường hợp nút lá
            if (current.Left == null && current.Right == null)
            {
                if (current == root)
                {
                    root = null;
                }
                else if (isLeftChild == true)
                {
                    parent.Left = null;
                }
                else
                {
                    parent.Right = null;
                }
            }
            //Cây con phải không rổng
            else if (current.Right != null)
            {
                //Tìm ứng viên
                Node succesor;
                if (current.Level % 2 == 0)
                {
                    succesor = FindMin(current.Right, true);
                }
                else
                {
                    succesor = FindMin(current.Right, false);
                }
                //Lưu lại giá trị X, Y để tránh đệ quy vô hạn lần
                Double X = succesor.XVal;
                Double Y = succesor.YVal;
                //Loại đệ quy
                Delete(succesor.XVal, succesor.YVal);
                //Thay thế giá trị X, Y cho nút đã xóa
                current.XVal = X;
                current.YVal = Y;
            }
            //Cây con phải rổng và cây con trái không rổng
            else if (current.Right == null)
            {
                //Tìm ứng viên
                Node succesor;
                if (current.Level % 2 == 0)
                {
                    succesor = FindMin(current.Left, true);
                }
                else
                {
                    succesor = FindMin(current.Left, false);
                }
                //Lưu lại giá trị X, Y để tránh đệ quy vô hạn lần
                Double X = succesor.XVal;
                Double Y = succesor.YVal;                
                //Loại đệ quy
                Delete(succesor.XVal, succesor.YVal);
                //Thay thế giá trị X, Y cho nút đã xóa
                current.XVal = X;
                current.YVal = Y;
                //Chuyển cây con trái thành cây con phải
                current.Right = current.Left;
                current.Left = null;
            }

            return true;
        }

        //Tính miền đại diện của một nút
        private double[] GetArea(Node node, double maxValue, double minValue)
        {
            double[] area = { minValue, maxValue, minValue, maxValue };
            if (node == root)
            {
                return area;
            }
            double[] parentArea = GetArea(node.Parent, maxValue, minValue);
            if (node.Parent.Level % 2 == 0)
            {
                if (node.Parent.Left == node)
                {
                    area[0] = parentArea[0];
                    area[1] = node.Parent.XVal;
                    area[2] = parentArea[2];
                    area[3] = parentArea[3];
                }
                else
                {
                    area[0] = node.Parent.XVal;
                    area[1] = parentArea[1];
                    area[2] = parentArea[2];
                    area[3] = parentArea[3];
                }
            }
            else
            {
                if (node.Parent.Left == node)
                {
                    area[0] = parentArea[0];
                    area[1] = parentArea[1];
                    area[2] = parentArea[2];
                    area[3] = node.Parent.YVal;
                }
                else
                {
                    area[0] = parentArea[0];
                    area[1] = parentArea[1];
                    area[2] = node.Parent.YVal;
                    area[3] = parentArea[3];
                }
            }

            return area;
        }

        //Tìm giá trị XValMax trên cây
        public double GetXValMax(Node theRoot)
        {
            double xValMax = double.MinValue;
            if (theRoot == null)
            {
                return double.MinValue;
            }
            if (theRoot.Left == null && theRoot.Right == null)
            {
                return theRoot.XVal;
            }
            double maxLeft = GetXValMax(theRoot.Left);
            double maxRight = GetXValMax(theRoot.Right);

            if (theRoot.XVal > xValMax)
            {
                xValMax = theRoot.XVal;
            }
            if (maxLeft > xValMax)
            {
                xValMax = maxLeft;
            }
            if (maxRight > xValMax)
            {
                xValMax = maxRight;
            }
            
            return xValMax;
        }

        //Tìm giá trị YValMax trên cây
        public double GetYValMax(Node theRoot)
        {
            double yValMax = double.MinValue;
            if (theRoot == null)
            {
                return double.MinValue;
            }
            if (theRoot.Left == null && theRoot.Right == null)
            {
                return theRoot.YVal;
            }
            double maxLeft = GetYValMax(theRoot.Left);
            double maxRight = GetYValMax(theRoot.Right);

            if (theRoot.YVal > yValMax)
            {
                yValMax = theRoot.YVal;
            }
            if (maxLeft > yValMax)
            {
                yValMax = maxLeft;
            }
            if (maxRight > yValMax)
            {
                yValMax = maxRight;
            }

            return yValMax;
        }

        //Vẽ miền phân hoạch cho cây
        public void DrawPartitionArea(Node theRoot, Graphics g, int width, int height)
        {
            //Lấy giá trị tọa độ lớn nhất hiện tại trên cây
            double maxCoordinate = GetXValMax(root);
            if (maxCoordinate < GetYValMax(root))
                maxCoordinate = GetYValMax(root);
            double xScale = (width - (width - (height - 20))) / maxCoordinate; //Cái này viết dài dòng vậy nhưng thực ra nó bằng height - 20 (^_^)
            double yScale = (height - 20) / maxCoordinate;
            double MAXVALUE = width > height ? Convert.ToDouble(width) : Convert.ToDouble(height);
            double MINVALUE = 0;

            if (theRoot == null)
            {
                return;
            }

            Pen myPen = new Pen(Color.Blue, 1);
            Brush myBrush;
            if (theRoot.IsFind == true)
            {
                myBrush = new SolidBrush(Color.Red);
            }
            else
            {
                myBrush = new SolidBrush(Color.Black);
            }            

            float[] area = new float[4];
            area[0] = Convert.ToSingle(GetArea(theRoot, MAXVALUE, MINVALUE)[0]) * (float)xScale;
            area[1] = Convert.ToSingle(GetArea(theRoot, MAXVALUE, MINVALUE)[1]) * (float)xScale;
            area[2] = Convert.ToSingle(GetArea(theRoot, MAXVALUE, MINVALUE)[2]) * (float)yScale;
            area[3] = Convert.ToSingle(GetArea(theRoot, MAXVALUE, MINVALUE)[3]) * (float)yScale;

            int X = Convert.ToInt32(theRoot.XVal * xScale);
            int Y = Convert.ToInt32(theRoot.YVal * yScale);
            //Vẽ điểm
            g.FillEllipse(myBrush, X - 5, height - Y - 5, 10, 10);            

            //Vẽ đường phân chia
            if (theRoot.Level % 2 == 0)
            {
                g.DrawString(String.Format("({0}, {1})", theRoot.XVal, theRoot.YVal), new Font("Arial", 10), new SolidBrush(Color.Red), X + 5, height - Y - 10);
                g.DrawLine(myPen, (float)X, height - area[2], (float)X, height - area[3]);
            }
            else
            {
                g.DrawString(String.Format("({0}, {1})", theRoot.XVal, theRoot.YVal), new Font("Arial", 10), new SolidBrush(Color.Red), X - 20, height - Y - 20);
                g.DrawLine(myPen, area[0], height - (float)Y, area[1], height - (float)Y);
            }

            //Đệ quy hai nhánh
            DrawPartitionArea(theRoot.Left, g, width, height);
            DrawPartitionArea(theRoot.Right, g, width, height);
        }

        //Kiểm tra đường tròn có giao với hình vuông
        private bool IsIntersect(Point centre, int radius, int xMin, int xMax, int yMin, int yMax)
        {
            bool result = false;
            //Tăng kích thước vùng bao lên một khoảng bằng bán kính
            xMin -= radius;
            xMax += radius;
            yMin -= radius;
            yMax += radius;
            //Kiểm tra tâm đường tròn có nằm trong miền hình chữ nhật mở rộng không
            if (centre.X <= xMax && centre.X >= xMin && centre.Y <= yMax && centre.Y >= yMin)
            {
                result = true;
            }

            return result;
        }

        //Tìm kiếm theo phạm vi
        public void RangeSearch(Node theNode, Point centre, int radius, int width, int height)
        {
            if (theNode == null)
            {
                return;
            }

            double MAXVALUE = width > height ? Convert.ToDouble(width) : Convert.ToDouble(height);
            double MINVALUE = 0;
            double[] area = GetArea(theNode, MAXVALUE, MINVALUE);
            int xMin = Convert.ToInt32(area[0]);
            int xMax = Convert.ToInt32(area[1]);
            int yMin = Convert.ToInt32(area[2]);
            int yMax = Convert.ToInt32(area[3]);
            //Kiểm tra đường tròn tìm kiếm có giao với miền đại diện không, nếu không giao thì ngừng xét
            if (!IsIntersect(centre, radius, xMin, xMax, yMin, yMax))
            {
                return;
            }
            else
            {
                //Nếu điểm đang xét thuộc đường tròn thì đánh dấu tìm thấy
                if (Math.Sqrt(Math.Pow(theNode.XVal - centre.X, 2) + Math.Pow(theNode.YVal - centre.Y, 2)) <= radius)
                {
                    theNode.IsFind = true;
                }
                //Đệ quy hai nhánh
                RangeSearch(theNode.Left, centre, radius, width, height);
                RangeSearch(theNode.Right, centre, radius, width, height);
            }
        }
    }
}
