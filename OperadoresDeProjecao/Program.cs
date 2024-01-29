// Execução imediata => ToList(), ToArray(), AsEnumerable, AsQueryable, ToDicitionary(), ToLookup

// Operador Select

/*
IEnumerable<Aluno> alunos = FonteDados.GetAlunos().ToList(); => select implicito

IEnumerable<Aluno> alunos = FonteDados.GetAlunos().Select(a => a.Nome);
 
*/

// Sintaxe de método
using ConsultasLinq2;

// Select

//IEnumerable<Aluno> alunos = FonteDados.GetAlunos().ToList();
//IEnumerable<string> nome = FonteDados.GetAlunos().Select(n => n.Nome);

//List<Aluno> lista = FonteDados.GetAlunos().Select(a => new Aluno()
//{
//    Nome = a.Nome,
//    Nota = a.Nota

//}).ToList();

//var alunosTipoAnonimo = FonteDados.GetAlunos().Select(a => new
//{
//    NomeAluno = a.Nome,
//    IdadeAluno = a.Idade
//});

//Console.WriteLine("Alunos\n");
//foreach (var item in alunosTipoAnonimo)
//{
//    Console.WriteLine($"{item.NomeAluno} - {item.IdadeAluno}");
//}

// SelectMany

Console.ReadKey();