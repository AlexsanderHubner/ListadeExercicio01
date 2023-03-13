namespace ListadeExercicio.exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kmInicial, kmFinal, consumo, consumoKm;
            Console.WriteLine("Digite KM inicial do percurso");
            kmInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("KM final do percuso");
            kmFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o consumo da gasolina em litros");
            consumo = double.Parse(Console.ReadLine());

            consumoKm =  (kmFinal - kmInicial) / consumo;
            Console.WriteLine("O consumo de gasolina por km foi de :"+ consumoKm);

            Console.ReadKey();

        }
    }
}