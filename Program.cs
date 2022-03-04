// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa.Classes;

Console.WriteLine(@$"
=========================================
|   Bem vindo ao sistema de cadastro de |
|       Pessoas Físicas e Jurídicas     |
=========================================
");

BarraCarregamento("Carregando ", 500);

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
======================================
|   Escolha uma das opções abaixo:  |
|-----------------------------------|
|   1 - Pessoa Física               |
|   2 - Pessoa Jurídica             |
|                                   |
|   0 - Sair                        |
======================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica metodoPf = new PessoaFisica();

            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();

            novaPf.nome = "Thiago";
            // Console.WriteLine($"Nome: {novaPf.nome}");
            novaPf.dataNascimento = "01/01/2000";
            novaPf.cpf = "1234567890";
            novaPf.rendimento = 15000.5f;

            novoEnd.Cep = "09170-115";
            novoEnd.Numero = 271;
            novoEnd.Complemento = "Casa";
            novoEnd.endComercial = true;

            novaPf.endereco = novoEnd;

            Console.Clear();
            Console.WriteLine(@$"
                Nome: {novaPf.nome}
                Endereço: {novaPf.endereco.Cep}, {novaPf.endereco.Numero}, {novaPf.endereco.Complemento}
                Maior de idade: {(metodoPf.ValidarDataNascimento(novaPf.dataNascimento) ? "Sim" : "Não" )}
                A Taxa de imposto a ser paga é: {metodoPf.PagarImposto(novaPf.rendimento).ToString("c")}
                ");

            Console.WriteLine($"Aperte enter para continuar...");
            Console.ReadLine();
            break;
        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Nome Pj";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.razaoSocial = "Razão Social Pj";
            novaPj.rendimento = 8000.5f;

            novoEndPj.Cep = "09170-115";
            novoEndPj.Numero = 271;
            novoEndPj.Complemento = "Casa";
            novoEndPj.endComercial = true;

            novaPj.endereco = novoEndPj;

            Console.Clear();
            Console.WriteLine(@$"
                Nome: {novaPj.nome}
                Razão Social: {novaPj.razaoSocial};
                CNPJ: {novaPj.cnpj}
                CNPJ Válido: {(metodoPj.ValidarCnpj(novaPj.cnpj) ? "Sim" : "Não" )}
                A Taxa de imposto a ser paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("c")}
                ");

            Console.WriteLine($"Aperte enter para continuar...");
            Console.ReadLine();
            break;
        case "0":

            Console.WriteLine($"Obrigado por usar o Sistema.");

            BarraCarregamento("Finalizando ", 300);
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Opção Inválida! Digite outra opção");
            Thread.Sleep(2000);
            break;
    }
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write($"{texto}");

    for (var contador = 0; contador < 10; contador++)
    {
        Console.Write(". ");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}

// Console.WriteLine($"{metodoPj.ValidarCnpj("00000000000100")}");