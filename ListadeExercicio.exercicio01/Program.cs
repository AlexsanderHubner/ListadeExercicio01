namespace ListadeExercicio.exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double comprimento, largura, altura;
            double resultado;

            Console.WriteLine("Digite o comprimento da caixa");
            comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura da caixa");
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da caixa");
            altura = double.Parse(Console.ReadLine());

            resultado = comprimento * largura * altura;

            Console.WriteLine("O Resultado da caixa é:" + resultado);

        }
    }
}