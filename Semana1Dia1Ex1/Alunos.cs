namespace Semana2Dia1Ex1
{

    public class Alunos 
    {
        /*@"
        Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina. 
        Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome, 2 notas de prova e 1 nota de trabalho. 
        Escreva os seguintes métodos para esta classe:
            Calcular média: calcula e exibe a média final do aluno com base em suas notas;
            Calculo nota final: calcula quanto o aluno precisa tirar na prova final para ser aprovado."*/

        //Atributos
        public string Nome = "";
        public double Matricula = 0;
        public double Nota1 = 0;
        public double Nota2 = 0;
        public double Trabalho = 0;



        //Metodos
        public double MediaFinal()
        {            
            double media = (Nota1 + Nota2 + Trabalho) / 3;
            return media;
        }

        public double ProvaFinal()
        {            
           double prova = MediaFinal() - 10;
            
            if (prova > 0)
                return prova;
            else
                return prova * (-1);
        }
    }
}
