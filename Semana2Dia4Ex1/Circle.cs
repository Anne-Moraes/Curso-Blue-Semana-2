namespace Semana2Dia4Ex1
{
    public class Circle : Square
    {
        /*1 - Área das figuras
        Faça um programa que calcule a área de uma figura
        geométrica planas.Aceite quatro tipos de figura 
        geométrica: quadrado, retângulo, triângulo e 
        círculo.Utilize as fórmulas abaixo para chegar
        na área das figuras planas.*/
        
        public double Constant;
        public double Radius;


        //Construtor
        public Circle(double area, double constant, double radius) : base(area)
        {        
            Constant = constant;
            Radius = radius;
        }
        //Contrutor Padrão       
        public static void Run()
        {
        }
        public override double CalcularArea()
        {
            Constant = 3.14;

            Console.WriteLine("Calculate the area of your Circle");

            Console.WriteLine("enter a number for Radius:");
            Radius = double.Parse(Console.ReadLine());

            return Constant * (Radius * Radius);
        }

    }
}
