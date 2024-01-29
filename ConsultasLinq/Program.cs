// Exemplo código Tradicional

//List<string> nomes = new List<string>()
//{
//    "Maria",
//    "Miriam",
//    "Carlos",
//    "Manoel"
//};

//string? resultado = nomes.Find(VerificaNomeNaLista);

//Console.WriteLine(resultado.ToString());

//static bool VerificaNomeNaLista(string nome)
//{
//    return nome.Equals("Carlos");
//}

// Exemplo com método anônimo e delegate ---------------------------------------------------------------------------------------
//List<string> nomes = new List<string>()
//{
//    "Maria",
//    "Miriam",
//    "Carlos",
//    "Manoel"
//};

//string? resultado = nomes.Find(delegate (string nome)
//    {
//        return nome.Equals("Carlos");
//    });

//Console.WriteLine(resultado);


// Exemplo com expressão lambda ------------------------------------------------------------------------------------------

List<string> nomes = new List<string>()
{
    "Maria",
    "Miriam",
    "Carlos",
    "Manoel"
};

string? resultado = nomes.Find(nome => nome.Equals("Carlos"));
Console.WriteLine(resultado);

Console.ReadKey();
