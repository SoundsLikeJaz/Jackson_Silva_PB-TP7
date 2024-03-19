namespace Jackson_Silva_PB_TP7
{
    public class Turma
    {
        public int Codigo { get; set; }
        private bool aberta;

        private List<Aluno> alunos = new List<Aluno>();
        private Disciplina disciplina;
        private Professor professor;

        public Turma(int codigo)
        {
            Codigo = codigo;
        }

        public void addAluno(Aluno aluno)
        {
            if(alunos.Contains(aluno)) throw new Exception("Aluno já matriculado");
            else if (alunos.Count > 10) throw new Exception("Turma cheia");
            else alunos.Add(aluno);
        }

        public string listarAlunos()
        {
            string lista = "";
            foreach (Aluno aluno in alunos)
            {
                lista += $"{aluno}\n";
            }
            return lista;
        }

        public Disciplina Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }

        public Professor Professor
        {
            get { return professor; }
            set { professor = value; }
        }

        public bool abrirTurma()
        {
            if (alunos.Count >= 2) return true;
            else return false;
        }

        public string gerarPauta()
        {
            return $"Código: {Codigo}, Disciplina: {Disciplina}, Professor: {Professor}\n" +
                $"Lista de Alunos:\n{listarAlunos()}";
        }
    }
}
