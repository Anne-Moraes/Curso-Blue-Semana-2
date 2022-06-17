namespace Semana1Dia1Ex1
{
    public class Dia1Ex1
    {
        /*@"
        Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina. 
        Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome, 2 notas de prova e 1 nota de trabalho. 
        Escreva os seguintes métodos para esta classe:
            Calcular média: calcula e exibe a média final do aluno com base em suas notas;
            Calculo nota final: calcula quanto o aluno precisa tirar na prova final para ser aprovado."*/

        //Atributos
        public string Nome = "";
        public int Matricula = 0;   
        public int Nota1 = 0;
        public int Nota2 = 0;
        public int Trabalho = 0;



        //Metodos
        public void MediaFinal()
        {
            int media;
            media = (Nota1 + Nota2 + Trabalho) / 3;
           
        }

        public void ProvaFinal()
        {
            int prova;
            prova = (Nota1 + Nota2 + Trabalho) - 10;

        }
    }
    class Alunos : Dia1Ex1
    {

    }
}
