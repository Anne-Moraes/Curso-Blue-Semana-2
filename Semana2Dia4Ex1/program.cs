namespace Semana2Dia4Ex1
{
    public abstract class Square : Form
    { 
        /*1 - Área das figuras
        Faça um programa que calcule a área de uma figura
        geométrica planas.Aceite quatro tipos de figura 
        geométrica: quadrado, retângulo, triângulo e 
        círculo.Utilize as fórmulas abaixo para chegar
        na área das figuras planas.*/

        public double Area;
        //Construtor

        protected Square(double area)
        {
            Area = area;
        }

        public double getArea()
        {
            return this.Area;
        }

        public double SetArea(double value) => this.Area = value;
        static void Main(string[] args)
        {
            List<Square> formas = new List<Square>
            {
                new Triangle(0, 0,0),
                new Circle(0 ,0, 0),
                new Shape (0, 0),
                new Rectangle(0, 0, 0)
            };
            foreach (var forma in formas)
            {
                Console.WriteLine($"the area is: {forma.CalcularArea()}");
            }


        }
    }
}
