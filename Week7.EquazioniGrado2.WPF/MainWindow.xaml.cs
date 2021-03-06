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
using Week7.EquazioniGrado2.Core;

namespace Week7.EquazioniGrado2.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double a;
        private double b;
        private double c;
        private Equation equation = new Equation();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRisolvi_Click(object sender, RoutedEventArgs e)
        {
            a = (string.IsNullOrEmpty(txtValue1.Text)) ? 0 : double.Parse(txtValue1.Text);
            b = (string.IsNullOrEmpty(txtValue2.Text)) ? 0 : double.Parse(txtValue2.Text);
            c = (string.IsNullOrEmpty(txtValue3.Text)) ? 0 : double.Parse(txtValue3.Text);

            var risultato = equation.RisolviequazioniDiSecondoGrado(a, b, c);

            if (risultato == null)
            {
                txtValueRisolvi.Text = "Errore";
            }
            else if (risultato.Length == 1)
            {
                txtValueRisolvi.Text = $"Soluzione: x1=x2={risultato[0]}";
            }
            else if (risultato.Length == 2)
            {
                txtValueRisolvi.Text = $"Soluzioni: x1={risultato[0]} x2={risultato[1]}";
            }

        }
    }
}
