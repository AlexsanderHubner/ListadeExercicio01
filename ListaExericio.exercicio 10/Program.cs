using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExericio.exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prova1, prova2, mediaPonderada;
            Console.WriteLine("Digite a nota da primeira prova");
            prova1 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a nota da segunda prova");
            prova2 = double.Parse(Console.ReadLine());

            mediaPonderada = ((prova1 * 2) + (prova2 * 3)) / 5;

            Console.WriteLine("A media ponderada do aluno é :" + mediaPonderada);
            Console.ReadKey();

        }
    }
}
