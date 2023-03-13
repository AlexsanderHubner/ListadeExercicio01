using System.Xml;

namespace ListadeExercicio.exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();

            Console.WriteLine("digite a idade da pessoa: ");
            int idade = int.Parse(Console.ReadLine());

            int diasVida = idade * 365;

            Console.WriteLine(nome + "possui " + diasVida + "dias de vida");
        }
    }
}                                                                        