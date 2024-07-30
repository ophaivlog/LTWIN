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
    public partial class Form_NV : Form
    {
        public Form_NV()
        {
            InitializeComponent();
        }

        public string tacvu = "";
        private void button_Yes_Click(object sender, EventArgs e)
        {
            if (tacvu == "them")
            {
                Form_Main.this_.listView1.Items.Add(textBox_MSNV.Text);
                Form_Main.this_.listView1.Items[Form_Main.this_.listView1.Items.Count - 1].SubItems.Add(textBox_TenNV.Text);
                Form_Main.this_.listView1.Items[Form_Main.this_.listView1.Items.Count - 1].SubItems.Add(textBox_LuongCB.Text);
            }
            else if (tacvu == "sua")
            {
                for (int i = 0; i < Form_Main.this_.listView1.Columns.Count; i++)
                {
                    if (textBox_MSNV.Text == Form_Main.this_.listView1.Items[i].Text)
                    {
                        Form_Main.this_.listView1.Items[i].SubItems[1].Text = textBox_TenNV.Text;
                        Form_Main.this_.listView1.Items[i].SubItems[2].Text = textBox_LuongCB.Text;
                    }
                }
            }
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
