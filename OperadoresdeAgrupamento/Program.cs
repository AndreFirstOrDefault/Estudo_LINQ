// LINQ - GroupBy

using OperadoresdeAgrupamento;

var alunos = FonteDados.GetAlunos();

// sintaxe de método
var grupos = alunos.GroupBy(a => a.Sexo).OrderBy(i => i.Key);

// sintaxe de consulta
var grupos2 = from a in alunos 
              group a by a.Idade into grupo
              orderby grupo.Key
              select grupo;

Console.WriteLine("Imprimindo todos os alunos\n");
foreach (var item in alunos)
{
    Console.WriteLine($"Nome: {item.Nome}, Idade: {item.Idade}");
}

Console.WriteLine("\nImprimindo usando groupBy");
foreach (var grupo in grupos)
{
    Console.WriteLine($"\nSexo: {grupo.Key} alunos: {grupo.Count()}");
    foreach (var aluno in grupo)
    {
        Console.WriteLine($"\tNome: {aluno.Nome}, Idade: {aluno.Idade}");
    }
}

Console.ReadKey();

