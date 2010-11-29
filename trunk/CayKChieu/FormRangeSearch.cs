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
    public partial class FormRangeSearch : Form
    {
        private Point centre = new Point();
        private int radius = 0;
        private bool isSearch = false;

        public Point Centre
        {
            get { return centre; }
            set { centre = value; }
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public bool IsSearch
        {
            get { return isSearch; }
            set { isSearch = value; }
        }

        public FormRangeSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtXVal.Text != String.Empty && txtYVal.Text != String.Empty && txtR.Text != String.Empty)
            {
                isSearch = true;
                centre = new Point(Convert.ToInt32(txtXVal.Text), Convert.ToInt32(txtYVal.Text));
                radius = Convert.ToInt32(txtR.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtXVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtYVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isSearch = false;
            this.Close();
        }
    }
}
