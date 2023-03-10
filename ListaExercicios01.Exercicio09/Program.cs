namespace ListaExercicios01.Exercicio09
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Cálculo da média harmònica das notas de um aluno");
            Console.Write("Digite o número de notas do aluno: ");

            double[] notas = new double[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Digite a " + (i + 1) + " nota do aluno: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                if (notas[i] == 0)
                {
                    Console.WriteLine("Não é possível calcular a média harmônica com 0");
                    i--;
                }
            }

            double inversoElementos = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                inversoElementos += 1 / notas[i];
            }
            double mediaHarmonica = notas.Length / inversoElementos;


            Console.WriteLine("A média harmônica do aluno é " + Math.Round(mediaHarmonica, 2));
            Console.ReadLine();
        }

    }
}