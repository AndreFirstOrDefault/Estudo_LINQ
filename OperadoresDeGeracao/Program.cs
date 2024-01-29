// Range -> gera uma coleção que contém uma sequencia de números
// Repeat<T> -> gera uma coleção que contém um valor repetido
// Empty<T> -> retorna uma coleção vazia

// Range -> IEnumerable<int> Range (int start, int count);

#region Range

//Console.WriteLine("Exemplo 01 - Range - números de 0 a 10\n");
//IEnumerable<int> numeros = Enumerable.Range(1, 10).Reverse();

//ImprimeColecao(numeros);

//Console.WriteLine("\n\nExemplo 02 - Range - números pares de 10 a 30\n");
//IEnumerable<int> numerosPares = Enumerable.Range(10, 30).Where(x => x % 2 == 0);
//ImprimeColecao(numerosPares);

//Console.WriteLine("\n\nExemplo 03 - Range - numeros de 1 a 10 ao quadrado\n");
//IEnumerable<int> numerosQuadrados = Enumerable.Range(1, 10).Select(x => x * x);
//ImprimeColecao(numerosQuadrados);

#endregion

// Repeat -> IEnumerable<T> Repeat<T> (T element, int count);

#region Repeat

//Console.WriteLine("Exemplo 01 - Repeat - repetindo uma string 10 vezes\n");
//IEnumerable<string> valores = Enumerable.Repeat("Macoratti.net - LINQ",10);

//ImprimeColecao(valores);

//Console.WriteLine("\n\nExemplo 02 - Repeat - repetindo um número 10 vezes\n");
//IEnumerable<int> numeros = Enumerable.Repeat(2024, 10);
//ImprimeColecao(numeros);

#endregion

// Empty<T> -> IEnumerable<T> Empty<T> ();

#region Empty<T>

Console.WriteLine("Exemplo 01 - Empty - criando uma coleção vazia e imprimindo(nada)\n");
var vazio = Enumerable.Empty<string>();
ImprimeColecao(vazio);
Console.WriteLine("Concluído");
Console.ReadKey();

Console.WriteLine("\nExemplo 02 - Empty - criando duas coleções vazias e imprimindo(Count e GetType)\n");
var colecaovazia1 = Enumerable.Empty<string>();
var colecaovazia2 = Enumerable.Empty<Aluno>();

Console.WriteLine("\nColeção de strings\n");
Console.WriteLine("Count: {0} ", colecaovazia1.Count());
Console.WriteLine("Count: {0} ", colecaovazia1.GetType().Name);

Console.WriteLine("\nColeção de objetos Aluno\n");
Console.WriteLine("Count: {0} ", colecaovazia2.Count());
Console.WriteLine("Count: {0} ", colecaovazia2.GetType().Name);

Console.ReadKey();

#endregion

static void ImprimeColecao<T>(IEnumerable<T> numeros)
{
    foreach (var numero in numeros)
    {
        Console.WriteLine(numero);
    }
    Console.ReadKey();
}

public class Aluno
{
    public int ID { get; set; }
    public string? Nome { get; set; }

}