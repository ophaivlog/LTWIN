using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form_Main : Form
    {
        public static Form_Main this_;
        public Form_Main()
        {
            InitializeComponent();
            this_ = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class_Form.form_NV.Show();
            Class_Form.form_NV.tacvu = "them";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) 
            { 
                ListViewItem item = listView1.SelectedItems[0];
               
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            Class_Form.form_NV.Show();
        }

        private void button_Dong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
