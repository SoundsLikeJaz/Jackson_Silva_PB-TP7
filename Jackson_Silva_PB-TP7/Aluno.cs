namespace Jackson_Silva_PB_TP7
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public Turma Turma { get; set; }

        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"{Matricula} - {Nome}";
        }
    }
}
