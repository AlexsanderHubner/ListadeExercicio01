namespace ListaExercicio.exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Digite a largura do terreno em metros: ");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento do terreno em metros: ");
            double comprimento = double.Parse(Console.ReadLine());

            double area = largura * comprimento;

            Console.WriteLine("A área do terreno é: " + area + " metros quadrados");
        }
    }
}