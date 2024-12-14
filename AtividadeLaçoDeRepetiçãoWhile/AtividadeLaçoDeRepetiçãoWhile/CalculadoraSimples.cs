using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLaçoDeRepetiçãoWhile
{
    internal class CalculadoraSimples
    {
        public static void Main(string[] args)
        {
            string operacao;
            do
            {
                Console.WriteLine("Digite um número: ");
                int num1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Digite outro número: ");
                int num2 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Digite uma operação:");
                Console.WriteLine("+:");
                Console.WriteLine("-:");
                Console.WriteLine("*:");
                Console.WriteLine("/:");
                Console.WriteLine("Digite sair para cancelar:");
                operacao = Console.ReadLine();

                switch (operacao)
                {
                    case "+":
                        Console.WriteLine($"A soma é: {num1 + num2}");
                        break;
                    case "-":

                        Console.WriteLine($"A subtração é  {num1 - num2}");
                        break;
                    case "*":

                        Console.WriteLine($"A multiplicação é {num1 * num2}");
                        break;
                    case "/":
                        Console.WriteLine($"A divisão é {num1 / num2}");
                        break;
                    default:
                        Console.WriteLine("Operação errada");
                        break;
                }
            }
            while (operacao != "sair");

            Console.WriteLine("Programa cancelado");
        }
    }
}
