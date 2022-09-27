using LojaPrjWPF.Model;
using LojaPrjWPF.Service;
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
using System.Windows.Shapes;

namespace LojaPrjWPF.Telas
{
    /// <summary>
    /// Lógica interna para ListarClientes.xaml
    /// </summary>
    public partial class ListarClientes : Window
    {
        private ClienteService _clienteService;
        
        public ListarClientes()
        {
            _clienteService = new ClienteService();
            InitializeComponent();
            PopularGrid();
        }
        public void PopularGrid()
        {
            grdListaClientes.ItemsSource = _clienteService.ListarClientes();
            //grdListaClientes.Columns[5].Visibility = Visibility.Hidden;
        }

    }

}
