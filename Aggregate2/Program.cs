//  LINQ Count
// Count<TSource>(IEnumerable<TSource>)
// Count<TSource>(IEnumerable<TSource>,Func<TSource,Boolean>)

using Aggregate2;

Console.WriteLine("Usando Count para somar o número de elementos\n");
string[] cursos = { "C#", "Java", "Phyton", "PHP", "JavaScript", "Ruby", "Kotlin" };
var numeroDeCursos = cursos.Count();
Console.WriteLine($"Quantidade de cursos: {numeroDeCursos}");

Console.WriteLine("\nUsando Count para somar o número de elementos que contem a letra P\n");
var numeroDeCursosComP = cursos.Count(c => c.Contains('P'));
Console.WriteLine($"Quantidade de cursos: {numeroDeCursosComP}");

Console.WriteLine("\nUsando Count e Where para somar o número de elementos que contem a letra P\n");
var numeroDeCursosComP2 = cursos.Where(c => c.Contains('P')).Count();
Console.WriteLine($"Quantidade de cursos: {numeroDeCursosComP2}");

// LINQ LongCount
// LongCount<TSource>(IEnumerable<TSource>)
// LongCount<TSource>(IEnumerable<TSource>,Func<TSource,Boolean>)

// LINQ Sum
int[] numeros = { 3, 5, 7, 9, 10, 12, 20 };
var soma = numeros.Sum();
Console.WriteLine("\nUsando Sum para somar os elementos de um array de inteiros\n");
Console.WriteLine($"Soma dos números => {soma}");

Console.WriteLine("\nUsando Sum para somar os elementos de um array de inteiros usando Where (maior que 10)\n");
var soma1 = numeros.Where(n => n > 10).Sum();
Console.WriteLine($"Soma dos números maiores que 10 => {soma1}");

Console.WriteLine("\nUsando Sum para somar os elementos de um array de inteiros com uma condiçao (maior que 10)\n");
var soma2 = numeros.Sum(n => 
{
    if (n > 10)
        return n;
    else
        return 0;
});
Console.WriteLine($"Soma dos números maiores que 10 => {soma2}");

// LINQ Max/MaxBy
var funcionarios = Funcionario.GetFuncionarios();
var maiorIdade = funcionarios.Max(f => f.Idade);
var maiorSalario = funcionarios.Max(f => f.Salario);

Console.WriteLine("Usando Max\n");
Console.WriteLine($"Obtendo o funcionario de maior idade: {maiorIdade}");
Console.WriteLine($"Obtendo o funcionario de maior salário: {maiorSalario}\n");


// LINQ Min/MinBy
Console.WriteLine("Usando Min\n");
var menorIdade = funcionarios.Min(f => f.Idade);
var menorSalario = funcionarios.Min(f => f.Salario);
Console.WriteLine($"Obtendo o funcionario de menor idade: {menorIdade}");
Console.WriteLine($"Obtendo o funcionario de menor salário: {menorSalario}\n");

Console.ReadKey();
