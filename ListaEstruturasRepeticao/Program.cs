namespace ListaEstruturasRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {

//1) Faça um programa que leia vários inteiros positivos e mostre, no final, a soma dos números
//pares e a soma dos números ímpares. O programa para quando entrar um número maior que 1000.

            int num = 0;
            int somaPares = 0;
            int somaImpares = 0;

            do
            {
                Console.Write("Entre com um número inteiro e positivo para somar \n" +
                    "(o programa para quando o número for >1000 - não computando na soma): ");
                
                num = Convert.ToInt32((Console.ReadLine()));


                if (num > 1000)
                    break;

                if (num % 2 == 0)
                {
                    somaPares += num;
                }
                else
                {
                    somaImpares += num;
                }
            }while (num <=1000);
                Console.WriteLine("Soma dos números pares: " + somaPares);
                Console.WriteLine("Soma dos números impares: " + somaImpares);
            }
    }
}