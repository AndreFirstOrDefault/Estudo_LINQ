// Operadores de conversão => AsEnumerable, AsQueryable, Cast e OfType

// AsEnumerable -> converte o tipo específico de uma determina lista em seu tipo equivalente IEnumerable().
// IEnumerable<TSource> AsEnumerable<TSource> (IEnumerable<TSource> source);

//Console.WriteLine("Imprimindo coleção de inteiros antes do AsEnumerable\n");
//int[] numeros = new int[] {1,2,3,4,5};
//foreach (var item in numeros)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine($"\nTipo da coleção: {numeros.GetType().Name}");

//Console.WriteLine("\nImprimindo coleção de inteiros após o AsEnumerable\n");

//var resultado = numeros.AsEnumerable();
//foreach (var item in resultado)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine($"\nTipo da coleção: {resultado.GetType().Name}");

//Console.WriteLine("\nImprimindo coleção de string antes do AsEnumerable\n");
//var paises = new List<string> { "US","India","UK","Australia","Canada"};
//foreach (var item in paises)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine($"\nTipo da coleção: {paises.GetType().Name}");

//Console.WriteLine("\nImprimindo coleção de string após o AsEnumerable\n");

//var resultado1 = paises.AsEnumerable();
//foreach (var item in resultado1)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine($"\nTipo da coleção: {resultado1.GetType().Name}");

// AsQueryable converte um IEnumerable em IQueryable
// IQueryable AsQueryable(this IEnumerable source);

//using System.Linq.Expressions;

//List<int> numeros = new List<int> { 78,92,100,37,81};
//IQueryable<int> resultado = numeros.AsQueryable();
//Expression expressionTree = resultado.Expression;

//Console.WriteLine("O NodeType da árvore de expressão é : " + expressionTree.ToString());
//Console.WriteLine("O tipo da árvore de expressão é : " + expressionTree.Type.Name);

//foreach (var item in numeros)
//{
//    Console.WriteLine(item);
//}

//var numeros = new int[] { 5, 10, 20, 60, 72, 90, 102, 114 };
//var resultado = numeros.AsQueryable();

//double media = Queryable.Average(resultado);
//int soma = Queryable.Sum(resultado);
//int conta = Queryable.Count(resultado);
//int maximo = Queryable.Max(resultado);
//int minimo = Queryable.Min(resultado);
//Console.WriteLine("Imprimindo a coleção de números: \n");
//foreach (var item in resultado)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine("\n\nDados obtidos após transformar IEnumerable em IQueryable e aplicar alguns métodos\n");
//Console.WriteLine($"Average: {media:n2}");
//Console.WriteLine($"Sum: {soma}");
//Console.WriteLine($"Count: {conta}");
//Console.WriteLine($"Max: {maximo}");
//Console.WriteLine($"Min: {minimo}");

// Cast -> tenta converter todos os tipos da coleção em outro tipo e retorná-los em uma nova coleção que contém os elementos convertidos

// IEnumerable<TResult> Cast<TResult>(this IEnumerable source);

//using System.Collections;

//ArrayList lista = new ArrayList { 10,20,30 };
//IEnumerable<int> resultado = lista.Cast<int>();

//foreach (var item in resultado)
//{
//    Console.WriteLine(item);
//}

//OfType->filtra dados de tipo especifico de uma fonte de dados com base no tipo de dado que passamos para esse operador
// IEnumerable<TResult> OfType<TResult> (this IEnumerable source);

List<object> dados = new List<object>()
{
    "Tania","Maria",50,"Manoel",10,20,30,40,"Tiago"
};
Console.WriteLine("Imprimindo coleção:\n");
foreach (var item in dados)
{
    Console.WriteLine(item);
}

var dadosInt = dados.OfType<string>().ToList();
Console.WriteLine("\nImprimindo somente string usando OfType:\n");
foreach (var item in dadosInt)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nImprimindo somente os inteiros maiores que 30 usando OfType e Where:\n");
var dadosInt30 = dados.OfType<int>().Where(x => x > 30).ToList();
foreach (var item in dadosInt30)
{
    Console.WriteLine(item);
}

Console.ReadKey();
