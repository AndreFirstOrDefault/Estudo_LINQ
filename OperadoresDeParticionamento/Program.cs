// LINQ - Operadores de Particionamento
// Take, TakeWhile, Skip, SkipWhile => execução adiada

#region Take

//Console.WriteLine("Exemplo 01 - Take - retornando os primeiro 4 elementos\n");
//List<int> numeros = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
//List<int> resultado = numeros.Take(4).ToList();

//foreach (var num in resultado)
//{
//    Console.Write($"{num} ");
//}

//Console.WriteLine("\n\nExemplo 02 - Take - ordenando por ordem descendente e retornando os 5 primeiros elementos\n");
//List<int> numeros2 = new List<int> { 1, 3, 7, 10, 5, 8, 6, 9, 4, 2 };
//var resultado2 = numeros.OrderByDescending(n => n).Take(5);

//foreach (var item in resultado2)
//{
//    Console.Write($"{item} ");
//}

//Console.WriteLine("\n\nExemplo 03 - Take - ordenando e filtrando numeros maiores que 5 e retornando 5 elementos \n");
//var resultado3 = numeros.OrderBy(n => n).Where(num => num > 5).Take(5);

//foreach (var item in resultado3)
//{
//    Console.Write($"{item} ");
//}

#endregion

#region TakeWhile

//Console.WriteLine("Exemplo 01 - TakeWhile - imprimindo números menores que 5 da lista ordenada\n");
//List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//List<int> numerosDesordenados = new List<int> { 3, 2, 5, 4, 10, 6, 7, 1, 8, 9 };

//List<int> resultado = numeros.TakeWhile(x => x < 5).ToList();
//List<int> resultado2 = numerosDesordenados.TakeWhile(x => x < 10).ToList();

//foreach (var num in resultado)
//{
//    Console.Write($"{num} ");
//}

//Console.WriteLine("\n\nExemplo 02 - TakeWhile - imprimindo números menores que 10 da lista desordenada\n");
//foreach (var num in resultado2)
//{
//    Console.Write($"{num} ");
//}

//Console.WriteLine("\n\nExemplo 03 - TakeWhile - Imprimindo nomes enquanto forem maiores que seu indice\n");
//List<string> nomes = new List<string>() { "Sara", "Raul", "José", "Ana", "Pedro" };
//List<string> resultado3 = nomes.TakeWhile((nome, index) => nome.Length > index).ToList();

//foreach (var item in resultado3)
//{
//    Console.Write($"{item} ");
//}

//Console.WriteLine("\n\nExemplo 02 - Take - ordenando por ordem descendente e retornando os 5 primeiros elementos\n");
//List<int> numeros2 = new List<int> { 1, 3, 7, 10, 5, 8, 6, 9, 4, 2 };
//var resultado2 = numeros.OrderByDescending(n => n).Take(5);

//foreach (var item in resultado2)
//{
//    Console.Write($"{item} ");
//}

//Console.WriteLine("\n\nExemplo 03 - Take - ordenando e filtrando numeros maiores que 5 e retornando 5 elementos \n");
//var resultado3 = numeros.OrderBy(n => n).Where(num => num > 5).Take(5);

//foreach (var item in resultado3)
//{
//    Console.Write($"{item} ");
//}

#endregion

#region Skip

//Console.WriteLine("Exemplo 01 - Skip - ignorando os primeiros 4 elementos\n");
//List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//var resultado = numeros.Skip(4);
//var resultado2 = numeros.Where(n => n > 3).Skip(4);

//foreach (var item in resultado)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine("\n\nExemplo 02 - Skip - filtrando os numeros maiores que 3, ignorando 4 numeros e exibindo\n");
//foreach (var item in resultado2)
//{
//    Console.Write(item + " ");
//}

#endregion

#region SkipWhile

Console.WriteLine("Exemplo 01 - SkipWhile - ignorando os primeiros numeros menores que 5 e exibindo\n");
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> numerosDesordenados = new List<int> { 1, 4, 5, 6, 7, 8, 9, 10, 2, 3 };
var resultado = numeros.SkipWhile(n => n < 5);
var resultado2 = numerosDesordenados.SkipWhile(n => n < 5);

foreach (var item in resultado)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n\nExemplo 02 - SkipWhile - ignorando os primeiros numeros menores que 5 e exibindo (coleção desordenada)\n");
foreach (var item in resultado2)
{
    Console.Write(item + " ");
}

List<string> nomes = new List<string>() { "Sara","Raul","José","Ana","Pedro"};
List<string> resultado3 = nomes.SkipWhile((nome, index) => nome.Length > index).ToList();

Console.WriteLine("\n\nExemplo 03 - SkipWhile - ignorando os primeiros nomes cujo o tamanho seja maior que seu indice\n");
foreach (var item in resultado3)
{
    Console.Write(item + " ");
}

#endregion

Console.ReadKey();