using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Serviço.Modelo;
using App01_ConsultarCEP.Serviço;


namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTÃO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args) {

            string cep = CEP.Text.Trim();
            Endereço end = ViaCepServiço.BuscarEnderecoViaCep(cep);

            

            RESULTADO.Text = "Endereço: " 
                + "Cep: " + end.cep +"\n" 
                + "Rua: " + end.logradouro + "\n" 
                + "Bairro: " + end.bairro + "\n"
                + "Cidade: " + end.localidade + "\n"
                + "Estado: " + end.uf + "\n"
                + " * YARA MÁRCIA LIRA * "
                //+ "Rua: " + end.complemento + "\n"
                //+ "Rua: " + end.complemento + "\n"
                //+ "Rua: " + end.complemento + "\n"
                ;

        }
    }
}
