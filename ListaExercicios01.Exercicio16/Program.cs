namespace ListaExercicios01.Exercicio16
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Cálculo do salário de um vendedor com aumeto e impostos");
            Console.WriteLine("Digite o salário inicial do vendedor: ");
            double salarioInicial = Convert.ToDouble(Console.ReadLine());
            double salarioAumento = salarioInicial * 1.15;
            double salarioImpostos = salarioAumento * 0.92;
            Console.WriteLine("O salário inicial do vendedor é R$" + Math.Round(salarioInicial, 2));
            Console.WriteLine("O salário com aumento do vendedor é R$" + Math.Round(salarioAumento, 2));
            Console.WriteLine("O salário final do vendedor é R$" + Math.Round(salarioImpostos, 2));
            Console.ReadLine();
        }

    }
}