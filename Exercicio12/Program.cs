namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12) Escreva um programa que escreva na tela, de 1 até 100, de 1 em 1, 3 vezes.
            //A primeira vez deve usar a estrutura de repetição for, a segunda while, e a terceira do while


            //PRIMEIRO MODELO - FOR
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.Write( i + " ");
            //}

            //SEGUNDO MODELO - WHILE
            //int num = 1;

            //while (num <= 100) {

            //    Console.Write( num + " ");
            //    num++;

            //TERCEIRO MODELO - DO WHILE
            int num = 1;

            do
            {
                Console.Write(num++ + " ");

            } while (num <= 100);

        }
    }
}