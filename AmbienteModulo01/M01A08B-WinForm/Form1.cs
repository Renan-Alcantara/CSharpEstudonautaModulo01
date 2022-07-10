using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01A08B_WinForm
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            lblMsg.Text = "Muito prazer em te conhecer, " + nome + "!";
            lblMsg.Visible = true;
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
