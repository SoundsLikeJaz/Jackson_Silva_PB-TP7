using Jackson_Silva_PB_TP7;

Aluno aluno = new Aluno(1, "Jackson");
Aluno aluno2 = new Aluno(2, "Luis");
Aluno aluno3 = new Aluno(3, "Paulo");
Aluno aluno4 = new Aluno(4, "Silva");
Aluno aluno5 = new Aluno(5, "Luis Paulo");
Aluno aluno6 = new Aluno(6, "Jackson Silva");
Aluno aluno7 = new Aluno(7, "Jackson Luis");
Aluno aluno8 = new Aluno(8, "Silva Paulo");
Aluno aluno9 = new Aluno(9, "Luis Silva");
Aluno aluno10 = new Aluno(10, "Paulo Luis");

Disciplina disciplina = new Disciplina(1, "Projeto de Bloco");

Professor professor = new Professor(1, "Luis Paulo");

Turma turma = new Turma(1);
Console.WriteLine(turma.gerarPauta());

turma.Disciplina = disciplina;
Console.WriteLine(turma.gerarPauta());

turma.Professor = professor;
Console.WriteLine(turma.gerarPauta());

turma.addAluno(aluno);

Console.WriteLine(turma.gerarPauta());
Console.WriteLine(turma.abrirTurma() ? "Turma aberta" : "Turma fechada");

turma.addAluno(aluno2);
turma.addAluno(aluno3);
turma.addAluno(aluno4);
turma.addAluno(aluno5);
turma.addAluno(aluno6);
turma.addAluno(aluno7);
turma.addAluno(aluno8);
turma.addAluno(aluno9);
turma.addAluno(aluno10);

Console.WriteLine(turma.gerarPauta());

Console.WriteLine(turma.abrirTurma() ? "Turma aberta" : "Turma fechada");
