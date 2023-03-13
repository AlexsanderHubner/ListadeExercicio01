namespace ListadeExercicio.exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso em kg:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura em metros:");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

            if (imc < 18.5)
            {
                Console.WriteLine("Condição: Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Condição: Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Condição: Acima do peso");
            }
            else
            {
                Console.WriteLine("Condição: Obeso");
            }
        }
    }
}