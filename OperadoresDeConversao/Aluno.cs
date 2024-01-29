namespace OperadoresDeProjecao;

public class Aluno
{
    public string Nome { get; set; }
    public byte Idade { get; set; }
    public byte Nota { get; set; }
    public List<string> Cursos { get; set; } = new List<string>();
}
