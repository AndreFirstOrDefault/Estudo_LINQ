// Operadores de ordenação

// OrderBy e OrderByDescending

using OperadoresDeOrdenacao;
using System.Collections.ObjectModel;

Console.Title = "LINQ - Ordenação";

List<string> nomes = new List<string> { "Paulo", "Tarcisio", "Amaral", "Pedro", "Debora", "Helena", "Percival", "Manoel", "Ruth", "José" };
List<double> precos = new List<double> { 5.65, 6.99, 1.50, 6.75, 1.25, 3.45, 50, 61.32, 250.39, 23.99, 25.05, 25.00, 6.35 };


#region OrderBy

//CorVermelha();
//Console.WriteLine("Imprimindo lista sem OrderBy:\n");

//foreach (var nome in nomes)
//{ 
//    Console.Write(nome + "  ");
//}

//CorVerde();
//var nomesOrderBy = nomes.OrderBy(n => n);

//Console.WriteLine("\n\nImprimindo lista com OrderBy:\n");

//foreach (var nome in nomesOrderBy)
//{
//    Console.Write(nome + "  ");
//}

#endregion

#region OrderByDescending

//CorVermelha();
//Console.WriteLine("Imprimindo lista sem OrderByDescending:\n");

//foreach (var preco in precos)
//{
//    Console.Write(preco + "  ");
//}

//CorVerde();

//var precosOrderByDescending = precos.OrderByDescending(p => p);

//Console.WriteLine("\n\nImprimindo lista com OrderByDescending:\n");

//foreach (var preco in precosOrderByDescending)
//{
//    Console.Write(preco + "  ");
//}

#endregion

#region OrderBy com objetos complexos

List<Aluno> alunos = new List<Aluno> 
{
    new Aluno(){Nome="Maria",Idade=20},
    new Aluno(){Nome="Manoel",Idade=22},
    new Aluno(){Nome="Miriam",Idade=21},
    new Aluno(){Nome="Matilda",Idade=21}
};

CorVermelha();
Console.WriteLine("Imprimindo nome e idade de alunos\n");
Console.WriteLine("NOME\tIDADE\n");
foreach (var item in alunos)
{
    Console.WriteLine(item.Nome + "\t" + item.Idade);
}

CorVerde();
//Console.WriteLine("\nImprimindo nome e idade alunos com OrderBy (ordenando por nome)\n");
//Console.WriteLine("NOME\tIDADE\n");
//var alunosOrderBy = alunos.OrderBy(a => a.Nome);
//foreach (var item in alunosOrderBy)
//{
//    Console.WriteLine(item.Nome + "\t" + item.Idade);
//}

Console.WriteLine("\nImprimindo nome e idade alunos com OrderByDescending (ordenando por nome)\n");
Console.WriteLine("NOME\tIDADE\n");
var alunosOrderByDescendingNome = alunos.OrderBy(a => a.Nome);
foreach (var item in alunosOrderByDescendingNome)
{
    Console.WriteLine(item.Nome + "\t" + item.Idade);
}

//CorVerde();
//Console.WriteLine("\nImprimindo nome e idade alunos com OrderBy (ordenando por idade)\n");
//Console.WriteLine("NOME\tIDADE\n");
//var alunosOrderByIdade = alunos.OrderBy(a => a.Idade);
//foreach (var item in alunosOrderByIdade)
//{
//    Console.WriteLine(item.Nome + "\t" + item.Idade);
//}

//CorVerde();
//Console.WriteLine("\nImprimindo nome e idade alunos com OrderByDescending (ordenando por idade)\n");
//Console.WriteLine("NOME\tIDADE\n");
//var alunosOrderByIdadeDescending = alunos.OrderBy(a => a.Idade);
//foreach (var item in alunosOrderByIdadeDescending)
//{
//    Console.WriteLine(item.Nome + "\t" + item.Idade);
//}

CorVerde();
Console.WriteLine("\nImprimindo nome e idade alunos com OrderBy e ThendBy (ordenando por nome e idade)\n");
Console.WriteLine("NOME\tIDADE\n");
var alunosOrderByEThendBy = alunos.OrderBy(a => a.Nome).ThenBy(a=>a.Idade);
foreach (var item in alunosOrderByEThendBy)
{
    Console.WriteLine(item.Nome + "\t" + item.Idade);
}

CorVerde();
Console.WriteLine("\nImprimindo nome e idade alunos com OrderByDescending e ThendByDescending (ordenando por nome e idade)\n");
Console.WriteLine("NOME\tIDADE\n");
var alunosOrderByDescendingEThendByDescending = alunos.OrderByDescending(a => a.Nome).ThenByDescending(a => a.Idade);
foreach (var item in alunosOrderByDescendingEThendByDescending)
{
    Console.WriteLine(item.Nome + "\t" + item.Idade);
}

#endregion

static void CorVermelha()
{
    Console.ForegroundColor = ConsoleColor.Red;
}

static void CorVerde()
{
    Console.ForegroundColor = ConsoleColor.Green;
}


Console.ReadKey();