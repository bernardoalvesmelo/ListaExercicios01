namespace ListaExercicios01.Exercicio28
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Números entre 1 e 100");
            int minimo = 1;
            int maximo = 100;
            for (int numero = minimo; numero <= maximo; numero++)
            {
                string saida = "";
                if (numero % 3 == 0)
                {
                    saida = "Fizz";
                }

                if (numero % 5 == 0)
                {
                    saida += "Buzz";
                }

                if (saida == "")
                {
                    saida += numero;
                }

                Console.WriteLine(saida);
            }

            Console.ReadLine();
        }

    }
}