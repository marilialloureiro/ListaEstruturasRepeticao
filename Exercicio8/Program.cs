namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8) Solicitar um nome e escrevê - lo de trás pra frente.

            string nome;

            Console.WriteLine("Informe o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Nome ao contrário: ");
            for (int i = nome.Length - 1; i >= 0; i--)
            {
                Console.Write(nome[i]);
            }
        }
    }
}