using LojaPrjWPF.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaPrjWPF.Service.Extensions
{
    class ConversoesJson
    {
        public void SalvarJson(Object obj )
        {
            string jsonString = JsonConvert.SerializeObject(obj); //Criação do JSON
            string path = @"C:\Users\Iagof\source\repos\Benner PRJS\LojaWPF\Arquivos";
            /*switch (obj2)
            {
                case Cliente c:
                    Path.Combine(path, @"\Clientes.json");
                break;
            }*/
            if (obj is Cliente)
                Path.Combine(path, @"\Clientes.json");
            if (obj is Pedido)
                Path.Combine(path, @"\Pedido.json");
            if (obj is Produto)
                Path.Combine(path, @"\Produto.json");


            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(jsonString);
                tw.Close();
            }
        }
    }
}
