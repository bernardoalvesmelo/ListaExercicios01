namespace Exercicio02
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Conversão de graus Fahrenheit para Celsius");

            Console.WriteLine("Digite a temperatura (em graus Fahrenheit): ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (fahrenheit - 32) / 1.8;
            Console.WriteLine("A temperatura em graus Celsius é aproximadamente  " + Math.Round(celsius, 2) + " °C.");
            Console.ReadLine();
        }

    }
}