// SelectMany

Console.WriteLine("Usando SelectMany\n");

List<List<int>> listas = new List<List<int>>
{
    new List<int> { 1, 2, 3 },
    new List<int>{14},
    new List<int>{5, 6, 5, 7},
    new List<int>{10, 12, 12, 13}
};

IEnumerable<int> resultado = listas.SelectMany(lista => lista);
IEnumerable<int> resultado1 = listas.SelectMany(lista => lista.Distinct());

foreach (var item in resultado1)
{
    Console.WriteLine(item);
}

Console.ReadKey();
