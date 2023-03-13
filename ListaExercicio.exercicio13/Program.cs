namespace ListaExercicio.exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de pães foram vendidos hoje: ");
            int  paes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de broas vendidas hoje: ");
            int broas = int.Parse(Console.ReadLine());

            double faturamento = (paes * 0.12) + (broas * 1.50);

            Console.WriteLine("O Faturamento diário da padaria Hotpão é de: R$" + faturamento);
        }
    }
}