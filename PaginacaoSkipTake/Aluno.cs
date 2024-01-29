namespace PaginacaoSkipTake;

public class Aluno
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Curso { get; set; }

    public static List<Aluno> GetAlunos()
    {
        return new List<Aluno>
        {
            new Aluno(){Id=1, Nome = "Bruno", Curso = "CSS"},
            new Aluno(){Id=2, Nome = "Maria", Curso = "Java"},
            new Aluno(){Id=3, Nome = "João", Curso = "Node"},
            new Aluno(){Id=4, Nome = "Ana", Curso = "C#"},
            new Aluno(){Id=5, Nome = "Carlos", Curso = "SQL"},
            new Aluno(){Id=6, Nome = "Fernanda", Curso = "Java"},
            new Aluno(){Id=7, Nome = "Ricardo", Curso = "SQL"},
            new Aluno(){Id=8, Nome = "Juliana", Curso = "C#"},
            new Aluno(){Id=9, Nome = "Roberto", Curso = "Phyton"},
            new Aluno(){Id=10, Nome = "Camila", Curso = "Node"},
            new Aluno(){Id=11, Nome = "Rodrigo", Curso = "HTML"},
            new Aluno(){Id=12, Nome = "Patricia", Curso = "PHP"},
            new Aluno(){Id=13, Nome = "Bruno", Curso = "Ruby"},
            new Aluno(){Id=14, Nome = "Gabriela", Curso = "Java"},
            new Aluno(){Id=15, Nome = "Lucas", Curso = "JavaScript"},
            new Aluno() { Id = 16, Nome = "Beatriz", Curso = "CSS" }



        };
    }
}
