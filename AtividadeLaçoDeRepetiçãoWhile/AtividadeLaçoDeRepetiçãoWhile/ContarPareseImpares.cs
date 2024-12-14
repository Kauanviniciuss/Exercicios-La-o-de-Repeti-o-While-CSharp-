using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLaçoDeRepetiçãoWhile
{
    internal class ContarPareseImpares
    {
        public static void Main(string[] args)
        {
            int numero, pares = 0, impares = 0;

            do
            {
                Console.Write("Digite um número (0 para sair): ");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0) break;

                if (numero % 2 == 0) pares++;
                else impares++;

            } while (true);

            Console.WriteLine("Números pares: " + pares);
            Console.WriteLine("Números ímpares: " + impares);
        }
    }
}