using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_GeradorChavePix;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
Console.WriteLine();
//new ByteBankAtendimento().AtendimentoCliente();

var listaDeChaves = GeradorPix.GetChavesPix(10);

Console.WriteLine("Chave unica");
Console.WriteLine(GeradorPix.GetChavePix());
Console.WriteLine();
Console.WriteLine("Lista de chaves");

foreach (var chave in listaDeChaves)
{
    Console.WriteLine(chave);
}