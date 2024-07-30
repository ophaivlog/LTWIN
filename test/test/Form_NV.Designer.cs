namespace test
{
    partial class Form_NV
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MSNV = new System.Windows.Forms.TextBox();
            this.textBox_TenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_LuongCB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Yes = new System.Windows.Forms.Button();
            this.button_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV:";
            // 
            // textBox_MSNV
            // 
            this.textBox_MSNV.Location = new System.Drawing.Point(67, 8);
            this.textBox_MSNV.Name = "textBox_MSNV";
            this.textBox_MSNV.Size = new System.Drawing.Size(247, 22);
            this.textBox_MSNV.TabIndex = 1;
            // 
            // textBox_TenNV
            // 
            this.textBox_TenNV.Location = new System.Drawing.Point(114, 39);
            this.textBox_TenNV.Name = "textBox_TenNV";
            this.textBox_TenNV.Size = new System.Drawing.Size(200, 22);
            this.textBox_TenNV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ten nhan vien:";
            // 
            // textBox_LuongCB
            // 
            this.textBox_LuongCB.Location = new System.Drawing.Point(114, 67);
            this.textBox_LuongCB.Name = "textBox_LuongCB";
            this.textBox_LuongCB.Size = new System.Drawing.Size(200, 22);
            this.textBox_LuongCB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Luong can ban:";
            // 
            // button_Yes
            // 
            this.button_Yes.Location = new System.Drawing.Point(67, 107);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(75, 32);
            this.button_Yes.TabIndex = 6;
            this.button_Yes.Text = "Dong Y";
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // button_No
            // 
            this.button_No.Location = new System.Drawing.Point(148, 107);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(75, 32);
            this.button_No.TabIndex = 7;
            this.button_No.Text = "Bo qua";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // Form_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 151);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Yes);
            this.Controls.Add(this.textBox_LuongCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_TenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_MSNV);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_NV";
            this.Text = "Form_NV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MSNV;
        private System.Windows.Forms.TextBox textBox_TenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_LuongCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.Button button_No;
    }
}