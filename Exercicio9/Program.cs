namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9) Escreva um aplicativo mostra todos os números ímpares de 1 até 100.

            int inicio = 1;
            int fim  = 100;

            for (int i = inicio; i <= fim; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}