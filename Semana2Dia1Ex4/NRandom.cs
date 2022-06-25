using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2Dia1Ex4
{
    internal class NRandom
    {
        static void Main()
        {
            int computer, attempts, user;
            
            var rand = new Random();

            computer = rand.Next(0, 1001);

            attempts = 0;

            bool gotItRight = false;




            while (gotItRight == false)
            {
                Console.WriteLine($"\n");
                Console.WriteLine("Enter a number for the draw! \nGood luck!");
                
                user = int.Parse(Console.ReadLine());
                

                if (user == computer)
                {
                    Console.WriteLine("Winner!");
                    Console.WriteLine($"your number of attempts: {attempts}");
                }
                else if (user > computer)
                {
                    Console.WriteLine("Almost, your guess was higher");
                }
                else if (user < computer)
                {
                    Console.WriteLine("Almost, your guess was lower");
                }

                attempts++;
            }
        }
    }
}
