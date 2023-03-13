namespace ListadeExercicio.exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBase, totalVendas, comissao, salarioTotal;
            Console.WriteLine("Digite o salário base do vendedor");
            
            salarioBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas do vendedor");

            totalVendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a comissão do vendedor");

            comissao = double.Parse(Console.ReadLine());

            salarioTotal = salarioBase + totalVendas * comissao;

            Console.WriteLine("O salario total do vendedor é: R$"+ salarioTotal);

        }
    }
}