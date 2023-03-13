namespace ListadeExercicio.exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, volume;

            Console.WriteLine("Digite raio lata de óleo");
            raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da lata de óleo");
            altura = double.Parse(Console.ReadLine());

            volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine("O volume da lata de oléo é : " + volume);
            Console.ReadKey();
        }
    }
}