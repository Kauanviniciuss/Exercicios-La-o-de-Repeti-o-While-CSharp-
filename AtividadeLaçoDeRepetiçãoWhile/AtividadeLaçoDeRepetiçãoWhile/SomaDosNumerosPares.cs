using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLaçoDeRepetiçãoWhile
{
    internal class SomaDosNumerosPares
    {
        public static void Main(string[] args)
        {
            int numero, somaPares = 0;

            do
            {
                Console.Write("Digite um número (0 para sair): ");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0) break;

                if (numero % 2 == 0) somaPares += numero;

            } while (true);

            Console.WriteLine("A soma dos números pares é: " + somaPares);
        }
    }
}