namespace ListadeExercicio.exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, volume;
            Console.WriteLine("Digite o raio da esfera");
            raio = double.Parse(Console.ReadLine());

            volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
            Console.WriteLine("O volume da esfera é: " + volume);
            Console.ReadKey();
        }
    }
}