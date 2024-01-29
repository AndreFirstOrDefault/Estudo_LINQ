// LINQ - Operações de conjunto

// Operadores => Distinct ou DistinctBy
// Except ou ExceptBy
// Intersect ou IntersectBy
// Union ou UnionBy

using OperacoesConjuntos1;

var nomes = FonteDados1.GetNomes().Distinct();
var nomes2 = FonteDados1.GetNomes().Distinct(StringComparer.OrdinalIgnoreCase);
var alunos = FonteDados1.GetAlunos();

// Imprimindo lista normal direto da fonte de dados: 
//Console.WriteLine("Imprimindo lista normal direto da fonte de dados:\n");
//var lista = FonteDados1.GetNomes();

//foreach (var nome in lista)
//{
//    Console.WriteLine(nome);
//}

//// Imprimindo lista usando Distinct: 
//Console.WriteLine("\nImprimindo lista usando Distinct: \n");

//foreach (var nome in nomes2)
//{
//    Console.WriteLine(nome);
//}

// Imprimindo lista usando DistinctBy: 

//Console.WriteLine("\nImprimindo lista usando DistinctBY: \n");

//var alunos = FonteDados1.GetAlunos().ToList();
//var alunosIdadesDistintas = alunos.DistinctBy(a => a.Idade);

//foreach (var aluno in alunosIdadesDistintas)
//{
//    Console.WriteLine($"Nome: {aluno.Nome} Idade: {aluno.Idade}");
//}

//// Imprimindo lista usando Except: 
//Console.WriteLine("\nImprimindo lista usando Except: \n");

//var listaExcept = FonteDados1.GetNomes().Except(FonteDados1.GetNomes2());

//foreach (var nome in listaExcept)
//{
//    Console.WriteLine(nome);
//}

//// Imprimindo lista usando Except: 
//Console.WriteLine("\nImprimindo lista usando Except: \n");

//var listaExcept2 = FonteDados1.GetNomes2().Except(FonteDados1.GetNomes());

//foreach (var nome in listaExcept2)
//{
//    Console.WriteLine(nome);
//}

// Imprimindo lista usando ExceptBy: 
//Console.WriteLine("\nImprimindo lista usando ExceptBy: \n");
//var alunos = FonteDados1.GetAlunos();
//var alunosReprovados = new List<string>() { "Amanda","Clodoaldo","Simara"};
//var alunosAprovados = alunos.ExceptBy(alunosReprovados, n => n.Nome);

//foreach (var nome in alunosAprovados)
//{
//    Console.WriteLine($"Nome: {nome.Nome}");
//}

// Imprimindo lista usando Intersect: 
//Console.WriteLine("\nImprimindo lista usando Intersect: \n");

//var listaIntersect = FonteDados1.GetNomes().Intersect(FonteDados1.GetNomes2());

//foreach (var nome in listaIntersect)
//{
//    Console.WriteLine(nome);
//}


// Imprimindo lista usando IntersectBy: 
//Console.WriteLine("\nImprimindo lista usando IntersectBy: \n");

var turmaA = FonteDados1.GetTurmaA();
var turmaB = FonteDados1.GetTurmaB();
//var consulta = turmaA.Select(p => p.DataNascimento.Year).Intersect(turmaB.Select(p => p.DataNascimento.Year));
//var alunosMesmoAnoNascimento = turmaA.IntersectBy(turmaB.Select(p => p.DataNascimento.Year), p => p.DataNascimento.Year);

//foreach (var aluno in consulta)
//{
//    Console.WriteLine(aluno.ToString());
//}

//foreach (var aluno in alunosMesmoAnoNascimento)
//{
//    Console.WriteLine(aluno.Nome + " " + aluno.DataNascimento.Year);
//}


// Imprimindo lista usando Union: 
//Console.WriteLine("\nImprimindo lista usando Union: \n");

//var listaUnion = FonteDados1.GetNomes().Union(FonteDados1.GetNomes2());

//foreach (var nome in listaUnion)
//{
//    Console.WriteLine(nome);
//}

// Imprimindo lista usando UnionBy: 
Console.WriteLine("\nImprimindo lista usando Union: \n");

var turmaUnionBy = turmaA.UnionBy(turmaB, p => p.Nome);

foreach (var nome in turmaUnionBy)
{
    Console.WriteLine(nome.Nome);
}

Console.ReadKey();
