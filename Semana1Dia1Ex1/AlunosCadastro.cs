namespace Semana1Dia1Ex1
{
    public class AlunosCadastro : Dia1Ex1
    {
        static void Main(string[] args)
        {
            Alunos aluno = new Alunos();

            aluno.Nome = Console.ReadLine();
            aluno.Matricula = int.Parse(Console.ReadLine());
            aluno.Nota1 = int.Parse(Console.ReadLine());
            aluno.Nota2 = int.Parse(Console.ReadLine());
            aluno.Trabalho = int.Parse(Console.ReadLine());

            aluno.ProvaFinal();

            Console.WriteLine(aluno.ProvaFinal);


        }

    }
}
