namespace OperadoresdeAgrupamento;

public class FonteDados
{
    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new List<Aluno>
        {
            new Aluno { AlunoId = 1, Curso = "Física", Nome = "João", Sexo = 'M', Idade = 20 },
            new Aluno { AlunoId = 2, Curso = "Química", Nome = "Maria", Sexo = 'F', Idade = 19 },
            new Aluno { AlunoId = 3, Curso = "Moda", Nome = "Pedro", Sexo = 'M', Idade = 21 },
            new Aluno { AlunoId = 4, Curso = "Engenharia", Nome = "Ana", Sexo = 'F', Idade = 22 },
            new Aluno { AlunoId = 5, Curso = "Física", Nome = "Carlos", Sexo = 'M', Idade = 23 },
            new Aluno { AlunoId = 6, Curso = "Química", Nome = "Julia", Sexo = 'F', Idade = 18 },
            new Aluno { AlunoId = 7, Curso = "Moda", Nome = "Lucas", Sexo = 'M', Idade = 20 },
            new Aluno { AlunoId = 8, Curso = "Engenharia", Nome = "Leticia", Sexo = 'F', Idade = 21 },
            new Aluno { AlunoId = 9, Curso = "Física", Nome = "Rafael", Sexo = 'M', Idade = 19 },
            new Aluno { AlunoId = 10, Curso = "Química", Nome = "Fernanda", Sexo = 'F', Idade = 22 }
        };
        return alunos;
    }

}
