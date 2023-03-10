namespace ListaExercicios01.Exercicio12
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Cálculo da área de um terreno retangular");
            Console.Write("Digite a altura (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a largura (em metros): ");
            double largura = Convert.ToDouble(Console.ReadLine());
            double area = altura * largura;
            Console.WriteLine("A área do terreno é aproximadamente  " + Math.Round(area, 2) + " m².");
            Console.ReadLine();
        }

    }
}