// Aggregate - Obter uma string com nomes separados por vírgula a partir de uma lista 

using OperacoesConjuntos1;

Console.Title = "Aggregate";

//Console.WriteLine("Aggregate - Obter uma string com nomes separados por vírgula a partir de uma lista \n");
//string[] cursos = { "C#", "Java", "Python", "PHP", "GO" };
//string resultado = cursos.Aggregate((s1, s2) => s1 + ", " + s2);
//Console.WriteLine(resultado);

//// Aggregate - Calcular o produto resultante dos itens de uma coleção

//Console.WriteLine("\nAggregate - Calcular o produto resultante dos itens de uma coleção\n");
//int[] numeros = { 3, 5, 7, 9, 10 };
//int resultado2 = numeros.Aggregate((n1,n2) => n1 * n2);
//Console.WriteLine(resultado2);

// Aggreate Com valor de semente inicial

Console.WriteLine("\nAggreate Com valor de semente inicial\n");

List<Aluno> alunos = new List<Aluno>()
{
    new Aluno(){Nome = "Maria", Idade = 36},
    new Aluno(){Nome = "Manoel", Idade = 33},
    new Aluno(){Nome = "Amanda" , Idade = 21}
};

string listaAlunos = alunos.Aggregate("Nomes: ", (semente, aluno) => semente += aluno.Nome + ", ");
//int indice = listaAlunos.LastIndexOf(',');
//var lista = listaAlunos.Remove(indice);
Console.WriteLine(listaAlunos);

Console.WriteLine("\nAggreate Com valor de semente inicial e seletor de resultado\n");
string listaAlunos2 = alunos.Aggregate("Nomes: ", (semente, aluno) => semente += aluno.Nome + ",", result => result.Substring(0, result.Length - 1));
Console.WriteLine(listaAlunos2);

// Average => Calcula a média 
var mediaIdades = alunos.Average(a => a.Idade);
Console.WriteLine($"Média das idades: {mediaIdades:n0}");

Console.ReadKey();
