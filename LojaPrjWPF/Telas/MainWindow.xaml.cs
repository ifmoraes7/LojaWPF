using LojaPrjWPF.Telas;
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

namespace LojaPrjWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        //private 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCadastroCliente_Click(object sender, RoutedEventArgs e)
        {
           // CadCliente cadcliente = new CadCliente();
           // object clientes1 = cadcliente.Content;
            //ClienteCad clientecad = new ClienteCad();
            //grdCadCliente.Children.Add(cadcliente.Content);


        }

        private void btnListarClientes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnCadastrarPedido_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSair_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnListarPedidos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnListarProdutos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnProdutos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCadastrarProduto_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
