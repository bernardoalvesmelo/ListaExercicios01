namespace ListaExercicios01.Exercicio26
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Fatorial de um número selecionado");
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int fatorial = 1;
            for (int i = 2; i <= numero; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine("O fatorial do número é " + fatorial);
            Console.ReadLine();
        }

    }
}