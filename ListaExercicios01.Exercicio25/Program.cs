namespace ListaExercicios01.Exercicio25
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Tabuada de um número selecionado");
            int numero = 0;
            while (true)
            {
                Console.WriteLine("Digite um número entre 1 e 10: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 1 || numero > 10)
                {
                    Console.WriteLine("Digite um número entre 1 e 10!");
                    continue;
                }

                break;
            }

            Console.WriteLine("Tabuada do " + numero);
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " X " + numero + " = " + (numero * i));
            }

            Console.ReadLine();
        }

    }
}