namespace ListaExercicios01.Exercicio22
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Soma ou multiplicação condicional de A e B para C");
            Console.WriteLine("Digite um número inteiro para A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite um número inteiro para B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = a == b ? a + b : a * b;
            Console.WriteLine("O valor de C é " + c);
            Console.ReadLine();
        }

    }
}