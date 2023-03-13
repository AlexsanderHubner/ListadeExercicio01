namespace ListadeExercicio.exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, MediaHarmonica;

            Console.WriteLine("Digite a primeira nota do aluno:");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota do aluno");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a teceira nota do aluno");
            nota3 = double.Parse(Console.ReadLine());

            MediaHarmonica = 3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));
            Console.WriteLine("A nota harmonica do aluno é:  " + MediaHarmonica);

            Console.ReadKey();

        }
    }
}