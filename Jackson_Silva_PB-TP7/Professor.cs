namespace Jackson_Silva_PB_TP7
{
    public class Professor
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public Turma Turma { get; set; }

        public Professor(int matricula, string nome)
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
