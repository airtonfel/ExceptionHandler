using System;

namespace ExceptionHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int idade;
                Console.WriteLine("Digite a sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("A sua idade é: " + idade);
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: O valor informado não é numérico. " + erro);
                throw;
            }
        }
    }
}
