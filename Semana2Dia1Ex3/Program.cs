namespace Semana2Dia1Ex2
{
    public abstract class Program: Bill
    {
        static void Main()
        {
            List<Program> bills = new List<Program>
            {
                new Invoice(0, "", 0,0),                
            };
            foreach (var bill in bills)
            {
                Console.WriteLine($"the total invoice is: {bill.TotalBill()}");
            }
        }
    }
}
