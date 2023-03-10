namespace ListaExercicios01.Exercicio14
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Cálculo dos dias de vida de um pessoa");
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nome + " você já viveu " + (idade * 365) + " dias");
            Console.ReadLine();
        }

    }
}