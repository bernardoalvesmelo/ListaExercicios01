namespace ListaExercios01.Exercicio05
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Cálculo do volume de uma esfera");

            Console.Write("Digite o raio da esfera (em metros): ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double volume = 4 * Math.PI * Math.Pow(raio, 3) / 3;
            Console.WriteLine("O volume é aproximadamente " + Math.Round(volume, 2) + " m³.");
            Console.ReadLine();
        }

    }
}