
namespace Semana2Dia2Ex1 
{
    internal class Enunciado
    {  
        // dois construtores, atributos privados, get set, private, herança 
        /*
        Vamos modelar um cadastro de animais de uma pet-shop? 
        Crie uma classe que modele os animais e contenha como atributos nome, espécie, cor, idade, observação e dados do dono. 
        Os atributos relacionados ao dono do animal deve ser privados para proteção de dados. 
        Forrneça métodos para cadastro e leitura das informações.
        */      

        //Metodos    
    }
    public class Pet
    { 
        //Atributos Públicos
        public string NomePet;
        public string Especie;
        public string Raça;
        public int Idade;
        public string Cor;
        public string Porte;
        public string Tutor;
        public string Observacao;

        public Pet(string nomePet, string especie, string raça, int idade, string cor, string porte, string tutor, string observacao)

        {
            NomePet = nomePet;
            Especie = especie;
            Raça = raça;
            Idade = idade;
            Cor = cor;
            Porte = porte;
            Tutor = tutor;
            Observacao = observacao;           
        }
        public void Cadastrar()
        {        
            Console.WriteLine($"Os dados do seu Pet são \nNome: {NomePet} \nEspecie: {Especie} \nRaça: {Raça} \nIdade: {Idade} \nCor: {Cor} \nPorte: {Porte} \nTutor {Tutor} \nObservações: {Observacao}");
        }
        
    }
    public class Tutor
    {
        //Atributos Privados
        private string Nome;           
        private int Telefone;
        private int Documento;
        private string DataDeNascimento;

        public Tutor(string nome, int telefone, int documento, string dataDeNascimento)
        {
            Nome = nome;               
            Telefone = telefone;
            Documento = documento;
            DataDeNascimento = dataDeNascimento;

        }
        public void CadastrarTutor()
        {
            Console.WriteLine($"Os dados do Tutor são \nNome: {Nome} \nTelefone: {Telefone} \nDocumento: {Documento} \nData de Nascimento: {DataDeNascimento}"); 
        }
    }
}
