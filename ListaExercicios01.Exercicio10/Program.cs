namespace ListaExercicios01.Exercicio10
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Cálculo da média ponderada das notas de 2 provas de um aluno");

            while (true)
            {
                Console.Write("Digite a nota da primeira prova: ");
                double nota1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o peso da primeira prova: ");
                int peso1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a nota da segunda prova: ");
                double nota2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o peso da segunda prova: ");
                int peso2 = Convert.ToInt32(Console.ReadLine());

                if (peso1 + peso2 == 0)
                {
                    Console.WriteLine("Não é possível calcular a média ponderada com peso total de 0");
                    continue;
                }
                double mediaPonderada = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);
                Console.WriteLine("A média ponderada é " + Math.Round(mediaPonderada, 2));
                Console.ReadLine();
                break;
            }
        }

    }
}