namespace Semana2Dia4Ex2
{
    public class Potency : Program
    {
        public virtual double Value1 { get; set; }
        public virtual double Value2 { get; set; }

        public Potency(double value1, double value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
        public static void Run()
        {
        }
        public override double Total()
        {
            Console.WriteLine("enter a number: ");
            Value1 = double.Parse(Console.ReadLine());

            Console.WriteLine("enter a number for Potency:");
            Value2 = double.Parse(Console.ReadLine());

            return Math.Pow(Value1, Value2);
        }
    }
}
