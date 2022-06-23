namespace Semana2Dia3Ex3
{
  public class Fish : Animals 
  {
        public string Characteristics;
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
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public int GetNPaws()
        {
            return NPaws;
        }
        public void SetNPawse(int nPaws)
        {
            NPaws = nPaws;
        }
        public string GetColor()
        {
            return Color;
        }
        public void SetColor(string color)
        {
            Color = color;
        }
        public string GetEnvironment()
        {
            return Environment;
        }
        public void SetEnvironment(string environment)
        {
            Environment = environment;
        }
        public string GetCharacteristics()
        {
            return Characteristics;
        }
        public void SetCharacteristics(string characteristics)
        {
            Characteristics = characteristics;
        }
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