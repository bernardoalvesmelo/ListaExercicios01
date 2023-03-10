namespace ListaExercicios01.Exercicio21
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Soma ou multiplicação condicional de A e B");
            Console.WriteLine("Digite um número inteiro para A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite um número inteiro para B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((a == b ? "A soma dos dois números é " + (a + b) : "O produto dos dois números é " + (a * b)));
            Console.ReadLine();
        }

    }
}