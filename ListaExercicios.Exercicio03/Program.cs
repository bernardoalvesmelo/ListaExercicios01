namespace ListaExercicios.Exercicio03
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Cálculo do volume de um cilindro");

            Console.Write("Digite o raio da base do cilindro (em metros): ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do cilindro (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            Console.WriteLine("O volume é aproximadamente " + Math.Round(volume, 2) + " m³.");
            Console.ReadLine();

        }

    }
}