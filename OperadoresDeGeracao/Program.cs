// Range -> gera uma coleção que contém uma sequencia de números
// Repeat<T> -> gera uma coleção que contém um valor repetido
// Empty<T> -> retorna uma coleção vazia

// Range -> IEnumerable<int> Range (int start, int count);

Console.WriteLine("Exemplo 01 - Range - números de 0 a 10\n");
IEnumerable<int> numeros = Enumerable.Range(1, 10).Reverse();

ImprimeColecao(numeros);

Console.WriteLine("\n\nExemplo 02 - Range - números pares de 10 a 30\n");
IEnumerable<int> numerosPares = Enumerable.Range(10, 30).Where(x => x%2 == 0);
ImprimeColecao(numerosPares);

Console.WriteLine("\n\nExemplo 03 - Range - numeros de 1 a 10 ao quadrado\n");
IEnumerable<int> numerosQuadrados = Enumerable.Range(1, 10).Select(x => x * x);
ImprimeColecao(numerosQuadrados);

static void ImprimeColecao(IEnumerable<int> numeros)
{
    foreach (var numero in numeros)
    {
        Console.WriteLine(numero);
    }
    Console.ReadKey();
}