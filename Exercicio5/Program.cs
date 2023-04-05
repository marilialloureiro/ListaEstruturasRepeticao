//5) Escreva um programa que lê 15 valores reais, encontra o maior e o menor deles e
//mostra o resultados.

int maior = Int32.MinValue;
int menor = Int32.MaxValue;
int numEntrada;

for (int i = 0; i < 15; i++)
{
    Console.Write("Digite o " + (i + 1) + "º número: ");
    numEntrada = Convert.ToInt32(Console.ReadLine());

    if (numEntrada > maior)
        maior = numEntrada;

    if (numEntrada < menor)
        menor = numEntrada;

}
Console.WriteLine();
Console.WriteLine("O maior valor digitado foi: " + maior);
Console.WriteLine("O menor valor digitado foi: " + menor);

