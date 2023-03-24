﻿using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos Arrays em C#
void TestaArray()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 20;
    idades[2] = 12;
    idades[3] = 14;
    idades[4] = 8;

    Console.WriteLine($"O tamanho do array idades é de {idades.Length}");

    double total = 0;

    for (int i = 0; i < idades.Length; i++)
    {

        int idade = idades[i];
        total += idade;
        Console.WriteLine($"O índice {i} contém o valor: {idade}");
    }
    double media = total / idades.Length;

    Console.WriteLine($"A média das idades é igual a: {media}");

}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite a {i + 1}ª Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.WriteLine("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (var palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }

    }
}

Array amostra = Array.CreateInstance(typeof(double), 6);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);
amostra.SetValue(8, 5);

// TestaMediana(amostra);
void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);
    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0)
        ? numerosOrdenados[meio]
        : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
    Console.WriteLine($"Com base na amostra a mediana é: {mediana}");
}


void TestaArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.ExibeLista();
}

//TestaArrayDeContasCorrentes();
#endregion

List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
{
    new ContaCorrente(546)
    {
    Saldo =100, Titular = new Cliente{Cpf="8888",Nome="Henrique",Profissao="BackEnd Dev"}
    },
    new ContaCorrente(521)
    {
    Saldo =100, Titular = new Cliente{Cpf="2222",Nome="André",Profissao="QA"}
    },
    new ContaCorrente(546){
    Saldo =100, Titular = new Cliente{Cpf="3333",Nome="Luciano",Profissao="FrontEnd Dev"}
    }
};

List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
{
    new ContaCorrente(646),
    new ContaCorrente(647),
    new ContaCorrente(648)
};

List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
{
    new ContaCorrente(746),
    new ContaCorrente(747),
    new ContaCorrente(748)
};


// ADDRANGE = faz o merge de 2 listas
_listaDeContas2.AddRange(_listaDeContas3);

for (int i = 0; i < _listaDeContas2.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
}

// GETRANGE = pega um intervalo dentro da lista
var range = _listaDeContas3.GetRange(1, 2);
Console.WriteLine("\n\n");

Console.WriteLine("LISTA 3 do indice 1 ao 2");
for (int i = 0; i < range.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");
}


// REVERSE = inverte a ordem da lista
Console.WriteLine("\n\n");
_listaDeContas2.Reverse();
Console.WriteLine("LISTA 2 invertida");
for (int i = 0; i < _listaDeContas2.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
}
Console.WriteLine("\n\n");
// CLEAR = limpa a lista
_listaDeContas2.Clear();
Console.WriteLine("LISTA 2 PÓS CLEAR");
for (int i = 0; i < _listaDeContas2.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
}

void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===       Atendimento       ===");
            Console.WriteLine("===1 - Cadastrar Conta      ===");
            Console.WriteLine("===2 - Listar Contas        ===");
            Console.WriteLine("===3 - Remover Conta        ===");
            Console.WriteLine("===4 - Ordenar Contas       ===");
            Console.WriteLine("===5 - Pesquisar Conta      ===");
            Console.WriteLine("===6 - Sair do Sistema      ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n\n");
            Console.Write("Digite a opção desejada: ");
            try
            {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception excecao)
            {
                throw new ByteBankException(excecao.Message);
            }
            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                case '3':
                    RemoverContas();
                    break;
                case '4':
                    OrdenarContas();
                    break;
                case '5':
                    PesquisarContas();
                    break;
                default:
                    Console.WriteLine("Opcao não implementada.");
                    break;
            }
        }
    }
    catch (ByteBankException excecao)
    {
        Console.WriteLine($"{excecao.Message}");
    }

}

void PesquisarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===    PESQUISAR CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Deseja pesquisar por (1) NUMERO DA CONTA , (2)CPF TITULAR ou (3)NUMERO DA AGENCIA? ");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            {
                Console.Write("Informe o número da Conta: ");
                string _numeroConta = Console.ReadLine();
                ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                if (consultaConta != null)
                {
                    Console.WriteLine(consultaConta.ToString());

                }
                else
                {
                    Console.WriteLine("Conta não encontrada!");
                }
                Console.ReadKey();
                break;
            }
        case 2:
            {
                Console.Write("Informe o CPF do Titular: ");
                string _cpf = Console.ReadLine();
                ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                if (consultaCpf != null)
                {
                    Console.WriteLine(consultaCpf.ToString());

                }
                else
                {
                    Console.WriteLine("Cpf não encontrado!");
                }
                Console.ReadKey();
                break;
            }
        case 3:
            {
                Console.Write("Informe o Número da Agência: ");
                int _numeroAgencia = int.Parse(Console.ReadLine());
                var contasPorAgencia = ConsultaPorNumeroAgencia(_numeroAgencia);
                ExibirListaDeContas(contasPorAgencia);
                Console.ReadKey();
                break;
            }
        default:
            Console.WriteLine("Opção não implementada.");
            break;
    }

}

void ExibirListaDeContas(List<ContaCorrente> contasPorAgencia)
{
    if (contasPorAgencia == null)
    {
        Console.WriteLine("A consulta não retornou dados");
    }
    else
    {
        foreach (var item in contasPorAgencia)
        {
            Console.WriteLine(item.ToString());
        }
    }
}

List<ContaCorrente> ConsultaPorNumeroAgencia(int? numeroAgencia)
{
    var consulta = (
        from conta in _listaDeContas
        where conta.Numero_agencia == numeroAgencia
        select conta).ToList();
    return consulta;
}

ContaCorrente ConsultaPorCPFTitular(string? cpf)
{
    return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();
}

ContaCorrente ConsultaPorNumeroConta(string numeroConta)
{
    return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();
}

void OrdenarContas()
{
    _listaDeContas.Sort();
    Console.WriteLine("Lista ordenada!");
}

void RemoverContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===      REMOVER CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Informe o número da Conta: ");
    string numeroConta = Console.ReadLine();
    ContaCorrente conta = null;
    foreach (var item in _listaDeContas)
    {
        if (item.Conta.Equals(numeroConta))
        {
            conta = item;
        }
    }
    if (conta != null)
    {
        _listaDeContas.Remove(conta);
        Console.WriteLine("... Conta removida da lista! ...");
    }
    else
    {
        Console.WriteLine(" ... Conta para remoção não encontrada ...");
    }
    Console.ReadKey();
}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");
    Console.Write("Número da conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Infome nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Infome CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Infome Profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);
    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }
    foreach (ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine("Número da Agência : " + item.Numero_agencia);
        Console.WriteLine("Número da Conta : " + item.Conta);
        Console.WriteLine("Saldo da Conta : " + item.Saldo);
        Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    }
    Console.ReadKey();

}


AtendimentoCliente();

List<string> nomesDosEscolhidos = new List<string>()
{
    "Bruce Wayne",
    "Carlos Vilagran",
    "Richard Grayson",
    "Bob Kane",
    "Will Farrel",
    "Lois Lane",
    "General Welling",
    "Perla Letícia",
    "Uxas",
    "Diana Prince",
    "Elisabeth Romanova",
    "Anakin Wayne"
};

void EncontrarNome(List<string> listaDeNomes, string encontrarNome)
{
    for (int i = 0; i < listaDeNomes.Count; i++)
    {
        var nomeAtual = listaDeNomes[i];
        if (nomeAtual == encontrarNome)
        {
            Console.WriteLine($"Nome encontrado na posição indice:{i} ");
            return;
        }

    }
    Console.WriteLine($"Nome não encontrado!");
}

//EncontrarNome(nomesDosEscolhidos, "Luciano");

// SOLUÇÃO USANDO CONTAINS
void VerificaNomes(List<string> nomesDosEscolhidos, string escolhido)
{
    if (nomesDosEscolhidos.Contains(escolhido))
    {
        Console.WriteLine("Nome encontrado");
        return;
    }
    Console.WriteLine("Nome não encontrado!");
}

//VerificaNomes(nomesDosEscolhidos, "Luciano");