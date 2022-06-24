namespace Semana2Dia4Ex1
{
    public class Shape : Square
    {
        /*1 - Área das figuras
        Faça um programa que calcule a área de uma figura
        geométrica planas.Aceite quatro tipos de figura 
        geométrica: quadrado, retângulo, triângulo e 
        círculo.Utilize as fórmulas abaixo para chegar
        na área das figuras planas.*/

        public double Side { get; private set; }        
        public Shape(double area, double side) : base(area)
        {
           Side = side;
        }
        public static void Run()
        {
        }

        //Construtor

        public override double CalcularArea()
        {
            Console.WriteLine("Calculate the area of your Shape");

            Console.WriteLine("enter a number for Side:");
            Side = double.Parse(Console.ReadLine());

            return Side * Side;
        }

    }

}
