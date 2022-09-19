using LojaPrjWPF.Model;
using LojaPrjWPF.Service.Constants;
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
        private string _path;
        string json = "";

        public ConversoesJson()
        {
            _path = @"C:\Users\Iagof\source\repos\Benner PRJS\LojaWPF\Arquivos\";
        }
        public void SalvarJson(Object obj, string nomeJson)
        {
            string jsonString = JsonConvert.SerializeObject(obj); //Criação do JSON

            using (var tw = new StreamWriter(_path + nomeJson, true))
            {
                tw.WriteLine(jsonString);
                tw.Close();
            }
        }
        public Object LeituraJson(string nomeJson)
        {
            var json = "[";
            using (StreamReader objd = new StreamReader(_path + nomeJson))
            {
                json += objd.ReadToEnd() + "]";
            }
            switch (nomeJson)
            {
                case NomeJsonConst.Clientes:
                    return JsonConvert.DeserializeObject<Cliente>(json);
                    break;
            }

            return null;
            //List<Object> items = (Cliente)JsonConvert.DeserializeObject<Object>(json);
        }
    }
}
