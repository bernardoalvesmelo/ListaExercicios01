namespace ListaExercicios01.Exercicio27
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Sequência de Fibonacci");
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int[] fibonacci = new int[numero];
            Console.WriteLine("Sequência de Fibonacci até " + numero + " elemento.");
            for (int i = 0; i < numero; i++)
            {
                fibonacci[i] = i <= 1 ? 1 : fibonacci[i - 1] + fibonacci[i - 2];
                Console.WriteLine(fibonacci[i]);
            }

            Console.ReadLine();
        }

    }
}