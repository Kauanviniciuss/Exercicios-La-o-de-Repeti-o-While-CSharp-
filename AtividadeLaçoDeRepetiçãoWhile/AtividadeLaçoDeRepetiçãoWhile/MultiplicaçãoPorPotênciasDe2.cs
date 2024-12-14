using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLaçoDeRepetiçãoWhile
{
    internal class MultiplicaçãoPorPotênciasDe2
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int potencia = 1; 
            int resultado = numero;

            while (resultado <= 1000)
            {
                Console.WriteLine(numero + " x " + potencia + " = " + resultado);
                potencia *= 2;
                resultado = numero * potencia;
            }
        }
    }
}