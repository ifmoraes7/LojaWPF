using LojaPrjWPF.Model;
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
        public void SerializarJsonCliente(Cliente cliente)
        {
            
            string jsonString = JsonConvert.SerializeObject(cliente); //Criação do JSON
            string path = @"C:\Users\Iagof\source\repos\Benner PRJS\LojaWPF\Arquivos\Clientes.json";
            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(jsonString);
                tw.Close();
            }


            /*if (File.Exists(path))
            {
            }
            else 
            {
             
            }*/



        }

    }
}
