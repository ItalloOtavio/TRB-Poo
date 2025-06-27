namespace Poo_Project;

class Program
{
    static void Main(string[] args)
    {
        Pessoa[] listaPessoas = new Pessoa[10];
        Validacao validador = new Validacao();

        Console.WriteLine("Cadastro de 10 Pessoas:");

        int contador = 0;
        while (contador < 10)
        {
            Console.WriteLine("Pessoa " + (contador + 1) + ":");

            string nomePessoa = "";
            bool nomeValido = false;
            while (nomeValido == false)
            {
                Console.Write("Digite o nome completo: ");
                nomePessoa = Console.ReadLine()!;
                nomeValido = validador.ValidarNome(nomePessoa);

                if (nomeValido == false)
                {
                    Console.WriteLine("Nome inválido! Deve conter nome e sobrenome com pelo menos 2 caracteres cada.");
                }
            }

            string emailPessoa = "";
            bool emailValido = false;
            while (emailValido == false)
            {
                Console.Write("Digite o e-mail: ");
                emailPessoa = Console.ReadLine()!;
                emailValido = validador.ValidarEmail(emailPessoa);

                if (emailValido == false)
                {
                    Console.WriteLine("E-mail inválido! Deve conter '@' e pelo menos 3 caracteres antes e depois.");
                }
            }

            int idadePessoa = -1;
            bool idadeValida = false;
            while (idadeValida == false)
            {
                Console.Write("Digite a idade: ");
                string entrada = Console.ReadLine()!;

                try
                {
                    idadePessoa = Convert.ToInt32(entrada);
                    idadeValida = validador.ValidarIdade(idadePessoa);
                }
                catch
                {
                    idadeValida = false;
                }

                if (idadeValida == false)
                {
                    Console.WriteLine("Idade inválida! Deve ser um número entre 0 e 150.");
                }
            }

            Pessoa novaPessoa = new Pessoa(nomePessoa, emailPessoa, idadePessoa);
            listaPessoas[contador] = novaPessoa;

            contador = contador + 1;
            Console.WriteLine();
        }

        Pessoa pessoaMaisNova = listaPessoas[0];
        Pessoa pessoaMaisVelha = listaPessoas[0];

        int i = 1;
        while (i < listaPessoas.Length)
        {
            if (listaPessoas[i].idade < pessoaMaisNova.idade)
            {
                pessoaMaisNova = listaPessoas[i];
            }

            if (listaPessoas[i].idade > pessoaMaisVelha.idade)
            {
                pessoaMaisVelha = listaPessoas[i];
            }

            i = i + 1;
        }

        Console.WriteLine("Pessoa Mais Nova:");
        Console.WriteLine("Nome: " + pessoaMaisNova.nome + " | Email: " + pessoaMaisNova.email + " | Idade: " + pessoaMaisNova.idade + "\n");

        Console.WriteLine("Pessoa Mais Velha:");
        Console.WriteLine("Nome: " + pessoaMaisVelha.nome + " | Email: " + pessoaMaisVelha.email + " | Idade: " + pessoaMaisVelha.idade + "\n");

        string nomeArquivo = "relatorio_pessoas.txt";
        StreamWriter gravador = new StreamWriter(nomeArquivo);

        gravador.WriteLine("RELATÓRIO DE PESSOAS CADASTRADAS\n");

        int j = 0;
        while (j < listaPessoas.Length)
        {
            gravador.WriteLine("Pessoa " + (j + 1) + ":");
            gravador.WriteLine("Nome: " + listaPessoas[j].nome);
            gravador.WriteLine("Email: " + listaPessoas[j].email);
            gravador.WriteLine("Idade: " + listaPessoas[j].idade);
            j = j + 1;
        }

        gravador.WriteLine();
        gravador.WriteLine("Pessoa mais nova: " + pessoaMaisNova.nome + " - Idade: " + pessoaMaisNova.idade);
        gravador.WriteLine("Pessoa mais velha: " + pessoaMaisVelha.nome + " - Idade: " + pessoaMaisVelha.idade);

        gravador.Close();

        Console.WriteLine("Relatório gerado com sucesso");
    }
}
