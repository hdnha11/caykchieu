using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CayKChieu
{
    public class Node
    {
        private Point info;
        private double xVal;
        private double yVal;
        private Node left;
        private Node right;
        private Node parent;
        private int level;
        private bool isFind = false;

        //Thuộc tính
        public Point Info
        {
            get { return info; }
            set { info = value; }
        }

        public double XVal
        {
            get { return xVal; }
            set { xVal = value; }
        }

        public double YVal
        {
            get { return yVal; }
            set { yVal = value; }
        }

        public Node Left
        {
            get { return left; }
            set { left = value; }
        }

        public Node Right
        {
            get { return right; }
            set { right = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public Node Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        public bool IsFind
        {
            get { return isFind; }
            set { isFind = value; }
        }

        //Phương thức xây dựng
        public Node(double xVal, double yVal)
        {
            info.X = 0;
            info.Y = 0;
            this.xVal = xVal;
            this.yVal = yVal;
            left = right = parent = null;
            level = -1;
        }

        //Vẽ nút
        public void DrawNode(Graphics g, int col, int xPixel, int yPixel, int xMove , int yMove)
        {
            info.X = col * xPixel + xMove;
            info.Y = (level + 1) * yPixel + yMove;
            //Nếu đang được tìm thấy sẽ vẽ màu đỏ
            Pen myPen;
            if (isFind)
            {
                myPen = new Pen(Color.Red, 2);
            }
            else
            {
                myPen = new Pen(Color.Blue, 2);
            }            
            Brush myBrush = new SolidBrush(Color.Green);
            //g.DrawEllipse(myPen, info.X - 15, info.Y - 15, 30, 30);
            g.DrawRectangle(myPen, info.X - 50, info.Y - 30, 100, 60);
            g.DrawLine(myPen, info.X - 50, info.Y, info.X + 50, info.Y);
            g.DrawLine(myPen, info.X, info.Y, info.X, info.Y + 30);
            g.DrawString(String.Format("({0}, {1})", xVal.ToString(), yVal.ToString()), new Font("Aria", 12), myBrush, new Point(info.X - 30, info.Y - 25));
        }
    }
}
