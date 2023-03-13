namespace ListadeExericio.exericio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite um número inteiro positivo: ");
            numero = int.Parse(Console.ReadLine());

            bool ehPrimo = true;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }

            if (numero == 1)
            {
                Console.WriteLine("1 não é um número primo.");
            }
            else if (ehPrimo)
            {
                double numDouble = (double)numero;
                Console.WriteLine("{0} é um número primo e pode ser convertido para {1}.", numero, numDouble);
            }
            else
            {
                Console.WriteLine("{0} não é um número primo.", numero);
            }

            Console.ReadLine();
        }
    }
}