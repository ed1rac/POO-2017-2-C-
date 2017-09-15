using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2017_2
{
    class TV
    {
        bool ligada;
        int canal, volume;

        void ligar()
        {
            if (ligada == false)
            {
                Console.WriteLine("A TV foi ligada!");
                ligada = true;
            }
            else
            {
                Console.WriteLine("A TV já está ligada!");
            }
        }
        void desligar()
        {
            if (ligada == true)
            {
                Console.WriteLine("A TV foi desligada!");
                ligada = false;
            }
            else
            {
                Console.WriteLine("A TV já está desligada!");
            }
        }
        void aumentarVolume()
        {
            volume++;
        }
        void aumentarVolume(int valor)
        {
            for (int i = 1; i <= valor; i++)
                aumentarVolume();
        }
        void diminuirVolume()
        {
            volume--;
        }
        void trocarCanal(int c)
        {
            canal = c;
        }

        void mostraInfo()
        {
            Console.WriteLine("======================");
            Console.WriteLine("ligada? " + ligada);
            Console.WriteLine("Canal  ==> " + canal);
            Console.WriteLine("Volume ==> " + volume);
            Console.WriteLine("======================");
        }
    }
}
