using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public string stdname { get; set; }
        public string roll { get; set; }
        public string reg {  get; set; }
        public string seme { get; set; }
        public string blood { get; set; }
        public string ImagePath { get; set; }

        public Form2()
        {
            InitializeComponent();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = stdname;
            label4.Text = roll;
            label5.Text = reg;
            label6.Text = seme;
            label7.Text = blood;
            pictureBox1.ImageLocation = ImagePath;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
