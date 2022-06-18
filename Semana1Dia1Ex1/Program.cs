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
            aluno.Matricula = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota da primeira prova do aluno?");
            aluno.Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota da segunda prova do aluno?");
            aluno.Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota de trabalho do aluno?");
            aluno.Trabalho = double.Parse(Console.ReadLine());

            Console.WriteLine($" A matricula do aluno é: {aluno.Matricula.ToString("F2")} \nA nota da primeira prova do aluno é: {aluno.Nota1.ToString("F2")} \nA nota da segunda prova do aluno é: {aluno.Nota2.ToString("F2")} \nA nota de trabalho do aluno é: {aluno.Trabalho.ToString("F2")}");

            Console.WriteLine($"A Media final do aluno é {aluno.MediaFinal().ToString("F2")}");

            Console.WriteLine($"A nota na prova final para o resutado máximo é: {aluno.ProvaFinal().ToString("F2")}");
 
        }
    }
}
