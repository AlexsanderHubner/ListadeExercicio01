namespace ListadeExercicio.exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int C = int.Parse(Console.ReadLine());
          
            if (A + B < C)
            {
                Console.WriteLine("A soma de A + B é menor que C.");
            }
            else
            {
                Console.WriteLine("A soma de A + B não é menor que C.");
            }
    }

    }
}