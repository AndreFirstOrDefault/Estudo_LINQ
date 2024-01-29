namespace OperacoesConjuntos1;

public class FonteDados1
{
    public static List<string> GetNomes()
    {
        List<string> nomes = new List<string>() 
        {
            "Amanda", "Maria", "Pedro", "Clodoaldo", "Marcio", "Maria", "Pedro", "André", "Simara","Amanda", "Cleide"
        };
        return nomes;
    } 

    public static List<string> GetNomes2()
    {
        List<string> nomes = new List<string>()
        {
            "Armando", "Ana", "Helena", "Clodoaldo", "Marcia", "Maria", "José", "André", "Simara","Arlindo", "Cleide"
        };
        return nomes;
    }

    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new List<Aluno>()
        {
            new Aluno(){Nome="Amanda",Idade=36},
            new Aluno(){Nome="Maria",Idade=52},
            new Aluno(){Nome="Pedro",Idade=20},
            new Aluno(){Nome="Clodoaldo",Idade=21},
            new Aluno(){Nome="Marcio",Idade=36},
            new Aluno(){Nome="André",Idade=52},
            new Aluno(){Nome="Simara",Idade=20},
            new Aluno(){Nome="Cleide",Idade=45}

        };
        return alunos;
    }

    public static List<int> GetNumeros()
    {
        var numeros = new List<int>() { 52,2,9,56,3,4,5,12,13,0,2,5,52,3,300};
        return numeros;
    }

    public static List<Aluno> GetTurmaA()
    {
        List<Aluno> alunos = new()
        {
            new Aluno(){Nome = "Maria",Idade = 36, DataNascimento = new DateTime(2001,6,11)},
            new Aluno(){Nome = "Manoel",Idade = 33, DataNascimento = new DateTime(2000,2,10)},
            new Aluno(){Nome = "Amanda",Idade = 21, DataNascimento = new DateTime(1986,9,30)},
            new Aluno(){Nome = "Carlos",Idade = 18, DataNascimento = new DateTime(1999,10,11)},
            new Aluno(){Nome = "Jaime",Idade = 36, DataNascimento = new DateTime(1988,9,15)}
        };

        return alunos;
    }

    public static List<Aluno> GetTurmaB()
    {
        List<Aluno> alunos = new()
        {
            new Aluno(){Nome = "Homero",Idade = 26, DataNascimento = new DateTime(1988,9,15)},
            new Aluno(){Nome = "Silvia",Idade = 31, DataNascimento = new DateTime(2001,9,30)},
            new Aluno(){Nome = "Felicio",Idade = 21, DataNascimento = new DateTime(1986,9,30)},
            new Aluno(){Nome = "Carlos",Idade = 18, DataNascimento = new DateTime(2002,8,15)},
            new Aluno(){Nome = "Alfredo",Idade = 33, DataNascimento = new DateTime(1999,10,11)},
            new Aluno(){Nome = "Denize",Idade = 30, DataNascimento = new DateTime(2004,11,5)}
        };

        return alunos;
    }
}
