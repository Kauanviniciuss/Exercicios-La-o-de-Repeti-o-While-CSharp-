using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLaçoDeRepetiçãoWhile
{
    internal class BuscaDeNumero
    {
        public static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Digite um número secreto: ");
                num = Convert.ToInt16(Console.ReadLine());

                if (num == 12)
                {
                    Console.WriteLine("Parabéns você acertou");
                }
                else
                {
                    Console.WriteLine("Você errou, tente de novo");
                }
            }
            while (num != 12);
            ;
        }
    }
}