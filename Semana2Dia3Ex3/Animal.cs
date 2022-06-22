using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2Dia3Ex3
{
    public class Animals
    {
        //Atributos
        private string Name;
        private int NPaws;
        private string Color;
        private string Environment;
        private int AverageSpeed;

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
            GetName = Console.ReadLine();

            Console.WriteLine("Enter the number of Animals:");
            int nPaws = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the color of Animals:");
            string color = Console.ReadLine();

            Console.WriteLine("Enter the evironemen of Animals:");
            string environment = Console.ReadLine();

            Console.WriteLine("Enter the average speed of Animals:");
            int averageSpeed = int.Parse(Console.ReadLine());
                
            var animals1 = new Animals(Animals.GetName, nPaws, color, environment, averageSpeed);

            Console.WriteLine($"Report:\nAnimal Name:{name} \nNumber of animal's paws: {nPaws} the color of the animal: {color} \nthe animal's environment{environment} \nthe speed of the animal: {averageSpeed}");
        }
    }
}

