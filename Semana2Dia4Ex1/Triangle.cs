namespace Semana2Dia4Ex1
{
    public class Triangle : Shapes
    { 
        /*1 - Área das figuras
        Faça um programa que calcule a área de uma figura
        geométrica planas.Aceite quatro tipos de figura 
        geométrica: quadrado, retângulo, triângulo e 
        círculo.Utilize as fórmulas abaixo para chegar
        na área das figuras planas.*/

        public double AreaT;
        public double BTriangle;
        public double HeightT;


        //Construtor
        public Triangle(double areaT, double bTriangle, double heightT)
        {
            AreaT= areaT;
            BTriangle = bTriangle;
            HeightT = heightT;
        }
        //Contrutor Padrão
        public Triangle()
        {

        }
        public static void Run()
        {
        }
        public virtual void CalTriangle()
        {
            /*Console.WriteLine("Enter the average speed of Fish:");
            double cAreaT = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the average speed of Fish:");
            double cBTriangleT = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the average speed of Fish:");
            double cHeightT = double.Parse(Console.ReadLine());*/

            Console.WriteLine("a");

            
            //var triangleT = new Triangle(AreaT, BTriangleT, HeightT);

            //Console.WriteLine($"\nThe Base of the triangle is {BTriangle} \nThe Height of the Triangle is {HeightT} \nThe area of the triangle is {AreaT}");
        }

    }
    
}
