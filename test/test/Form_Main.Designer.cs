namespace test
{
    partial class Form_Main
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
            this.MSNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LuongCB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Dong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MSNV
            // 
            this.MSNV.Text = "MSNV";
            this.MSNV.Width = 80;
            // 
            // TenNV
            // 
            this.TenNV.Text = "Ten NV";
            this.TenNV.Width = 80;
            // 
            // LuongCB
            // 
            this.LuongCB.Text = "Luong CB";
            this.LuongCB.Width = 140;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSNV,
            this.TenNV,
            this.LuongCB});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 15);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(302, 304);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(326, 15);
            this.button_Them.Margin = new System.Windows.Forms.Padding(4);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(129, 30);
            this.button_Them.TabIndex = 1;
            this.button_Them.Text = "Them";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(326, 53);
            this.button_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(129, 30);
            this.button_Sua.TabIndex = 2;
            this.button_Sua.Text = "Sua";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(326, 91);
            this.button_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(129, 30);
            this.button_Xoa.TabIndex = 3;
            this.button_Xoa.Text = "Xoa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Dong
            // 
            this.button_Dong.Location = new System.Drawing.Point(324, 129);
            this.button_Dong.Margin = new System.Windows.Forms.Padding(4);
            this.button_Dong.Name = "button_Dong";
            this.button_Dong.Size = new System.Drawing.Size(129, 30);
            this.button_Dong.TabIndex = 4;
            this.button_Dong.Text = "Dong";
            this.button_Dong.UseVisualStyleBackColor = true;
            this.button_Dong.Click += new System.EventHandler(this.button_Dong_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 335);
            this.Controls.Add(this.button_Dong);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Main";
            this.Text = "List View";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader MSNV;
        private System.Windows.Forms.ColumnHeader TenNV;
        private System.Windows.Forms.ColumnHeader LuongCB;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Dong;
        public System.Windows.Forms.ListView listView1;
    }
}

