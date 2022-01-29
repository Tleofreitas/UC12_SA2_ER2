// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Thiago";

Console.WriteLine("Nome: " + novaPf.nome);
Console.WriteLine($"Nome: {novaPf.nome}"); //atalho "cwl"
