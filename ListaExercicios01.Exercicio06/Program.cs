namespace ListaExercicios01.Exercicio06
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Conversão de graus Celsius para Fahrenheit");

            Console.WriteLine("Digite a temperatura (em graus Celsius): ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine("A temperatura em graus Fahrenheit é aproximadamente  " + Math.Round(fahrenheit, 2) + " °F.");
            Console.ReadLine();
        }

    }
}