Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

TestaBuscarPalavra();

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
        Console.Write($"Digite a {i+1}ª Palavra: ");
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