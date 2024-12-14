using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLaçoDeRepetiçãoWhile
{
    internal class ContagemDeVogais
    {
        public static void Main(string[] args)
        {
            string entrada;

            do
            {

                Console.WriteLine("Digite uma frase (ou 'fim' para encerrar): ");
                entrada = Console.ReadLine();


                if (entrada.ToLower() != "fim")
                {
                    int contagem = ContarVogais(entrada);
                    Console.WriteLine($"A string contém {contagem} vogais.");
                }

            } while (entrada.ToLower() != "fim");

            Console.WriteLine("Programa encerrado.");
        }

        static int ContarVogais(string str)
        {
            int contador = 0;

            str = str.ToLower();


            foreach (char c in str)
            {

                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}

