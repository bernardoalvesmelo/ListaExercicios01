namespace ListaExercicios13.Exercicio13
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Cálculo de venda de pãezinhos e broas");
            Console.Write("Digite o número de pães vendidos: ");
            int paezinhos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número de pãezinhos vendidos: ");
            int broas = Convert.ToInt32(Console.ReadLine());

            double vendas = (paezinhos * 0.12) + (broas * 1.5);
            Console.WriteLine("O total arrecadado no dia foi  R$" + Math.Round(vendas, 2));
            Console.WriteLine("Deve guardar na poupança  R$" + Math.Round(vendas * 0.1, 2));
            Console.ReadLine();
        }

    }
}