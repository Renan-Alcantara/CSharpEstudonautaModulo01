using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02_BrasilBrasileiroForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            lbl1.ForeColor = Color.Yellow;
            lbl1.BackColor = Color.Blue;
            lbl1.Text = " Brasil ";
            lbl1.Visible = true;

            await Task.Delay(1000);
            lbl2.ForeColor = Color.Green;
            lbl2.BackColor = Color.Yellow;
            lbl2.Text = " meu Brasil ";
            lbl2.Visible = true;

            await Task.Delay(1000);
            lbl3.ForeColor = Color.Yellow;
            lbl3.BackColor = Color.Green;
            lbl3.Text = " Brasileiro!!! ";
            lbl3.Visible = true;
        }
    }
}
