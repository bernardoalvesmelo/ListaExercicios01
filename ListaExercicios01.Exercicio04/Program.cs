namespace ListaExercicios01.Exercicio04
{
    internal class Program
    {
        public static void Main()
        {
            do
            {
                Console.WriteLine("Cálculo do consumo de combustível por Km");

                Console.Write("Digite a quilometragem inical do veículo: ");
                double kmInicial = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quilometragem final do veículo: ");
                double kmFinal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade consumida de combustível (em litros): ");
                double combustivel = Convert.ToDouble(Console.ReadLine());

                if (kmFinal - kmInicial == 0)
                {
                    Console.WriteLine("Quilometragem final - quilometragem inicial é igual a zero!");
                    continue;
                }

                double consumo = combustivel / (kmFinal - kmInicial);
                Console.WriteLine("O veículo está consumindo " + consumo + " L por Km.");
                Console.ReadLine();
                break;
            }
            while (true);

        }

    }
}