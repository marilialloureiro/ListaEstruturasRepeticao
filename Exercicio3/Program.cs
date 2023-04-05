using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Faça um programa que calcula o produto dos números digitados pelo usuário.
            //O programa deve permitir que o usuário digite uma quantidade não determinada de
            //números. O programa encerra quando o usuário digita o valor zero.

            int num = 0;
            int Produto = 1;

            do
            {
                Console.Write("Entre com um número inteiro e positivo: ");
                num = Convert.ToInt32((Console.ReadLine()));

                if (num == 0)
                    break;

                Produto *= num;

            } while (num != 0);
            Console.WriteLine("Soma dos números é: " + Produto);

        }
    }
}