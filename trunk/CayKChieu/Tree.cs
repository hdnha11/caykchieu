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

        //Thuộc tính
        public Node Root
        {
            get { return root; }
            set { root = value; }
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
                        break;
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
    }
}
