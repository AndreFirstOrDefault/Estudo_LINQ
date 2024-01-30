// Append<T> adiciona um elemento ao final da coleção sem modificar o restante
// IEnumerable<T> Append<T> (this IEnumerable<T> source, T element);

//List<int> numeros = new List<int> { 1, 2, 3, 4 };
//Console.WriteLine("Imprimindo a coleção antes de usar o Append\n");
//Console.WriteLine(string.Join(", ",numeros));

//Console.WriteLine("\nImprimindo a coleção após usar o Append(5)\n");
//var numerosAppend = numeros.Append(5);
//Console.WriteLine(string.Join(", ", numerosAppend));

//Console.WriteLine("\nImprimindo coleção antes de usar o Append\n");
//List<string> frutas = new List<string> { "Uva", "Banana", "Laranja" };
//Console.WriteLine(string.Join(", ", frutas));

//Console.WriteLine("\nImprimindo coleção após usar o Append(\"Abacaxi\")\n");
//var frutasAppend = frutas.Append("Abacaxi");
//Console.WriteLine(string.Join(", ", frutasAppend));

// Prepend<T> adiciona um elemento ao inicio da coleção sem modificar o restante
// IEnumerable<T> Prepend<T> (this IEnumerable<T> source, T element);

//List<int> numeros = new List<int> { 1, 2, 3, 4 };
//Console.WriteLine("Imprimindo a coleção antes de usar o Prepend\n");
//Console.WriteLine(string.Join(", ", numeros));

//Console.WriteLine("\nImprimindo a coleção após usar o Prepend(5)\n");
//var numerosPrepend = numeros.Prepend(5);
//Console.WriteLine(string.Join(", ", numerosPrepend));

//Console.WriteLine("\nImprimindo coleção antes de usar o Prepend\n");
//List<string> frutas = new List<string> { "Uva", "Banana", "Laranja" };
//Console.WriteLine(string.Join(", ", frutas));

//Console.WriteLine("\nImprimindo coleção após usar o Prepend(\"Abacaxi\")\n");
//var frutasPrepend = frutas.Prepend("Abacaxi");
//Console.WriteLine(string.Join(", ", frutasPrepend));

// Zip -> aplica uma função especificada aos elementos correspondentes de duas sequencias e produz uma sequencia dos resultados
// Zip<TFirst,TSecond,TResult>(IEnumerable<TFirst>,IEnumerable<TSecond>,Func<TFirst,TSecond,TResult>)

int[] numeros = {10,20, 30,40,50};
string[] palavras = { "Dez", "Vinte", "Trinta", "Quarenta", "Cinquenta" };

Console.WriteLine("\nImprimindo as duas coleções antes do Zip\n");
Console.WriteLine("Coleção de números: \n");
foreach (var numero in numeros)
{
    Console.WriteLine(numero);
}

Console.WriteLine("\nColeção de palavras: \n");
foreach (var palavra in palavras)
{
    Console.WriteLine(palavra);
}

Console.WriteLine("\nImprimindo a coleção após uso o Zip\n");
var colecaozip = numeros.Zip(palavras, (n, p) => $"{n} - {p}");
foreach (var item in colecaozip)
{
    Console.WriteLine(item);
}

Console.ReadKey();


