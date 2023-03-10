namespace ListaExercicios01.Exercicio11
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Verificação se um número é primo");
            Console.Write("Digite um número inteiro para verificar se ele é primo: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            bool ehPrimo = true;
            if (numero == 0 || numero == 1)
            {
                ehPrimo = false;
            }

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    ehPrimo = false;
                }
            }

            Console.WriteLine("O número " + (ehPrimo ? "é primo." : "não é primo."));
            Console.ReadLine();
        }

    }
}