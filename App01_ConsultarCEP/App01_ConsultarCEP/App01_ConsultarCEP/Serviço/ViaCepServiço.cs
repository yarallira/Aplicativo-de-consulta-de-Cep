using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultarCEP.Serviço.Modelo;
using Newtonsoft.Json;

namespace App01_ConsultarCEP.Serviço
{
    public class ViaCepServiço
    {
        private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/";

        public static Endereço BuscarEnderecoViaCep(string cep)
        {

            string NovoEnderecoURL = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();

            string Conteudo = wc.DownloadString(NovoEnderecoURL);

            Endereço ende = JsonConvert.DeserializeObject<Endereço>(Conteudo);


            return ende;
        }

    }
}
