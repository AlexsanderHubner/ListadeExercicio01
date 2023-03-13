namespace ListadeExercicio.exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int b = int.Parse(Console.ReadLine());

            int resultado;

            if (a == b)
            {
                resultado = a + b;
            }
            else
            {
                resultado = a * b;
            }

            int c = resultado;
            Console.WriteLine("O valor de C é: " + c);
        }
    }
}