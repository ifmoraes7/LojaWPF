using LojaPrjWPF.Model;
using LojaPrjWPF.Service.Constants;
using LojaPrjWPF.Service.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LojaPrjWPF.Service
{
    public class ClienteService
    {
        private ConversoesJson _conversoesJson;
        public ClienteService()
        {
            _conversoesJson = new ConversoesJson();
        }
        public void AdicionarCliente(Cliente cliente)
        {
            Cliente last = ListarClientes().OrderByDescending(x => x.Id).Last(); //Uso de LINQ
            cliente.Id = last.Id++;

            _conversoesJson.SalvarJson(cliente, NomeJsonConst.Clientes);

        }
        public List<Cliente> ListarClientes()
        {
            return (List<Cliente>)_conversoesJson.LeituraJson(NomeJsonConst.Clientes);
        }
        /*public List<Cliente> AlterarClientes()
        {

        }*/
    }
}
