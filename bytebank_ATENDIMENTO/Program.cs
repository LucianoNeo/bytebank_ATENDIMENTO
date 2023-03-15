using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Modelos.bytebank.Util;
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
    new ContaCorrente(546),
    new ContaCorrente(547),
    new ContaCorrente(548)
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
        opcao = Console.ReadLine()[0];
        switch (opcao)
        {
            case '1':
                CadastrarConta();
                break;
            case '2':
                ListarContas();
                break;
            default:
                Console.WriteLine("Opcao não implementada.");
                break;
        }
    }
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
        Console.WriteLine("Número da Conta : " + item.Conta);
        Console.WriteLine("Saldo da Conta : " + item.Saldo);
        Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    }
    Console.ReadKey();

}


//AtendimentoCliente();

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

VerificaNomes(nomesDosEscolhidos, "Luciano");