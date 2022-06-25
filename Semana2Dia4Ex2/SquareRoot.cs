namespace Semana2Dia4Ex2
{
    public class SquareRoot : Program
    {
        public virtual double Value { get; set; }
       
        public SquareRoot(double value)
        {
            Value = value;           
        }
        public static void Run()
        {
        }
        public override double Total()
        {
            Console.WriteLine("enter a number: ");
            Value = double.Parse(Console.ReadLine());

            return Math.Sqrt(Value);
        }
    }
}