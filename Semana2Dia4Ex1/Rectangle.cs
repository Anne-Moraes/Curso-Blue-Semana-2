namespace Semana2Dia4Ex1
{
    public class Rectangle : Square
    {
        /*1 - Área das figuras
        Faça um programa que calcule a área de uma figura
        geométrica planas.Aceite quatro tipos de figura 
        geométrica: quadrado, retângulo, triângulo e 
        círculo.Utilize as fórmulas abaixo para chegar
        na área das figuras planas.*/
        
        public double BRectangle { get; private set; }
        public double Height { get; private set; }


        //Construtor
        public Rectangle(int area, int bRectangle, int height) : base(area)
        {        
        BRectangle = bRectangle;
        Height = height;
        }
    //Contrutor Padrão
        public static void Run()
        {
        }
        public override double CalcularArea()
        {
            Console.WriteLine("Calculate the area of your Rectangle:");

            Console.WriteLine("enter a number for: Base");
            BRectangle = double.Parse(Console.ReadLine());

            Console.WriteLine("enter a number for Height:");
            Height = double.Parse(Console.ReadLine());

            return BRectangle * Height;            
        }
    
    }
}

