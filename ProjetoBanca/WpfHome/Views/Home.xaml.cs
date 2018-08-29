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
using WpfHome.Views;

namespace WpfHome
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

        private void btnProdutos_Click(object sender, RoutedEventArgs e)
        {
            TelaProdutos telaProdutos = new TelaProdutos();
            telaProdutos.Show();
        }

        private void BtnParceiros_Click(object sender, RoutedEventArgs e)
        {
            TelaParceiros telaParceiros = new TelaParceiros();
            telaParceiros.Show();
        }

        private void btnEstoque_Click(object sender, RoutedEventArgs e)
        {
            TelaEstoque telaEstoque = new TelaEstoque();
            telaEstoque.Show();
        }

        private void btnCompras_Click(object sender, RoutedEventArgs e)
        {
            TelaCompras telaCompras = new TelaCompras();
            telaCompras.Show();
        }

        private void btnVendas_Click(object sender, RoutedEventArgs e)
        {
            TelaVendas telaVendas = new TelaVendas();
            telaVendas.Show();
        }
    }
}
