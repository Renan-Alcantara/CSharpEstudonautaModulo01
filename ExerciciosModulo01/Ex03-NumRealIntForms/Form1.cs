using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex03_NumRealIntForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            float num = 0f;
            float.TryParse(txtNum.Text, out num);

            lblNum.Text = $"Você digitou o valor {num}";
            lblNum.Visible = true;

            lblInt.Text = $"A parte inteira do número é {(int)num}";
            lblInt.Visible = true;

            lblArr.Text = $"Arredondando, temos o número {Convert.ToInt16(num)}";
            lblArr.Visible = true;

        }
    }
}
