namespace Semana2Dia4Ex1
{
    abstract class Circle : Shapes
    {
        /*1 - Área das figuras
        Faça um programa que calcule a área de uma figura
        geométrica planas.Aceite quatro tipos de figura 
        geométrica: quadrado, retângulo, triângulo e 
        círculo.Utilize as fórmulas abaixo para chegar
        na área das figuras planas.*/

        public int Area;
        public int Constant;
        public int Radius;


        //Construtor
        public Circle(int area, int constant, int radius)
        {
            Area = area;
            Constant = constant;
            Radius = radius;
        }
        //Contrutor Padrão
        public Circle()
        {

        }
        public static void Run()
        {
        }

    }
}
