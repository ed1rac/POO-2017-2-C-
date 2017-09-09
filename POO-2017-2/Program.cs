using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2017_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            //carro.modelo = "Palio";
            Console.WriteLine("Digite o modelo do carro: ");
            carro.modelo = Console.ReadLine();
            carro.tipoCarro = "Hatch";
            carro.anoDeFabricacao = 2015;
            carro.aroRodas = 15;
            carro.cor = "prata";
            //carro.motor = "1.4";
            carro.setMotor("1.4");
            carro.quantMarchas = 4;
            carro.tracao = false;

            string mensagem = "O modelo é : " + carro.modelo + "\n";
            mensagem += "O tipo de carro é: " + carro.tipoCarro + "\n";
            mensagem += "O ano de fabricação é: " + carro.anoDeFabricacao + "\n";


            Console.WriteLine(mensagem);
            carro.ligar();
            carro.acelerar();
            carro.acelerar(60); //polimorfismo
            carro.frear();
            carro.desligar();
            carro.exibeInformacoes();
        }
    }
}
