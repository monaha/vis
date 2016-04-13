using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class homepag : Form
    {
        static String user_name;
        public homepag()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             user_name = textBox1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {this.Hide();
            Form category = new Form();
            
            category.Show();
            
        }
    }
}
