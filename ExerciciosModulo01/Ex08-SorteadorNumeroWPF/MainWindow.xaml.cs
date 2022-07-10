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

namespace Ex08_SorteadorNumeroWPF
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

        private async void btnSort_Click(object sender, RoutedEventArgs e)
        {

            lblSort.FontSize = 15;
            string load = "Carregando";
            lblSort.Content = load;
            int time = 0;
            while (time < 20)
            {
                await Task.Delay(0100);
                load = load + " .";
                lblSort.Content = $"{load}";
                time = (int)time + 1;
            }
            int numIni = 0;
            int.TryParse(boxIni.Text, out numIni);
            int numFin = 0;
            int.TryParse(boxFin.Text, out numFin);

            Random random = new Random();
            int numSort = random.Next(numIni, numFin);

            lblSort.Content = $"\nEntre os números {numIni} e {numFin}, \nsorteei o número {numSort}.";

            boxIni.Text = "";
            boxFin.Text = "";
            
        }
    }
}
