namespace Semana2Dia4Ex2
{
    public class Addition : Program
    {
        public virtual double Value1 { get; set; }
        public virtual double Value2 { get; set; }

        public Addition(double value1, double value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
        public static void Run()
        {
        }
        
        public override double Total()
        {
            Console.WriteLine("enter a number for Addition: ");
            Value1 = double.Parse(Console.ReadLine());

            Console.WriteLine("enter a number for Addition:");
            Value2 = double.Parse(Console.ReadLine());

            return Value1 + Value2;
        }
    }
}
