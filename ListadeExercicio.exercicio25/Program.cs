namespace ListadeExercicio.exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número de 1 a 10: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada de " + n + ":");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + n + " = " + (i * n));
            }
        }
    }
}