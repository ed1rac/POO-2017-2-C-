using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POO_2017_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();

            carro.modelo = "Palio";
            carro.tipoCarro = "Hatch";
            carro.anoDeFabricacao = 2015;
            carro.aroRodas = 15;
            carro.cor = "prata";
            carro.motor = "1.4";
            carro.quantMarchas = 4;
            carro.tracao = false;

            string mensagem = "O modelo é : " + carro.modelo + "\n";
            mensagem += "O tipo de carro é: " + carro.tipoCarro + "\n";
            mensagem+= "O ano de fabricação é: " + carro.anoDeFabricacao + "\n";


            MessageBox.Show(mensagem);
            carro.ligar();
            carro.acelerar();
            carro.acelerar(60); //polimorfismo
            carro.frear();
            carro.desligar();
            carro.exibeInformacoes();

        }

    }
}
