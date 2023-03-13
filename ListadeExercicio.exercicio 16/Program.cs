namespace ListadeExercicio.exercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o salário do funcionario: ");
            double salario = double.Parse(Console.ReadLine());

            double aumentoSalario = salario * 1.15;

            double salarioFinal = aumentoSalario * 0.92;

            Console.WriteLine("Salário inicial: R$" + salario);
            Console.WriteLine("Salário com aumento de 15%: R$"  + aumentoSalario);
            Console.WriteLine("Salário final após desconto de 8 % de imposto: R$" + salarioFinal);

        }
    }
}