using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POO_2017_02
{
    class Carro
    {
        public string motor;
        public int anoDeFabricacao;
        public string modelo;
        public int quantMarchas;
        public bool tracao;
        public int aroRodas;
        public string tipoCarro;
        public string cor;

        public void ligar()
        {
            MessageBox.Show("O carro " + this.modelo + " ligou!");
        }

        public void acelerar()
        {
            MessageBox.Show("O carro " + this.modelo + " está acelerando!");
        }

        public void acelerar(int velocidade)
        {
            string mensagem = "O carro está acelerando\n";
            for (int i = 0; i <= velocidade; i += 5)
            {
                mensagem += "Velocímetro: " + i + "\t";
                if (i % 10 == 0)
                {
                    mensagem += "\n";
                }
            }
            MessageBox.Show(mensagem);
        }

        public void frear()
        {
            MessageBox.Show("O carro " + modelo + " está freando!");
        }

        public void desligar()
        {
            MessageBox.Show("O carro " + modelo + " está desligando!");
        }

        public void exibeInformacoes()
        {
            string mensagem = "";
            mensagem += "======= INFORMACOES DO CARRO =======" + "\n";
            mensagem += "Modelo ..........:" + modelo + "\n";
            mensagem += "Tipo.............:" + tipoCarro + "\n";
            mensagem += "Ano..............:" + anoDeFabricacao + "\n";
            mensagem += "Cor..............:" + cor + "\n";
            mensagem += "Quant. marchas...:" + quantMarchas + "\n";
            mensagem += "Motor............:" + motor + "\n";
            mensagem += "Rodas de aro.....:" + aroRodas + "\n";
            if (tracao == true)
            {
                mensagem += "Carro traçado!" + "\n";
            }
            else
            {
                mensagem += "Carro não traçado!" + "\n";
            }
            mensagem += "====================================" + "\n";

            MessageBox.Show(mensagem);
        }
    }

}
