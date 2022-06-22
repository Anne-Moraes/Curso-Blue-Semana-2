
namespace Semana2Dia3Ex3
{
    public class Animals
    {
        //Atributos
        public string Name { get { return Name; } private set { Name = value; } }
        public int NPaws { get { return NPaws; } private set { NPaws = value; } }
        public string Color { get { return Color; } private set { Color = value; } }
        public string Environment { get { return Environment; } private set { Environment = value; } }
        public int AverageSpeed { get { return AverageSpeed; } private set { AverageSpeed = value; } }

        //Construtor
        public Animals(string name, int nPaws, string color, string environment, int averageSpeed)
        {
            Name = name;
            NPaws = nPaws;
            Color = color;
            Environment = environment;
            AverageSpeed = averageSpeed;
        }
        //Contrutor Padrão
        public Animals()
        {

        }
        //Get Set
        public static void Run()
        {
        }              
        public static void Dice() 
        {
            Console.WriteLine("enter the name of Animals:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the number of Animals:");
            int nPaws = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the color of Animals:");
            string color = Console.ReadLine();

            Console.WriteLine("Enter the evironemen of Animals:");
            string environment = Console.ReadLine();

            Console.WriteLine("Enter the average speed of Animals:");
            int averageSpeed = int.Parse(Console.ReadLine());

            var animals1 = new Animals(name, nPaws, color, environment, averageSpeed);

            Console.WriteLine($"Report:\nAnimal Name:{animals1.Name} \nNumber of animal's paws: {animals1.NPaws} \nthe color of the animal: {animals1.Color} \nthe animal's environment{animals1.Environment} \nthe speed of the animal: {animals1.AverageSpeed}");
        }
    }
}

