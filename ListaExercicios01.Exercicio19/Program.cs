namespace ListaExercicios.Exercicio19
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Cálculo de IMC");
            Console.WriteLine("Digite o seu peso (em quilos): ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a sua altura (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());
            string condicao = "obeso.";
            double imc = peso / Math.Pow(altura, 2);
            if (imc < 18.5)
            {
                condicao = "abaixo do peso.";
            }
            else if (imc < 25)
            {
                condicao = "peso normal.";
            }
            else if (imc < 30)
            {
                condicao = "acima do peso.";
            }

            Console.WriteLine("Seu imc é " + Math.Round(imc, 2) + " e sua condição é " + condicao);
            Console.ReadLine();
        }

    }
}