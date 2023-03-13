using System.Runtime.Intrinsics.X86;

namespace ListadeExercicio.exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write("Sequência de Fibonacci até " + n + ": ");

            while (a <= n)
            {
                Console.Write(a + " ");

                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}