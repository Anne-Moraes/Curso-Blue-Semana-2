namespace Semana2Dia3Ex3
{
  public class Fish : Animals 
  {
        public string Characteristics { get; private set; }
        public Fish(string name, int nPaws, string color, string environment, int averageSpeed, string characteristics) : base(name, nPaws, color, environment, averageSpeed)
        {
            Characteristics = characteristics;
}
        public Fish()
        {

        }       
        public static void Run()
        {
        }
        //Get Set
        
        public static void DiceFish()
        {
            Console.WriteLine("enter the name of Fish:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the number of Fish:");
            int nPaws = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the color of Fish:");
            string color = Console.ReadLine();

            Console.WriteLine("Enter the evironemen of Fish:");
            string environment = Console.ReadLine();

            Console.WriteLine("Enter the average speed of Fish:");
            int averageSpeed = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the average speed of Fish:");
            string characteristics = Console.ReadLine();

            var fish1 = new Fish(name, nPaws, color, environment, averageSpeed, characteristics);

            Console.WriteLine($"Report:\nFish Name:{fish1.Name} \nNumber of Fish's paws: {fish1.NPaws} \nthe color of the Fish: {fish1.Color} \nthe Fish's environment{fish1.Environment} \nthe speed of the Fish: {fish1.AverageSpeed}, Fish characteristics {fish1.Characteristics}");
        }
    }
}