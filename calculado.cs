using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione a operação:");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");

            Console.Write("Digite sua escolha (1/2/3/4): ");
            int escolha = int.Parse(Console.ReadLine());

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = 0.0;

            switch (escolha)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, resultado);
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, resultado);
                    break;
                case 4:
                    resultado = num1 / num2;
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, resultado);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.ReadLine();
        }
    }
}