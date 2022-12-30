using dotNet.Models;

Console.WriteLine("Digite um numero: ");
string? numeroString = Console.ReadLine();
int numero = Convert.ToInt32(numeroString);
// int numero = 5;

for (int i = 0; i <= 10; i++)
{
    int tabuada = numero * i;
    Console.WriteLine($"{numero} * {i} = {tabuada}");
}










// Calculadora calc = new Calculadora();

// calc.Somar(10, 5);
// calc.Subtrair(10, 5);
// calc.Multiplicar(10, 5);
// calc.Dividir(10, 5);
// calc.Potencia(10, 5);
// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(36);











// DateTime dataAtual = DateTime.Now;

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));


// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// quantidade = 10;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine(quantidade);
// Console.WriteLine(altura.ToString("0.00"));
// Console.WriteLine(preco);
// Console.WriteLine(condicao);

// int a = Convert.ToInt32("5");
// int a = int.Parse("5");

// Console.WriteLine(a);


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Guilherme";
// pessoa1.Idade = 34;
// pessoa1.Apresentar();





// //Maneira segura de fazer a conversão. Se não conseguir converter, o valor será 0
// string a = "15-";

// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);



// Operador Condicional
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra <= quantidadeEmEstoque;

// if (possivelVenda)
// {
//     Console.WriteLine("Compra realizada com sucesso");
// }
// else
// {
//     Console.WriteLine("Não foi possível realizar a compra");
// }






// // Switch Case
// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Consoante");
//         break;
// }