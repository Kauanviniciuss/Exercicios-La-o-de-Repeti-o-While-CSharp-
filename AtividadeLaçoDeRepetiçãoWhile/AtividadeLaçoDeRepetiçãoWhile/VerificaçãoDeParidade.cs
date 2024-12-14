using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLaçoDeRepetiçãoWhile
{
    internal class VerificaçãoDeParidade
    {
        public static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Número par detectado. Sucesso!");
                    break;
                }
                else
                {
                    Console.WriteLine("Número ímpar, tente novamente.");
                }
            } while (true);
        }
    }
}