using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordLink
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            this.Hide();
            form3.Show();
        }
    }
}
