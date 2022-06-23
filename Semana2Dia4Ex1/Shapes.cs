using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2Dia4Ex1
{
    public class Shapes : Shapes1, ITriangle, ISquare, IRectangle, ICircle 
    {
        
        static void Main(string[] args)
        {
            public override void CalTriangle()
            {
            }

        }

    }
    }
    public interface IShapes
    {

    }
    public interface ITriangle : IShapes
    {
    }
    public interface ISquare : IShapes
    {
    }
    public interface IRectangle : IShapes
    {

    }
    public interface ICircle : IShapes
    {
    }
    public class Shapes1 : IShapes
    {
    }
}
