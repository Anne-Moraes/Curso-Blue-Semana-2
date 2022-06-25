namespace Semana2Dia4Ex2
{
    public abstract class Program : BaseCalculator
    {

        static void Main(string[] args)
        {
            Addition addition = new Addition(0, 0);
            Subtraction subtraction = new Subtraction(0, 0);
            Multiplication multiplication = new Multiplication(0, 0);
            Division division = new Division(0, 0);
            Potency potency = new Potency(0, 0);
            SquareRoot squareRoot = new SquareRoot(0);


            Console.Title = "Calculator";
            Console.WriteLine("============================ Calculadora ============================ ");
            Console.WriteLine("Enter 1 for Soma");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division");
            Console.WriteLine("Enter 5 for Potency");
            Console.WriteLine("Enter 6 for Square Root");

            string usuario = Console.ReadLine();

            if (usuario == "1")
            {
                Console.WriteLine($"The sum total is {addition.Total()}");
            }
            else if (usuario == "2")
            {
                Console.WriteLine($"The sum total is {subtraction.Total()}");
            }
            else if (usuario == "3")
            {
                Console.WriteLine($"The sum total is {multiplication.Total()}");
            }
            else if (usuario == "4")
            {
                Console.WriteLine($"The sum total is {division.Total()}");
            }
            else if (usuario == "5")
            {
                Console.WriteLine($"The sum total is {potency.Total()}");
            }
            else if (usuario == "6")
            {
                Console.WriteLine($"The sum total is {squareRoot.Total()}");
            }
            else
            {
                Console.WriteLine("You entered an invalid option");
            }

        }
    }
}



















/* double numero, valor1 = 0;
 string valorDigitado;
 bool numeroInteiro;

 valorDigitado = Console.ReadLine();

 //Verifica se é um número
 numeroInteiro = double.TryParse(valorDigitado, out numero);

 //faz a validação
 if (numeroInteiro)
 {
     valor1 = Math.Round(double.Parse(valorDigitado), 4);
 }
 else
 {
     Console.WriteLine("Digite um número válido");
 }

 Console.Title = "Calculadora";
 Console.WriteLine("============================ Calculadora ============================ ");
 Console.WriteLine("Enter 1 for multiplication");
 Console.WriteLine("Enter 2 for division");
 Console.WriteLine("Enter 3 for soma");
 Console.WriteLine("Enter 1 for subtrcion");

 string usuario = Console.ReadLine();


 switch
     { case
         BaseCalculator.Total();*/








/* List<Square> formas = new List<Square>
 {
     new Triangle(0, 0,0),
     new Circle(0 ,0, 0),
     new Shape (0, 0),
     new Rectangle(0, 0, 0)
 };
 foreach (var forma in formas)
 {
     Console.WriteLine($"the area is: {forma.CalcularArea()}");
 }*/


