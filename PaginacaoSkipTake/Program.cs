// Número de páginas e numero de registros por página
// Fórmula padrão da paginação: Resultado = DataSource.Skip(NP-1)*NRP.Take(NRP)

// Definir o número de registros por página

using PaginacaoSkipTake;

int RegistrosPorPagina = 4;
int NumeroPagina;

do
{
    Console.Write("\nInforme o n° de página entre 1 e 4: ");
    if (int.TryParse(Console.ReadLine(), out NumeroPagina))
    {
        if(NumeroPagina > 0 && NumeroPagina < 5)
        {
            var alunos = Aluno.GetAlunos()
                         .Skip((NumeroPagina -1) * RegistrosPorPagina)
                         .Take(RegistrosPorPagina).ToList();

            Console.WriteLine("\nPag. : " + NumeroPagina);
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Id: {aluno.Id} Nome: {aluno.Nome}, Curso: {aluno.Curso}");
            }
        }
        else
        {
            Console.WriteLine("Informe um n° de página válido");
        }
    }
    else
    {
        Console.WriteLine("Informe um n° de página válido");
    }
    
}
while (true);
