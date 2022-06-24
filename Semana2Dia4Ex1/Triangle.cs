namespace Semana2Dia4Ex1
{
    public class Triangle : Square
    {
        /*1 - Área das figuras
        Faça um programa que calcule a área de uma figura
        geométrica planas.Aceite quatro tipos de figura 
        geométrica: quadrado, retângulo, triângulo e 
        círculo.Utilize as fórmulas abaixo para chegar
        na área das figuras planas.*/

        public double BTriangle { get; private set; }
        public double HeightT { get; private set; } 
        public Triangle(double area, double bTriangle, double heightT) : base(area)
        {

            HeightT = heightT;
            BTriangle = bTriangle;
        }
        public static void Run()
        {
        }

        //Construtor

        public override double CalcularArea()
        {
            Console.WriteLine("Calculate the area of your Triangle:");
           
            Console.WriteLine("enter a number for: Base");
            BTriangle = double.Parse(Console.ReadLine());

            Console.WriteLine("enter a number for Height:");
            HeightT = double.Parse(Console.ReadLine());
            
            return (BTriangle * HeightT) / 2;
        }

    }
    
}
