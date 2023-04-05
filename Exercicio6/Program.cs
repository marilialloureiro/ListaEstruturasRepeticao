using static System.Net.Mime.MediaTypeNames;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6) Solicitar a idade de várias pessoas e imprimir:
            //Total de pessoas com menos de 21 anos.
            //Total de pessoas com mais de 50 anos.
            //O programa termina quando idade for = -99.

            int idade, totalMenor21 = 0, totalMaior50 =0;

            do
            {
                Console.Write("Digite a idade (digite 99 para sair): ");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade == 99)
                {
                    break;
                }
                if (idade < 21 )
                {
                    totalMenor21++;
                }

                if (idade > 50)
                {
                    totalMaior50++;
                }
            } while (idade != 99);

            Console.WriteLine("Total de pessoas com menos de 21 anos: " + totalMenor21);
            Console.WriteLine("Total de pessoas com mais de 50 anos: " + totalMaior50);
        }
    }
}