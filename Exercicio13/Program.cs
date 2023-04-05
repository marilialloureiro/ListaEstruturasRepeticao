using System.Net;

namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
//13) Faça um programa que leia um conjunto nao determinado de valores, um de cada vez, escreva
//para cada um dos valores lidos, o quadrado, o cubo e a raiz quadrada.Finalize a entrada de dados
//com um valor negativo ou zero.

            double num;
            do
            {
                Console.Write("Digite um número (negativo ou zero para sair): ");
                num = Convert.ToDouble(Console.ReadLine());

                if (num > 0)
                {
                    double quadrado = Math.Pow(num, 2);
                    double cubo = Math.Pow(num, 3);
                    double raizQuadrada = Math.Sqrt(num);

                    Console.WriteLine("Número: " + num);
                    Console.WriteLine("Quadrado: " + quadrado);
                    Console.WriteLine("Cubo: " + cubo);
                    Console.WriteLine("Raiz Quadrada: " + raizQuadrada);
                    Console.WriteLine();
                }
            } while (num > 0);
        }
    }

}