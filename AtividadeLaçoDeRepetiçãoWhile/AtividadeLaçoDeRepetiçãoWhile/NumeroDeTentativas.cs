using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLaçoDeRepetiçãoWhile
{
    internal class NumeroDeTentativas
    {
        public static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Digite um número entre 1 e 100: ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 1 && numero <= 100)
                {
                    Console.WriteLine("Número válido! Obrigado.");
                    break;
                }
                else
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                }

            } while (true);
        }
    }
}