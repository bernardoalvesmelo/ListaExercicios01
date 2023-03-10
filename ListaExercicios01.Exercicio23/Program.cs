namespace ListaExercicios01.Exercicio23
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Números inteiros ímpares entre 100 e 200");
            int minimo = 100;
            int maximo = 200;
            for (int numero = minimo; numero <= maximo; numero++)
            {
                if (numero % 2 != 0)
                {
                    Console.WriteLine(numero);
                }
            }

            Console.ReadLine();
        }

    }
}