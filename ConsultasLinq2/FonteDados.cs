namespace ConsultasLinq2;

public class FonteDados
{
    public static List<int> GetNumeros()
    {
        List<int> numeros = new List<int>() 
        {
            1,2,4,8,16,32,64,128,256,512
        };

        return numeros;
    }

    public static List<int> GetListaNegra()
    {
        List<int> numeros = new List<int>()
        {
            16,128,512
        };

        return numeros;
    }

    //public static string[] GetPaises()
    //{

    //}

    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new List<Aluno>()
        {
            new Aluno("Maria",42),
            new Aluno("Manoel",34),
            new Aluno("Amanda",21),
            new Aluno("Carlos",18),
            new Aluno("Alicia",15)
        };

        return alunos;
    }
}
