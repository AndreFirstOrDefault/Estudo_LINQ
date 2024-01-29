// Reverse

List<string> nomes = new List<string> {"Pedro","Tania","Amaral","Penita","Debora" };
// var lista = nomes.Reverse(); => erro pois esse método retorna void

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Imprimindo lista de nomes: \n");

foreach (var item in nomes)
{
    Console.WriteLine(item);
}

Console.ForegroundColor= ConsoleColor.DarkBlue;
Console.WriteLine("\nImprimindo lista de nomes usando reverse: \n");

nomes.Reverse();
foreach (var item in nomes)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nImprimindo lista de nomes usando reverse (depois de converter para IQueryable): \n");

IQueryable<string> nomesInvertidos = nomes.AsQueryable();
IEnumerable<string> nomesInvertidos2 = nomes.AsEnumerable();

foreach (var item in nomesInvertidos)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nImprimindo lista de nomes usando reverse (depois de converter para IEnumerable): \n");

foreach (var item in nomesInvertidos2)
{
    Console.WriteLine(item);
}

Console.ReadKey();
