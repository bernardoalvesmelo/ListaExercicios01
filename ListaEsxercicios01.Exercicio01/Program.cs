namespace ListaEsxercicios01.Exercicio01
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Cálculo do volume de uma caixa retangular");

            Console.Write("Digite a altura (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a largura (em metros): ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a profundidade (em metros): ");
            double profundidade = Convert.ToDouble(Console.ReadLine());

            double volume = altura * largura * profundidade;
            Console.WriteLine("O volume é aproximadamente  " + Math.Round(volume, 2) + " m³.");
            Console.ReadLine();

        }

    }
}