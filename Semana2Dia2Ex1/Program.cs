using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2Dia1Ex2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o Nome do pet:");
            string nomePet = Console.ReadLine();

            Console.WriteLine("Digite a Especie do pet:");
            string especie = Console.ReadLine();

            Console.WriteLine("Digite a Raça do pet:");
            string raca = Console.ReadLine();

            Console.WriteLine("Digite a Idade do pet:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a cor do pet:");
            string cor = Console.ReadLine();

            Console.WriteLine("Digite o Porte do pet:");
            string porte = Console.ReadLine();

            Console.WriteLine("Digite o Nome do Tutor do Pet");
            string tutor = Console.ReadLine();

            Console.WriteLine("Alguma observação?");
            string observacao = Console.ReadLine();

            string nomepet = Console.ReadLine();
            Pet pet1 = new Pet(nomePet, especie, raca, idade, cor, porte, tutor, observacao);
                       
            pet1.Cadastrar();

            Console.WriteLine("Digite o Nome do Tutor:");
            string nomeTutor = Console.ReadLine();

            Console.WriteLine("Digite o Telefone  do Tutor:");
            int telefone = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Documento  do Tutor:");
            int documento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Data de Nascimento do Tutor:");
            string dataNascimento = Console.ReadLine();

            Tutor tutor1 = new Tutor(nomeTutor, telefone, documento, dataNascimento);

            tutor1.CadastrarTutor();











        }
    }
}