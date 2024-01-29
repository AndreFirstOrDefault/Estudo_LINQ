// As consultas LINQ retornam um objeto

// FROM, Where, Select/GroupBy

// Exemplo 01

Exemplo01();
Exemplo02();

static void Exemplo01()
{
    Console.WriteLine("## LINQ ##\n");
    Console.WriteLine("## EXEMPLO 01 ##\n");    
    IList<string> frutas = new List<string>() { "Banana", "Maça", "Pera", "Laranja", "Uva" };
    var resultado = from f in frutas
                    where f.Contains('r')
                    select f;

    //foreach (var item in resultado)
    //{
    //    Console.WriteLine(item);
    //}

    Console.WriteLine(string.Join("\n", resultado));
}

static void Exemplo02()
{
    Console.WriteLine("\n## EXEMPLO 02 ##\n");
    IList<string> frutas = new List<string>() { "Banana", "Maça", "Pera", "Laranja", "Uva" };
    var resultado = frutas.Where(f => f.Contains('r'));

    //foreach (var item in resultado)
    //{
    //    Console.WriteLine(item);
    //}

    Console.WriteLine(string.Join("\n", resultado));
}

Console.ReadKey();
