namespace Semana2Dia3Ex3
{
    public class Mammal : Animals 
    {
        public string Food;
        public Mammal(string name, int nPaws, string color, string environment, int averageSpeed, string food) : base(name, nPaws, color, environment, averageSpeed)
        {
            Food = food;
        }
        //Get Set
        public string GetName()
        {
            return Name;
        }
        public void SetName (string name)
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
        public string GetFood()
        {
            return Food;
        }
        public void SetFood(string food)
        {
            Food = food;
        }

        public static void DiceMammal()
        {
            Console.WriteLine("enter the name of Mammal:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the number of Mammal:");
            int nPaws = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the color of Mammal:");
            string color = Console.ReadLine();

            Console.WriteLine("Enter the evironemen of Mammalh:");
            string environment = Console.ReadLine();

            Console.WriteLine("Enter the average speed of Mammal:");
            int averageSpeed = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the average speed of Mammal:");
            string food = Console.ReadLine();

            var mammal1 = new Mammal(name, nPaws, color, environment, averageSpeed, food);

            Console.WriteLine($"Report:\nMammal1 Name:{mammal1.Name} \nNumber of mammal1's paws: {mammal1.NPaws} \nthe color of the mammal1: {mammal1.Color} \nthe mammal1's environment{mammal1.Environment} \nthe speed of the mammal1: {mammal1.AverageSpeed}, \nmammal1 characteristics {mammal1.Food}");
        }
    }
    


}
