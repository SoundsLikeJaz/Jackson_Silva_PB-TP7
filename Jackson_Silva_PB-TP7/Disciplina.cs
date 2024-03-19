namespace Jackson_Silva_PB_TP7
{
    public class Disciplina
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Turma Turma { get; set; }

        public Disciplina(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"{Codigo} - {Nome}";
        }
    }
}
