namespace Semana2Dia3Ex3 
{
    public class AnimalWorld : General, IAnimals, IFish, IMammal
    {
        public string Animal1;
        public string Animal2;
        public string Animal3;
        public string Animal4;       

        //Construtor
        public AnimalWorld(string animal1, string animal2, string animal3, string animal4)
        {
            Animal1 = animal1;
            Animal2 = animal2;
            Animal3 = animal3;
            Animal4 = animal4;
        }
        //Contrutor Padrão
        public static void Run()
        {
        }

        static void Main(string[] args)
        {
            Animals.Dice();
            Mammal.DiceMammal();
            Fish.DiceFish();

            Console.WriteLine("enter with an animal:");
            string animal1 = Console.ReadLine();

            Console.WriteLine("enter with an animal:");
            string animal2 = Console.ReadLine();

            Console.WriteLine("enter with an animal:");
            string animal3 = Console.ReadLine();

            Console.WriteLine("enter with an animal:");
            string animal4 = Console.ReadLine();

            var animalWorld1 = new AnimalWorld(animal1, animal2, animal3, animal4);

            Console.WriteLine($"Report:\nAnimal 1 {animalWorld1.Animal1} \nAnimal 2 {animalWorld1.Animal2} \nAnimal 3 {animalWorld1.Animal3} \nAnimal 4 {animalWorld1.Animal4}");
        }
    }
}