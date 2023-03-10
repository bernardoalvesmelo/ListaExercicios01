namespace ListaExercicios01.Exercicio07
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Cálculo do salário total de um vendedor");

            Console.WriteLine("Digite o salário base do vendedor: ");
            decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor do total de vendas do vendedor: ");
            decimal vendas = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o percentual de comissao do vendedor");
            decimal comissao = Convert.ToDecimal(Console.ReadLine());
            decimal salarioTotal = salarioBase + (vendas * comissao / 100);
            Console.WriteLine("O salário total do vendedor é R$" + Math.Round(salarioTotal, 2));
            Console.ReadLine();
        }

    }
}