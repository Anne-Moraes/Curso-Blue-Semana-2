namespace Semana2Dia1Ex2
{ 
    internal class Program
    {
        static void Main()
        {
            //Como eu faço para o úsuario passar os parametros?
            
            Console.WriteLine("Digite o Nome do empregado:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o cargo do empregado:");
            string cargo = Console.ReadLine();

            Console.WriteLine("Digite o salário do empregado");
            double salario = double.Parse(Console.ReadLine());

            Empregado empregado1 = new Empregado(nome, cargo, salario);

            empregado1.Imprimir();

            empregado1.SalarioNegativo();

            empregado1.Aumento();
        }
    }
}
