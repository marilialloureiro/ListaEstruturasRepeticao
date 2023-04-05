namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Faça um programa que leia um número n e mostre na tela os n primeiros
            //números pares e depois os n primeiros números ímpares.

            int n;
            int numPar = 0;
            int numImpar = 1;

            Console.Write("Entre com um número: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Os números pares são: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(numPar + " ");
                numPar += 2;

            }
            Console.WriteLine();
            Console.WriteLine("Os números impares são: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(numImpar + " ");
                numImpar += 2;
            }
          



        }
    }
}

