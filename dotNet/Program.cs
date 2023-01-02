using dotNet.Commom.Models;

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 10;

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// // Redimensionando o Array
// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Percorrendo o Array com o FOR
for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posição {i} - Valor {arrayInteiros[i]}");
}

// int contadorForeach = 0;
// //  Percorrendo o Array com o FOREACH
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição {contadorForeach} - Valor {valor}");
//     contadorForeach++;
// }





















// string? opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     // Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastrar cliente");
//             break;
//         case "2":
//             Console.WriteLine("Buscar cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break; 
//         case "4":
//             Console.WriteLine("Encerrar");
//             // Environment.Exit(0);
//             exibirMenu = false;
//             break;
//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }

// }

// Console.WriteLine("Fim do programa");














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