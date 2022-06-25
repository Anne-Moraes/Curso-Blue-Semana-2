using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2Dia1Ex2
{
    public class Invoice : Program
    {
        /*Crie uma classe que representa uma fatura para uma loja de suprimentos de informática.
        A classe deve conter os seguintes atributos: número, descrição dos produtos, quantidade 
        comprada de um produto e o preço. A classe deve ter um construtor e um método get e set 
        para cada variável de instância. Além disso, forneça um método para calcular o valor total da fatura.*/

        public int Number { get; private set; }
        public string ProdDescription { get; private set; }
        public int QuantitySold { get; private set; }       
        public double Price { get; private set; }

        //Construtor
        public Invoice(int number, string prodDescription, int quantitySold, double price)
        {
            Number = number;
            ProdDescription = prodDescription;
            QuantitySold = quantitySold;
            Price = price;         
        }
        public override double TotalBill()
        {
            Console.WriteLine("Calculate the total of your Invoice");

            Console.WriteLine("enter a value for Price:");
            Price = double.Parse(Console.ReadLine());

            Console.WriteLine("enter a value for Quantity Sold:");
            QuantitySold = int.Parse(Console.ReadLine());

            return Price + QuantitySold;
        }
    }
}
