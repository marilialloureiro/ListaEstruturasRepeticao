namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
//10) Escreva um programa que pergunte ao usuário quantos alunos tem na sala dele.
//Em seguida, através de um laço, pede ao usuário para que entre com as notas de todos os alunos
//da sala, um por vez. Por fim, o programa deve mostrar a média, aritmética, da turma.

            int qtde;
            float nota, somaNotas =0, media;

            Console.WriteLine("Qual a quantidade de alunos da sua sala?");
            qtde = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= qtde; i++)
            {
                Console.Write("Digite a nota do aluno " + i + ": ");
                nota = Convert.ToSingle(Console.ReadLine());
                somaNotas += nota;
            }

             media = somaNotas / qtde;
            Console.WriteLine("A média da turma é " + media);
        }
    }
}