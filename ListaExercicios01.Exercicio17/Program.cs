namespace ListaExercicios01.Exercicio17
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Comparação da soma de A e B com C");
            Console.WriteLine("Digite o valor de A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double soma = a + b;
            Console.WriteLine("A soma de A e B é " + soma + (soma < c ? ", e é menor " : ", e não é menor ") + "do que C.");
            Console.ReadLine();
        }

    }
}