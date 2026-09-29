

using ConceitosC_;
using System;
using System.Threading;

DateTime datahoje = DateTime.Today;
Proprietario novoProprietario;


novoProprietario = new Proprietario();
Imovel novoImovel = new Imovel();

// Relacionando o imóvel ao proprietário
novoImovel.proprietario = novoProprietario;

Console.WriteLine("=========== CADASTRO PROPRIETÁRIO DO IMÓVEL ===========");
Console.WriteLine();

Console.WriteLine("Entre com os dados do Proprietário: Nome, Data de Nascimento, CPF e Endereço: ");

Console.WriteLine("Digite o nome completo: ");
novoProprietario.nomeCompleto = Console.ReadLine();

Console.WriteLine("Digite a Data Nascimento: ");
novoProprietario.nascimento = Console.ReadLine();

Console.WriteLine("Digite o CPF: ");
novoProprietario.cpf = Console.ReadLine();

Console.WriteLine("Digite o Endereço: ");
novoProprietario.endereco = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Digite o Bairro: ");
novoProprietario.bairro = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Digite a Cidade: ");

novoProprietario.cidade = Console.ReadLine();
Console.WriteLine();


Console.WriteLine("=========== CADASTRO DO IMÓVEL ===========");
Console.WriteLine();

Console.WriteLine("Entre com os dados do Imóvel: ");
Console.WriteLine();

Console.WriteLine("Digite a Matrícula: ");
novoImovel.matricula = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Digite o SQL: ");
novoImovel.sql = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Digite a Área do Imóvel: ");
novoImovel.areaImovel = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Digite a quantidade de Cômodos: ");
novoImovel.comodos = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Digite a Descrição: ");
novoImovel.descricao = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Realizando Cadastro...");
Console.WriteLine();

novoProprietario.exibirMensagem();
Console.WriteLine();

// Formata os Dados
novoProprietario.formatDados();

Console.WriteLine("=========== DADOS PROPRIETÁRIO DO IMÓVEL ===========");
Console.WriteLine();
Console.WriteLine($"NOME: {novoProprietario.nomeCompleto}");
Console.WriteLine($"DATA NASCIMENTO: {novoProprietario.nascimento}");
Console.WriteLine($"CPF: {novoProprietario.cpf}");
Console.WriteLine($"ENDEREÇO: {novoProprietario.endereco}");
Console.WriteLine($"BAIRRO: {novoProprietario.bairro}");
Console.WriteLine($"CIDADE: {novoProprietario.cidade}");
Console.WriteLine();
Console.WriteLine($"DATA CADASTRO: {datahoje:dd/MM/yyyy}");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("=========== DADOS DO IMÓVEL ===========");
Console.WriteLine();

Console.WriteLine($"Proprietário: {novoImovel.proprietario.nomeCompleto}");
Console.WriteLine($"Matrícula: {novoImovel.matricula}");
Console.WriteLine($"SQL: {novoImovel.sql}");
Console.WriteLine($"Área: {novoImovel.areaImovel}");
Console.WriteLine($"Cômodos: {novoImovel.comodos}");
Console.WriteLine($"Descrição: {novoImovel.descricao}");


Console.WriteLine();
Console.WriteLine("========== Cadastro realizado pela empresa [ IMOBDATA ] ==========");
Console.WriteLine();


