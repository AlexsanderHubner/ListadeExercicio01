namespace ListadeExercicio.exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para calcular seu fatorial: ");
            int a = int.Parse(Console.ReadLine());

            int resultado = 1;
            Console.Write(a + "! = ");

            for (int i = a; i >= 1; i--)
            {
                Console.Write(i);
                resultado *= i;

                if (i != 1)
                {
                    Console.Write(" x ");
                }
            }

            Console.Write(" = " + resultado);
        }
    }
}