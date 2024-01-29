// LINQ - Operadores de conversão
// ToArray, ToDicitionary, ToList, ToLookup, AsEnumerable, AsQueryable, Cast, OfType

// Linq -> ToList 
// Diferenças entre List e IEnumerable
// IEnumerable é somente leitura, retorna o próximo item da coleção, não precisa ter tudo na memória
// IEnumerable tem execução adiada

// Usar IEnumerable quando se quer apenas ler, quando existem muitos métodos
// List quando se quer alterar a coleção

#region ToList
using OperadoresdeAgrupamento;

//Console.WriteLine("Exemplo 01 - Tolist\n");

//string[] paises = { "US", "UK", "India", "Russia", "China", "Brasil", "Peru" };
//Console.WriteLine($"Antes da conversão: {paises.GetType()}\n");

//var resultado = paises.ToList();
//Console.WriteLine($"Após a conversão: {resultado.GetType()}\n");
//foreach (var item in resultado)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("\nExemplo 02 - ToList\n");
//var alunos = FonteDados.GetAlunos(); // Retorna um IEnumerable
//var lista = alunos.Where(a => a.Nome.Contains('M')).ToList(); // -> List<Aluno>?

//foreach (var item in lista)
//{
//    Console.WriteLine(item.Nome);
//}

#endregion

#region ToArray

//Console.WriteLine("Exemplo 01 - ToArray\n");

//var alunos = FonteDados.GetAlunos(); // Retorna um IEnumerable
//var lista = alunos.Where(a => a.Nome.Contains('a')).ToArray(); // -> Aluno[]? lista

//foreach (var item in lista)
//{
//    Console.WriteLine(item.Nome);
//}

//Console.WriteLine("\nExemplo 02 - ToArray\n");
//var alunos20 = alunos.Where(a => a.Idade < 20).ToArray();

//foreach (var item in alunos20)
//{
//    Console.WriteLine(item.Nome + " " + item.Idade);
//}

#endregion

#region ToDictionary

//Console.WriteLine("Exemplo 01 - ToDictionary\n");

//var alunos = FonteDados.GetAlunos(); // Retorna um IEnumerable
//var listaDic = alunos.ToDictionary(a => a.AlunoId); 

//foreach (var chave in listaDic.Keys)
//{
//    Console.WriteLine($"Chave: {chave}, Valor: {listaDic[chave].Nome}");
//}

#endregion

#region ToLookup

Console.WriteLine("Exemplo 01 - ToLookup\n");

var alunos = FonteDados.GetAlunos(); // Retorna um IEnumerable
var alunosPorIdade = alunos.ToLookup(i => i.Idade);

Console.WriteLine("Alunos agrupados por idade\n");
foreach (var chave in alunosPorIdade)
{
    Console.WriteLine($"Alunos com {chave.Key} anos:");
    foreach (var item in alunosPorIdade[chave.Key])
    {
        Console.WriteLine($"Nome: {item.Nome}\tCurso: {item.Curso}");
    }
    Console.WriteLine();
}

#endregion

Console.ReadKey();