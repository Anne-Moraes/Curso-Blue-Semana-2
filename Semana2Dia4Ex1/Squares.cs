namespace Semana2Dia4Ex1
{
    public class Square : Triangle
    {
        /*1 - Área das figuras
        Faça um programa que calcule a área de uma figura
        geométrica planas.Aceite quatro tipos de figura 
        geométrica: quadrado, retângulo, triângulo e 
        círculo.Utilize as fórmulas abaixo para chegar
        na área das figuras planas.*/

        public int Area;
        public int Side;


        //Construtor
        public Square(int area, int side)
        {
            Area = area;
            Side = side;
        }
        //Contrutor Padrão
        public Square()
        {

        }
        public static void Run()
        {
        }    
    }
}
