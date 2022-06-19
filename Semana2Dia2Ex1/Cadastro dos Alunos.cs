
namespace Semana2Dia1Ex2 
{
    private class Cadastro
    {

        /*
        @"Desenvolva um programa de contas com login e senha privados. 
        Além disso criptogafe esta senha para que ela fique muito segura.
        Além do método construtor, implemente os seguintes métodos
        Criação de conta;
        Alterar a senha;
        Entrar no Sistema: Neste método o usuário deve digitar seu usuário e depois sua senha. 
        A classe de contas deve validar se este usuário existe, caso não exista exiba:
        Este usuário não existe!
        Caso o usuário exista e a senha esteja errada:
        Senha incorreta!
        Caso usuário e senha estejam corretos exiba:
        Bem vindo ao sistema!
        */

        //Atributos
        public string Nome;
        public string Cargo;
        public double SalarioMensal;


        //Construtor
        public(string nome, string cargo, double salarioMensal)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioMensal = salarioMensal;
        }


        //Metodos

        public string Imprimir()
        {
            Console.WriteLine($" Nome = {Nome} \nCargo = {Cargo} \n Salário Mensal = {SalarioMensal}");
            return Imprimir();
        }
    } 
}
