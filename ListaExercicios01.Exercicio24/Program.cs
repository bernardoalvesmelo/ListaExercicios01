namespace ListaExercicios01.Exercicio24
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Soma de números ímpares múltiplos de três entre 1 e 500.");
            int minimo = 1;
            int maximo = 500;
            int soma = 0;
            for (int numero = minimo; numero <= maximo; numero++)
            {
                if (numero % 2 != 0 && numero % 3 == 0)
                {
                    soma += numero;
                }
            }
            Console.WriteLine("O resultado da soma é " + soma);
            Console.ReadLine();
        }


    }
}