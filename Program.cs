// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa.Classes;

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

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novaPf.endereco.Cep}, {novaPf.endereco.Numero}, {novaPf.endereco.Complemento}
Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
");

PessoaJuridica metodoPj = new PessoaJuridica();

PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new PessoaJuridica();

novaPj.nome = "Nome Pj";
novaPj.cnpj = "00.000.000/0001-00";
novaPj.razaoSocial = "Razão Social Pj";
novaPj.rendimento = 8000.5f;

novoEnd.Cep = "09170-115";
novoEnd.Numero = 271;
novoEnd.Complemento = "Casa";
novoEnd.endComercial = true;

novaPj.endereco = novoEndPj;

Console.WriteLine($"{metodoPj.ValidarCnpj("00000000000100")}");



