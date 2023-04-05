using System;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
////11) Escreva um programa que solicita 10 números ao usuário, através de um laço while,
///e ao final mostre qual destes números é o maior.

            int contador = 1;
            int maior = int.MinValue;

            while (contador <= 10)
            {
                Console.Write("Digite o " + contador + "º número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                }

                contador++;
            }

            Console.WriteLine("O maior número digitado foi " + maior);
        }
    }
}