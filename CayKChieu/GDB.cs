using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace CayKChieu
{
    /// <summary>
    /// Lớp Graphics Double Buffer giúp chống giật hình khi di chuyển đối tượng bằng cách
    /// vẽ lên ảnh rồi vẽ ảnh ra màn hình
    /// </summary>
    class GDB
    {
        private Bitmap pCanvas;

        public Bitmap Canvas
        {
            get { return pCanvas; }
            set { pCanvas = value; }
        }

        /// <summary>
        /// Khởi tạo Graphics buffer
        /// </summary>
        /// <param name="canvasWidth">Chiều rộng</param>
        /// <param name="canvasHeight">Chiều dài</param>
        public GDB(int canvasWidth, int canvasHeight)
        {
            pCanvas = new Bitmap(canvasWidth, canvasHeight);
        }

        /// <summary>
        /// Khởi tạo một đối tượng đồ họa từ ảnh
        /// </summary>
        /// <returns>Trả về đối tượng đồ họa</returns>
        public Graphics Store()
        {
            Graphics g = Graphics.FromImage(pCanvas);
            return g;
        }

        /// <summary>
        /// Vẽ ảnh lên đối tượng
        /// </summary>
        /// <param name="where">Đối tượng cần vẽ</param>
        public void Paint(Control where)
        {
            Graphics g = where.CreateGraphics();
            g.SmoothingMode = SmoothingMode.None;
            g.DrawImage(pCanvas, 0, 0);
            g.Dispose();
        }

        /// <summary>
        /// Hũy Graphics buffer
        /// </summary>
        public void Dispone()
        {
            pCanvas.Dispose();
        }
    }
}
