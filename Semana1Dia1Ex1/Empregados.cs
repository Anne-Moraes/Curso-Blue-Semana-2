namespace Semana2Dia1Ex2
{

    public class Empregado 
    {

        /*
        2. Gerenciando Salários
        A fim de representar empregados em uma empresa, crie uma classe chamada Empregado que inclui os seguintes atributos; 
        nome, cargo e salário mensal.
        Sua classe deve ter um construtor que inicializa os três atributos e também fornecer métodos que executem as seguintes ações:
        Se o salário mensal não for positivo, configure-o como 0.0.
        Conceder aumento de salários a seus funcionários de acordo com os dados abaixo: Salário de 0 até 400.00 ganha 15% Salário 
        de 400.01 até 800.00 ganha 12% Salário de 800.01 até 1200.00 ganha 10% Salário de 1200.01 até 2000.00 ganha 7% 
        Acima de 2000.00 ganha 4%
        Imprimir o salário de um funcionário.
        */

        //Atributos
        public string Nome;
        public string Cargo;
        public double SalarioMensal;
       

        //Construtor
        public Empregado(string nome, string cargo, double salarioMensal)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioMensal = salarioMensal;            
        }


        //Metodos

        public void Imprimir()
        {          
            Console.WriteLine($"Nome = {Nome} \nCargo = {Cargo} \nSalário Mensal = {SalarioMensal}");            
        }
        public void SalarioNegativo()
        {
            if (SalarioMensal < 0)
            {
              double zerar =  SalarioMensal * -0;
                Console.WriteLine(zerar);
            }
            
        }

        public void Aumento()
        {
           

            if (SalarioMensal == 0 || SalarioMensal <= 400.00)
            {
                double reajuste, novoSalario;
                reajuste = 0.15;
                novoSalario = SalarioMensal * reajuste + SalarioMensal;

                Console.WriteLine($"Seu salário é de: {SalarioMensal} \nSeu novo salario é de: {novoSalario} \nSeu reajuste foi de: 15%");

            }
            else if (SalarioMensal <= 800.00)
            {
                double reajuste, novoSalario;
                reajuste = 0.12;
                novoSalario = SalarioMensal * reajuste + SalarioMensal;

                Console.WriteLine($"Seu salário é de: {SalarioMensal} \nSeu novo salario é de: {novoSalario} \nSeu reajuste foi de: 12%");
            }
            else if (SalarioMensal <= 1200.00)
            {
                double reajuste, novoSalario;
                reajuste = 0.10;
                novoSalario = SalarioMensal * reajuste + SalarioMensal;

                Console.WriteLine($"Seu salário é de: {SalarioMensal} \nSeu novo salario é de: {novoSalario} \nSeu reajuste foi de: 10%");
            }
            else if (SalarioMensal <= 2000.00)
            {
                double reajuste, novoSalario;
                reajuste = 0.7;
                novoSalario = SalarioMensal * reajuste + SalarioMensal;

                Console.WriteLine($"Seu salário é de: {SalarioMensal} \nSeu novo salario é de: {novoSalario} \nSeu reajuste foi de: 7%");
            }
            else if (SalarioMensal > 2000.01)
            {
                double reajuste, novoSalario;
                reajuste = 0.4;
                novoSalario = SalarioMensal * reajuste + SalarioMensal;

                Console.WriteLine($"Seu salário é de: {SalarioMensal} \nSeu novo salario é de: {novoSalario} \nSeu reajuste foi de: 4%");
            }
            else;
            
        }
    }
}
