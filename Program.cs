using System;

public  class Usuario
{
   public string Nome { get; set; }
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

            break; // idade válida

        }
            Usuario usuario = new Usuario
            {
                Nome = nome,
                Email = email,
                Idade = idade
            };

               Console.WriteLine("Usuário cadastrado com sucesso!");





    }
}
