namespace Semana2Dia4Ex1
{
    abstract class Triangle
    { 
        /*1 - Área das figuras
        Faça um programa que calcule a área de uma figura
        geométrica planas.Aceite quatro tipos de figura 
        geométrica: quadrado, retângulo, triângulo e 
        círculo.Utilize as fórmulas abaixo para chegar
        na área das figuras planas.*/

        public double AreaT;
        public double BTriangleT;
        public double HeightT;


        //Construtor
        public Triangle(double areaT, double bTriangleT, double heightT)
        {
            AreaT= areaT;
            BTriangleT = bTriangleT;
            HeightT = heightT;
        }
        //Contrutor Padrão
        public Triangle()
        {

        }
        public static void Run()
        {
        }
        public static void CalTriangle()
        {
            Console.WriteLine("Enter the average speed of Fish:");
            double cAreaT = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the average speed of Fish:");
            double cBTriangleT = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the average speed of Fish:");
            double cHeightT = double.Parse(Console.ReadLine());

            double areaTriangle = (cBTriangleT * cHeightT) / 2;

            
            var triangleT = new Triangle(cAreaT, cBTriangleT, cHeightT);

            Console.WriteLine($"\nThe Base of the triangle is {BTriangleT} \nThe Height of the Triangle is {HeightT} \nThe area of the triangle is {AreaT}");
        }

    }
    public interface IGeneral
    {

    }
    public interface ITriangle : IGeneral
    {
    }
    public interface ISquares : IGeneral
    {
    }
    public interface IRectangle : IGeneral
    {

    }
    public interface ICircle : IGeneral
    {
    }
    public class General : IGeneral
    {
    }
}
