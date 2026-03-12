using System;

public  class Usuario
{
   public string Nome { get; set; }
   public string Cpf { get; set; }
   public string Email { get; set; }
   public int  Idade { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sistema de Cadastro\n");

        Console.WriteLine("Digite o Nome do usuário:");
        string nome = Console.ReadLine();

        string cpf;

        // LOOP PARA VALIDAR CPF
        while (true)
        {
            Console.WriteLine("Digite o CPF do usuário (apenas números):");
            cpf = Console.ReadLine();

            // verifica se tem 11 números e se todos são dígitos
            if (cpf.Length == 11 && long.TryParse(cpf, out _))
            {
                break; // CPF válido
            }

            Console.WriteLine("CPF inválido. O CPF deve conter exatamente 11 números.");
        }

        string email;

        // LOOP PARA VALIDAR EMAIL
        while (true)
        {
            Console.WriteLine("Digite o Email do usuário:");
            email = Console.ReadLine();

            if ((email.Contains("@gmail") || email.Contains("@hotmail")) &&
            (email.Contains(".com") || email.Contains(".br")))
            {
                break; // email válido
            }

            Console.WriteLine("Email inválido, tente novamente.");
        }

        int idade;

        // LOOP PARA VALIDAR IDADE
        while (true)
        {
            Console.WriteLine("Digite a Idade do usuário:");

            // tenta converter para número
            bool converteu = int.TryParse(Console.ReadLine(), out idade);

            if (!converteu)
            {
                Console.WriteLine("Idade inválida (digite apenas números).");
                continue;
            }

            if (idade < 18)
            {
                Console.WriteLine("Usuário menor de idade, cadastro não permitido.");
                continue;
            }

            break; // idade 

        }
            Usuario usuario = new Usuario
            {
                Nome = nome,
                Cpf = cpf,
                Email = email,
                Idade = idade
            };

        Console.WriteLine("Usuário cadastrado com sucesso!");
        Console.WriteLine("\nUsuário cadastrado com sucesso!");
        Console.WriteLine("Nome: " + usuario.Nome);
        Console.WriteLine("CPF: " + usuario.Cpf);
        Console.WriteLine("Email: " + usuario.Email);
        Console.WriteLine("Idade: " + usuario.Idade);





    }
}
