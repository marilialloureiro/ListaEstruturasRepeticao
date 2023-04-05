using Microsoft.VisualBasic;
using System;

namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
//14) Faça um algoritmo que converta uma velocidade expressa em km/ h para m/s e vice versa.
//Você deve criar um menu com as duas opções de conversão e com uma opção para finalizar o
//programa. O usuário poderá fazer quantas conversões desejar, sendo que o programa será finalizado
//quando a opção de finalizar for escolhida

            char opcao;
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Informe a opção de conversão desejada");
                Console.WriteLine("A - Converter de KM/h para M/s: ");
                Console.WriteLine("B - Converter de M/s para KM/h: ");
                Console.WriteLine("C - FINALIZAR");
                opcao = Convert.ToChar(Console.ReadLine());

                switch (opcao)
                {
                    case 'A':
                        Console.Write("Digite a velocidade em km/h: ");
                        double kmh = Convert.ToDouble(Console.ReadLine());
                        double ms = kmh / 3.6;
                        Console.WriteLine("{0} km/h é equivalente a {1} m/s", kmh, ms);
                        break;

                    case 'B':
                        Console.Write("Digite a velocidade em m/s: ");
                        double ms2 = double.Parse(Console.ReadLine());
                        double kmh2 = ms2 * 3.6;
                        Console.WriteLine("{0} m/s é equivalente a {1} km/h", ms2, kmh2);
                        break;

                    case 'C':
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}


          
