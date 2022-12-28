using dotNet.Models;

bool ehMaiorDeIdade = false;
bool possuiAutorizacaoDoResponsavel = false;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Pode entrar");
}
else
{
    Console.WriteLine("Não pode entrar");
}