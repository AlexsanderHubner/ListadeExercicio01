namespace ListadeExerciocio.exerciocio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            Console.WriteLine("Digite a temperatura em Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = celsius * 9.0 / 5.0 + 32.0;

            Console.WriteLine("a temperatura em Fahrenheit é :"+ fahrenheit);
            Console.ReadKey();
        }
    }
}