using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome completo: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
        DateTime dataNascimento;
        bool dataValida = DateTime.TryParse(Console.ReadLine(), out dataNascimento);

        if (!dataValida)
        {
            Console.WriteLine("Data de nascimento inválida. Tente novamente.");
            return;
        }

        DateTime dataAtual = DateTime.Now;
        
        int idade = dataAtual.Year - dataNascimento.Year;

        if (dataAtual < dataNascimento.AddYears(idade))
        {
            idade--;
        }

        Console.WriteLine($"{nome}, {idade} anos.");
    }
}

