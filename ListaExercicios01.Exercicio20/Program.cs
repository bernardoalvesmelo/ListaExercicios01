namespace ListaExercicios01.Exercicio20
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Verificação de números pares e ímpares");
            Console.WriteLine("Digite um número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("O número é " + (numero % 2 == 0 ? "par." : "ímpar."));
            Console.ReadLine();
        }

    }
}