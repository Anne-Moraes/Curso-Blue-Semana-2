namespace Semana2Dia3Ex3
{
    internal class Fish : Animals
    {
        private string Features;
        public Fish(string name, int nPaws, string color, string environment, int averageSpeed, string features) : base(name, nPaws, color, environment, averageSpeed)
        {
            Features = features;
        }
        //public static void


        //Get Set
        /*public static void PrintOut()
        {

        }*/
        //public string GetFeatures()
        /*{
            return Features;
        }*/
    public void SetFeatures(string features)
    {
        Features = features;
    }
    public static void DiceFish()
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

        Console.WriteLine($"Report:\nAnimal Name:{name} \nNumber of animal's paws: {nPaws} the color of the animal: {color} \nthe animal's environment{environment} \nthe speed of the animal: {averageSpeed}");
    }
    }
}
