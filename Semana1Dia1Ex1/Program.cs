using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2Dia1Ex1
{
    internal class Program
    {
        static void Main()
        {
            Alunos aluno = new Alunos();

            Console.WriteLine("Qual o nome do aluno?");
            string nomeDoAluno = Console.ReadLine();

            Console.WriteLine("Qual o número da matrícula?");
            aluno.Matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota da primeira prova do aluno?");
            aluno.Nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota da segunda prova do aluno?");
            aluno.Nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota de trabalho do aluno?");
            aluno.Trabalho = int.Parse(Console.ReadLine());

            Console.WriteLine($" A matricula do aluno é: {aluno.Matricula} \nA nota da primeira prova do aluno é: {aluno.Nota1} \nA nota da segunda prova do aluno é: {aluno.Nota2} \nA nota de trabalho do aluno é: {aluno.Trabalho}");

            Console.WriteLine($"A Media final do aluno é {aluno.MediaFinal()}");

            Console.WriteLine($"A nota na prova final precisa ser no minimo {aluno.ProvaFinal()}");
         

            


        }
    }
}
