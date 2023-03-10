namespace ListaExercicios01.Exercicio29
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Tabuada de números de 1 até 10");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Tabuada do " + i);
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine(j + " X " + i + " = " + (j * i));
                }

                Console.WriteLine("<----------->");
            }

            Console.ReadLine();
        }

    }
}