namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
//15) Um funcionário recebe aumento anual.Em 2005 foi contratado por 2000 reais.
//Em 2006 recebeu aumento de 1.5 %.A partir de 2007, os aumentos sempre correspondem ao dobro do
//ano anterior. Faça programa que determine o salário atual do funcionário.

            double salario = 2000;
            double aumento = 0.015; // 1.5% de aumento em 2006

            for (int ano = 2006; ano <= 2023; ano++)
            {
                double aumentoValor = salario * aumento;
                salario += aumentoValor;
                aumento *= 2;

                Console.WriteLine($"{ano}> Salario R$:{salario}, com taxa de aumento de {aumento}%, sendo R${aumentoValor} de aumento");

            }

            Console.WriteLine($"O salário atual do funcionário é de R${salario:F2}");
        }
    }
}