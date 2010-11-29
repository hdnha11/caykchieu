namespace CayKChieu
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRangeSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteTree = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnResetLocation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbGrid = new System.Windows.Forms.PictureBox();
            this.ptbTree = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTree)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CayKChieu.Properties.Resources.NL2BG;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 411);
            this.panel1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnRangeSearch);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnDeleteTree);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnResetLocation);
            this.groupBox2.Location = new System.Drawing.Point(65, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 300);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnRangeSearch
            // 
            this.btnRangeSearch.Image = global::CayKChieu.Properties.Resources.doc_find;
            this.btnRangeSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRangeSearch.Location = new System.Drawing.Point(54, 111);
            this.btnRangeSearch.Name = "btnRangeSearch";
            this.btnRangeSearch.Size = new System.Drawing.Size(100, 40);
            this.btnRangeSearch.TabIndex = 11;
            this.btnRangeSearch.Text = "Tìm theo\r\nphạm vi";
            this.btnRangeSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRangeSearch.UseVisualStyleBackColor = true;
            this.btnRangeSearch.Click += new System.EventHandler(this.btnRangeSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::CayKChieu.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(54, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm nút";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteTree
            // 
            this.btnDeleteTree.Image = global::CayKChieu.Properties.Resources.delete;
            this.btnDeleteTree.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTree.Location = new System.Drawing.Point(54, 203);
            this.btnDeleteTree.Name = "btnDeleteTree";
            this.btnDeleteTree.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteTree.TabIndex = 5;
            this.btnDeleteTree.Text = "Xóa cây";
            this.btnDeleteTree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteTree.UseVisualStyleBackColor = true;
            this.btnDeleteTree.Click += new System.EventHandler(this.btnDeleteTree_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::CayKChieu.Properties.Resources.find;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(54, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm nút";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::CayKChieu.Properties.Resources.remove;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(54, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa nút";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnResetLocation
            // 
            this.btnResetLocation.Image = global::CayKChieu.Properties.Resources.reload;
            this.btnResetLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetLocation.Location = new System.Drawing.Point(54, 249);
            this.btnResetLocation.Name = "btnResetLocation";
            this.btnResetLocation.Size = new System.Drawing.Size(100, 40);
            this.btnResetLocation.TabIndex = 6;
            this.btnResetLocation.Text = "Vẽ lại cây";
            this.btnResetLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetLocation.UseVisualStyleBackColor = true;
            this.btnResetLocation.Click += new System.EventHandler(this.btnResetLocation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(65, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 97);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điểm dữ liệu";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(85, 24);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 0;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(85, 58);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 1;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Giá trị X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giá trị Y:";
            // 
            // ptbGrid
            // 
            this.ptbGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbGrid.Location = new System.Drawing.Point(0, 417);
            this.ptbGrid.Name = "ptbGrid";
            this.ptbGrid.Size = new System.Drawing.Size(340, 245);
            this.ptbGrid.TabIndex = 7;
            this.ptbGrid.TabStop = false;
            // 
            // ptbTree
            // 
            this.ptbTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbTree.Location = new System.Drawing.Point(346, 0);
            this.ptbTree.Name = "ptbTree";
            this.ptbTree.Size = new System.Drawing.Size(662, 662);
            this.ptbTree.TabIndex = 0;
            this.ptbTree.TabStop = false;
            this.ptbTree.MouseLeave += new System.EventHandler(this.ptbTree_MouseLeave);
            this.ptbTree.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbTree_MouseMove);
            this.ptbTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbTree_MouseDown);
            this.ptbTree.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbTree_Paint);
            this.ptbTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbTree_MouseUp);
            this.ptbTree.MouseEnter += new System.EventHandler(this.ptbTree_MouseEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbGrid);
            this.Controls.Add(this.ptbTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Cây K chiều - Demo với cây 2 chiều";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnDeleteTree;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnResetLocation;
        private System.Windows.Forms.PictureBox ptbGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRangeSearch;
    }
}

