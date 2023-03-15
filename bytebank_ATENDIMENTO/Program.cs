Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");


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

Array amostra = Array.CreateInstance(typeof(double), 6);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);
amostra.SetValue(8, 5);

TestaMediana(amostra);
void TestaMediana(Array array)
{
    if((array == null) || (array.Length == 0)){
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