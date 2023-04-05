namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7) Solicitar um número entre 1 e 4. Se a pessoa digitar um número diferente,
            //mostrar a mensagem "entrada inválida" e solicitar o número novamente.
            //Se digitar correto mostrar o número digitado

            int num;

            do
            {
                Console.Write("Digite um número entre 1 e 4: ");
                num = Convert.ToInt32(Console.ReadLine());


                if (num < 1 || num > 4)
                {
                    Console.WriteLine("Entrada inválida - digite novamente");
                }

            }while (num < 1 ||  num > 4);
                Console.WriteLine("Entrada válida");
                Console.WriteLine("O número digitado foi " + num);
            }
        }
    }

