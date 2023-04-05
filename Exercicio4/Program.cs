namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Faça um programa para exibir a tabuada de 0 a 9.

            int num1, resultado;

            Console.WriteLine("Informe qual tabuada do 0 ao 9 gostaria de verificiar:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A tubuada do " + num1 + " será apresentada abaixo: ");
            Console.WriteLine();
           

            for (int num2 = 0; num2 <= 10; num2++)
            {
                
                resultado = num1 * num2;
                Console.WriteLine(num1 + " x " + num2 + " = " + resultado);
            }

            Console.WriteLine();
        }
    }
}