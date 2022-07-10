using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.DateTime;

namespace Ex06_IdadeWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            int ano = 0;
            int.TryParse(txtBox.Text, out ano);
            int anoAtual = Now.Year;
            lblAno.Content = $"Atualmente, estamos no ano de {anoAtual}";
            lblIdade.Content = $"Se você nasceu em {ano}, certamente tem entre {anoAtual - ano - 1} e {anoAtual - ano} anos";
            txtBox.Text = "";

        }
    }
}
