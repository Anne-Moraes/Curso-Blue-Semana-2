namespace Semana2Dia4Ex1
{
    abstract class Rectangle
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

    }
}

