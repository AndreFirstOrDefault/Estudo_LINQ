// Operadores de quantificação
// All, Any, Contains

// All -> verifica se todos os elementos da fonte satisfazem uma condição
// Any -> verifica se pelo menos um elemento da fonte satisfaz uma condição
// Contains -> Determina se a fonte de dados contém um elemento especificado

// All 
// public static bool All<T>(this IEnumerable<T> source, Func<T,bool> predicate);

int[] numeros = { 10, 22, 32, 44, 56, 60, 78 };
var resultado = numeros.All(n => n%2 == 0);
Console.WriteLine($"{(resultado? "Todos são pares" : "Nem todos são pares")}");

// Any
// public static bool Any<T>(this IEnumerable<T> source);
// public static bool Any<T>(this IEnumerable<T> source, Func<T,bool> predicate);
string[] cursos = { "C#", "Java", "Python", "PHP", "ASP.NET", "Node" };
var existemCursos = cursos.Any();
var existemCursosMaiorQue2 = cursos.Any(c => c.Length > 2);

Console.WriteLine($"Existem cursos: {existemCursos}");
Console.WriteLine($"Existem cursos com tamanho maior que 2: {existemCursosMaiorQue2}");

// Contains
var resultado2 = numeros.Contains(44);
Console.WriteLine($"Verificando se contém o elemento 12 : {resultado2}");



Console.ReadKey();
