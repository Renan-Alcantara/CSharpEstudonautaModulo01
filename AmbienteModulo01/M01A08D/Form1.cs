using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01A08D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            
            //num = Convert.ToInt16(txtBox.Text);

            int.TryParse(txtBox.Text, out num);
            lblNum.Text = "O Numero digitado foi " + num + "!";
            lblDobro.Text = "O Dobro de " + num + " é " + (num * 2) + "!";
            lblDobro.Visible = true;
            lblNum.Visible = true;
        }
    }
}
