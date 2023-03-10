namespace ListaExercicios01.Exercicio08
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Cálculo do volume de uma lata de óleo");

            Console.Write("Digite o raio da base da lata de óleo (em centímetros): ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da lata de óleo (em centímetros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            Console.WriteLine("O volume é aproximadamente " + Math.Round(volume, 2) + " c³.");
            Console.ReadLine();
        }

    }
}