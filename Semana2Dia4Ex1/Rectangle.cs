namespace Semana2Dia4Ex1
{
    public class Rectangle : Triangle
    {
        /*1 - Área das figuras
        Faça um programa que calcule a área de uma figura
        geométrica planas.Aceite quatro tipos de figura 
        geométrica: quadrado, retângulo, triângulo e 
        círculo.Utilize as fórmulas abaixo para chegar
        na área das figuras planas.*/

        public int Area;
        public int BRectangle;
        public int Height;


        //Construtor
        public Rectangle(int area, int bRectangle, int height)
        {
            Area = area;
            BRectangle = bRectangle;
            Height = height;
        }
        //Contrutor Padrão
        public Rectangle()
        {

        }
        public static void Run()
        {
        }
        public virtual void CalRectangle()
        {
            /*Console.WriteLine("Enter the average speed of Fish:");
            double cAreaT = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the average speed of Fish:");
            double cBTriangleT = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the average speed of Fish:");
            double cHeightT = double.Parse(Console.ReadLine());*/

            return((BTriangle * HeightT) / 2);


            //var triangleT = new Triangle(AreaT, BTriangleT, HeightT);

            //Console.WriteLine($"\nThe Base of the triangle is {BTriangle} \nThe Height of the Triangle is {HeightT} \nThe area of the triangle is {AreaT}");
        }

    }
}

