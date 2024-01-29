// LINQ - Operadores de elemento
// ElementAt
// ElementAtOrDefault
// First
// FirstOrDefault
// Last
// LastOrDefault
// Single
// SingleOrDefault
// DefaultIfEmpty

// ElementAt => ElementAt<TSource>(IEnumerable<TSource>,Index)
// ElementAt => ElementAt<TSource>(IEnumerable<TSource>,Int32)

using ConsultasLinq2;

// ElementAt
//Console.WriteLine("Usando ElementAt\n");
List<int> numeros = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
Console.Write("Lista de números: ");
foreach (var numero in numeros)
{
    Console.Write($"{numero}, ");
}
Console.WriteLine();

//int resultado = numeros.ElementAt(5);
//Console.WriteLine($"\nImprimindo elemento de indice 5: {resultado}");

var alunos = FonteDados.GetAlunos();
//var resultado2 = alunos.ElementAt(4);

//Console.WriteLine($"Imprimindo nome e idade do aluno de indice 4: {resultado2.Nome}, {resultado2.Idade}");

//var nome = alunos.Select(x => x.Nome).ElementAt(4);
//Console.WriteLine($"Imprimindo nome do aluno de indice 4: {nome}");

//var nota = alunos.Select(x => x.Nota).ElementAt(4);
//Console.WriteLine($"Imprimindo nota do aluno de indice 4: {nota}");

//// First
//Console.WriteLine("\nUsando First\n");
//int resultado5 = numeros.First();
//int resultado6 = numeros.First(x => x > 30);
//Console.WriteLine($"Primeiro elemento da lista de números: {resultado5}");
//Console.WriteLine($"Primeiro elemento maior que 30 da lista de números: {resultado6}");

//var aluno1 = alunos.First();
//Console.WriteLine($"Obtendo o nome do primeiro aluno: {aluno1.Nome}");
//var aluno2 = alunos.First(n => n.Nota > 6);
//Console.WriteLine($"Obtendo o nome do primeiro aluno com nota maior que 6: {aluno2.Nome}");


//// ElementAtOrDefault
//Console.WriteLine("\nUsando ElementAtOrDefault\n");
//int resultado3 = numeros.ElementAtOrDefault(5);
//Console.WriteLine($"Obtendo o elemento de indice 5 na lista de números: {resultado3}");
//var resultado4 = alunos.ElementAtOrDefault(4);
//Console.WriteLine($"Obtendo o elemento de indice 4 na lista de alunos: {resultado4.Nome}, {resultado4.Idade}");
//var nome2 = alunos.Select(n => n.Nome).ElementAtOrDefault(4);
//Console.WriteLine($"Obtendo somente o nome do aluno de indice 4: {nome2}");
//var nota2 = alunos.Select(n => n.Nota).ElementAtOrDefault(4);
//Console.WriteLine($"Obtendo somente a nota do aluno de indice 4: {nota2}");

// FirstOrDefault
// Mesma coisa que First porém retorna um valor padrão caso o valor procurado não exista

// Last => Exibe o ultimo da lista
Console.WriteLine("\nUsando Last\n");
var ultimo = numeros.Last();
Console.WriteLine($"Exibindo o ultimo elemento da lista de numeros: {ultimo}");

var ultimoMenorQue = numeros.Last(n => n > 75 && n < 90);
Console.WriteLine($"Exibindo o último elemento maior que 75 e menor que 90: {ultimoMenorQue}");

var ultimoAluno = alunos.Last();
Console.WriteLine($"Ultimo aluno: {ultimoAluno.Nome}");

var ultimoAlunoQue = alunos.Last(a => a.Nota > 6);
Console.WriteLine($"Ultimo aluno com nota maior que 6: {ultimoAlunoQue.Nome}");


// Single => Retorna o único elemento específico da coleção
Console.WriteLine("\nUsando método Single\n");
List<int> numeros2 = new List<int>() { 3, 8, 10, 3, 9, 7 };
try
{
    var resultado6 = numeros2.Single(n => n > 9);
    Console.WriteLine($"Retornando o único elemento maior que 9: {resultado6}");
}
catch (InvalidOperationException)
{
    Console.WriteLine("Erro, nenhum elemento atendeu a condição ou mais de um elemento atendeu essa condição!");
}

// DefaultIfEmpty
Console.WriteLine("\nUsando DefaultIfEmpty\n");
List<int> numeros3 = new List<int>() { };
IEnumerable<int> resultado = numeros3.DefaultIfEmpty();
Console.Write($"Exibindo os valores da coleção ou o padrão: ");
foreach (var item in resultado)
{
    Console.Write(item + " ");
}

Console.ReadKey();