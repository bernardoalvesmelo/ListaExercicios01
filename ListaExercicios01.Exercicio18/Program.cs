namespace ListaExercicios01.Exercicio18
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Ordenação decrescente de três números inteiros");
            Console.WriteLine("Digite o valor do primeiro número inteiro: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo número inteiro: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do terceiro número inteiro: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());
            if (numero1 < numero2)
            {
                int teste1 = numero1;
                numero1 = numero2;
                numero2 = teste1;
            }

            if (numero2 < numero3)
            {
                int teste2 = numero2;
                numero2 = numero3;
                numero3 = teste2;
                if (numero1 < numero2)
                {
                    int teste3 = numero1;
                    numero1 = numero2;
                    numero2 = teste3;
                }
            }

            int[] numerosDecrescentes = { numero1, numero2, numero3 };
            Console.WriteLine("Os números em ordem decrescente são " + string.Join(", ", numerosDecrescentes));
            Console.ReadLine();
        }


    }
}