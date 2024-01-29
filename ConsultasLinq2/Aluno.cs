namespace ConsultasLinq2;

public class Aluno
{
    public string Nome { get; set; }
    public byte Idade { get; set; }
    public byte Nota { get; set; } = 7;

    public Aluno()
    {
        
    }

    public Aluno(string nome, byte idade, byte nota = 7)
    {
        Nome = nome;
        Idade = idade;
    }
}
