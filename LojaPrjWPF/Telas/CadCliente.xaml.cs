using LojaPrjWPF.Model;
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

namespace LojaPrjWPF
{
    /// <summary>
    /// Lógica interna para CadCliente.xaml
    /// </summary>
    public partial class CadCliente : Window
    {
        public CadCliente()
        {
            InitializeComponent();
        }
        private void btnSCliente_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente();
            Endereco endereco = new Endereco();

            cliente.Id = int.Parse(txtNome.Text);
            cliente.Nome = txtNome.Text;
            cliente.Sobrenome = txtSobrenome.Text;
            cliente.CPF = txtCPF.Text;
            endereco.Id = int.Parse(txtNome.Text);
            endereco.Rua = txtRua.Text;
            endereco.Numero = int.Parse(txtNum.Text);
            endereco.Cidade = txtCidade.Text;
            endereco.Estado = txtEstado.Text;
            endereco.Cep = txtCEP.Text; 
        }

    }
}
