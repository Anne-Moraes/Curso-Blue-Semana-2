namespace Semana2Dia1Ex2
{
    internal class Program
    {
        static void Main()
        {
            //Como eu faço para o úsuario passar os parametros?
            Console.WriteLine("Digite o nome, o cargo e o salário do empregado (nessa ordem):");

            Empregado empregado1 = new Empregado(Console.ReadLine(), Console.ReadLine(), double.Parse(Console.ReadLine()));

            //empregado1.Aumento();
            //Console.WriteLine(empregado1.Aumento());

            empregado1.Imprimir();

            empregado1.SalarioNegativo();

            empregado1.SalarioNegativo();
        }
    }
}