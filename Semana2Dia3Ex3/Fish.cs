namespace Semana2Dia3Ex3
{
    internal class Fish : Animals
    {
        private string Features;
        public Fish(string name, int nPaws, string color, string environment, int averageSpeed, string features) : base(name, nPaws, color, environment, averageSpeed)
        {
            Features = features;
        }
        public void SetFeatures(string features)
        {
            Features = features;
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

            var animals1 = new Animals(name, nPaws, color, environment, averageSpeed);

            Console.WriteLine($"Report:\nAnimal Name:{animals1.GetName} \nNumber of animal's paws: {animals1.GetNPaws} \nthe color of the animal: {animals1.GetColor} \nthe animal's environment{animals1.GetEnvironment} \nthe speed of the animal: {animals1.GetNAverageSpeed}");
        }
    }
}