namespace ListadeExercicio.exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, volume;

            Console.WriteLine("Digite o raio do cilindro: ");
            raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do cilindro");
            altura = double.Parse(Console.ReadLine());

            volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine("O volume do cilindro é " + volume);

            Console.ReadKey();
        }
    }
}