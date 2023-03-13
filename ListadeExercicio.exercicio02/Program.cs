namespace ListadeExercicio.exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;

            Console.Write("Digite a temperatura em graus Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("{0} graus Fahrenheit é equivalente a {1} graus Celsius.", fahrenheit, celsius);

            Console.ReadKey();
        }
    }
}