// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using Cadastro_Pessoa.Classes;

Console.WriteLine(@$"
=========================================
|   Bem vindo ao sistema de cadastro de |
|       Pessoas Físicas e Jurídicas     |
=========================================
");

BarraCarregamento("Carregando ", 500);

List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

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

            string opcaoPf;    
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
            ======================================
            |   Escolha uma das opções abaixo:  |
            |-----------------------------------|
            |   1 - Cadastrar Pessoa Física     |
            |   2 - Mostrar Pessoas Físicas     |
            |                                   |
            |   0 - Voltar ao Menu anterior     |
            ======================================
            ");

            opcaoPf = Console.ReadLine();

                switch (opcaoPf){
                case "1":
                    PessoaFisica novaPf = new PessoaFisica();
                    Endereco novoEnd = new Endereco();

                    Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");
                    novaPf.nome = Console.ReadLine();
                    // Console.WriteLine($"Nome: {novaPf.nome}");

                    bool ValidarDataNascimento;
                    do
                    {
                        Console.WriteLine($"Digite a data de nascimento Ex:DD/MM/AAAA");
                        string dataNascimento = Console.ReadLine();

                        ValidarDataNascimento = metodoPf.ValidarDataNascimento(dataNascimento);
                        if (ValidarDataNascimento)
                        {
                            novaPf.dataNascimento = dataNascimento;                        
                        } else {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Por favor digitar uma data válida! Ex:DD/MM/AAAA");
                            Console.ResetColor();
                        }   

                    } while (ValidarDataNascimento == false);                

                    //novaPf.dataNascimento = console.ReadLine();

                    Console.WriteLine($"Digite o número do CPF");
                    novaPf.cpf = Console.ReadLine();

                    Console.WriteLine($"Digite o rendimento mensal (digite somente numeros)");
                    novaPf.rendimento = float.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite seu CEP");
                    novoEnd.Cep = Console.ReadLine();

                    Console.WriteLine($"Digite o número do local");
                    novoEnd.Numero = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite complemento (Aperte ENTER para vazio)");
                    novoEnd.Complemento = Console.ReadLine();

                    Console.WriteLine($"Este endereço é comercial S/N?");
                    string endCom = Console.ReadLine().ToUpper();

                    if (endCom == "S"){
                        novoEnd.endComercial = true;
                    } else {
                        novoEnd.endComercial = false;
                    }

                    novaPf.endereco = novoEnd;

                    listaPf.Add(novaPf);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Cadastro realizado com sucesso");
                    Thread.Sleep(3000);
                    Console.ResetColor();

                    break;

                case "2":
                    Console.Clear();

                    if (listaPf.Count > 0)
                    {
                        foreach (PessoaFisica cadaPessoa in listaPf)
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
                                Nome: {cadaPessoa.nome}
                                Endereço: {cadaPessoa.endereco.Cep}, {cadaPessoa.endereco.Numero}, {cadaPessoa.endereco.Complemento}
                                Data de Nascimento: {cadaPessoa.dataNascimento}
                                A Taxa de imposto a ser paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("c")}
                                ");

                            Console.WriteLine($"Aperte enter para continuar...");
                            Console.ReadLine();        
                        }
                        
                    } else {
                        Console.WriteLine($"Lista vazia!!");
                        Thread.Sleep(3000);
                    }

                    break;

                case "0":
                    break;
                
                default:
                    Console.Clear();
                    Console.WriteLine($"Opção Inválida! Digite outra opção");
                    Thread.Sleep(2000);
                    break;
                }
            } while (opcaoPf !="0");

            break;
        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();

            string opcaoPj;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
            ======================================
            |   Escolha uma das opções abaixo:  |
            |-----------------------------------|
            |   1 - Cadastrar Pessoa Jurídica   |
            |   2 - Mostrar Pessoas Jurídicas   |
            |                                   |
            |   0 - Voltar ao Menu anterior     |
            ======================================
            ");

            opcaoPj = Console.ReadLine();

                switch (opcaoPj){
                    case "1":
                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa Jurídica que deseja cadastrar");
                        novaPj.nome = Console.ReadLine();

                        bool ValidarCnpj;

                        do
                        {
                            Console.WriteLine($"Digite o número do CNPJ");
                            string CNPJ = Console.ReadLine();

                            ValidarCnpj = metodoPj.ValidarCnpj(CNPJ);
                            if (ValidarCnpj) {
                                novaPj.cnpj = CNPJ;
                            } else {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Por favor digitar um CNPJ válid0! Ex: xx.xxx.xxx/0001-xx OU xxxxxxxx0001xx");
                                Console.ResetColor();
                            }

                        } while (ValidarCnpj == false);

                        Console.WriteLine($"Digite a Razão Social");
                        novaPj.razaoSocial = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal (digite somente numeros)");
                        novaPj.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite seu CEP");
                        novoEnd.Cep = Console.ReadLine();

                        Console.WriteLine($"Digite o número da residencia");
                        novoEnd.Numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite complemento (Aperte ENTER para vazio)");
                        novoEnd.Complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial S/N?");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S"){
                        novoEnd.endComercial = true;
                        } else {
                            novoEnd.endComercial = false;
                        }

                        novaPj.endereco = novoEnd;

                        listaPj.Add(novaPj);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Thread.Sleep(3000);
                        Console.ResetColor();

                        break;

                    case "2":
                        Console.Clear();

                        if (listaPj.Count > 0)
                        {
                            foreach (PessoaJuridica cadaPessoa in listaPj)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
                                    Nome: {cadaPessoa.nome}
                                    Razão Social: {cadaPessoa.razaoSocial};
                                    CNPJ: {cadaPessoa.cnpj}
                                    CNPJ Válido: {(metodoPj.ValidarCnpj(cadaPessoa.cnpj) ? "Sim" : "Não" )}
                                    A Taxa de imposto a ser paga é: {metodoPj.PagarImposto(cadaPessoa.rendimento).ToString("c")}
                                    ");
                                
                                Console.WriteLine($"Aperte enter para continuar...");
                                Console.ReadLine();
                            }
                        }
                        else {
                            Console.WriteLine($"Lista vazia!!");
                            Thread.Sleep(3000);                            
                        }

                        break;
                }
                
            } while (opcaoPj !="0");

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