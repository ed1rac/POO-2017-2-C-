using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2017_2
{
    class Carro
    {
        private string motor;
        public int anoDeFabricacao;
        public string modelo;
        public int quantMarchas;
        public bool tracao;
        public int aroRodas;
        public string tipoCarro;
        public string cor;

        public void ligar()
        {
            Console.WriteLine("O carro " + this.modelo + " ligou!"); Console.ReadLine();
        }

        public void acelerar()
        {
            Console.WriteLine("O carro " + this.modelo + " está acelerando!"); Console.ReadLine();
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
            Console.WriteLine(mensagem); Console.ReadLine();
        }

        public void frear()
        {
            Console.WriteLine("O carro " + modelo + " está freando!"); Console.ReadLine();
        }

        public void desligar()
        {
            Console.WriteLine("O carro " + modelo + " está desligando!"); Console.ReadLine();
        }

        public void exibeInformacoes()
        {
            string mensagem = "";
            mensagem += "======= INFORMACOES DO CARRO =======" + "\n";
            mensagem += "Modelo ..........: " + modelo + "\n";
            mensagem += "Tipo.............: " + tipoCarro + "\n";
            mensagem += "Ano..............: " + anoDeFabricacao + "\n";
            mensagem += "Cor..............: " + cor + "\n";
            mensagem += "Quant. marchas...: " + quantMarchas + "\n";
            mensagem += "Motor............: " + this.getMotor() + "\n";
            mensagem += "Rodas de aro.....: " + aroRodas + "\n";
            if (tracao == true)
            {
                mensagem += "Carro traçado!" + "\n";
            }
            else
            {
                mensagem += "Carro não traçado!" + "\n";
            }
            mensagem += "====================================" + "\n";

            Console.WriteLine(mensagem); Console.ReadLine();
        }

        public void setMotor(String motor)
        {
            this.motor = motor;
        }

        public string getMotor()
        {
            return this.motor;
        }
    }
}
