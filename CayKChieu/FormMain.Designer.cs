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
            this.ptbTree = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnDeleteTree = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnResetLocation = new System.Windows.Forms.Button();
            this.ptbGrid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGrid)).BeginInit();
            this.SuspendLayout();
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
            this.ptbTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbTree_MouseUp);
            this.ptbTree.MouseEnter += new System.EventHandler(this.ptbTree_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giá trị X:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm nút";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(74, 41);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 3;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá trị Y:";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(74, 75);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 3;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // btnDeleteTree
            // 
            this.btnDeleteTree.Location = new System.Drawing.Point(49, 201);
            this.btnDeleteTree.Name = "btnDeleteTree";
            this.btnDeleteTree.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTree.TabIndex = 4;
            this.btnDeleteTree.Text = "Xóa cây";
            this.btnDeleteTree.UseVisualStyleBackColor = true;
            this.btnDeleteTree.Click += new System.EventHandler(this.btnDeleteTree_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(49, 143);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm nút";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(49, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa nút";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnResetLocation
            // 
            this.btnResetLocation.Location = new System.Drawing.Point(49, 230);
            this.btnResetLocation.Name = "btnResetLocation";
            this.btnResetLocation.Size = new System.Drawing.Size(75, 23);
            this.btnResetLocation.TabIndex = 6;
            this.btnResetLocation.Text = "Đặt lại vị trí";
            this.btnResetLocation.UseVisualStyleBackColor = true;
            this.btnResetLocation.Click += new System.EventHandler(this.btnResetLocation_Click);
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.ptbGrid);
            this.Controls.Add(this.btnResetLocation);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeleteTree);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Demo cây K chiều";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ptbTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

