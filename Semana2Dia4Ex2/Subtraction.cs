﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2Dia4Ex2
{
    public class Subtraction : Program
    {

        public virtual double Value1 { get; set; }
        public virtual double Value2 { get; set; }

        public Subtraction(double value1, double value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
        public static void Run()
        {
        }
        public override double Total()
        {
            Console.WriteLine("enter a number for Subtraction: ");
            Value1 = double.Parse(Console.ReadLine());

            Console.WriteLine("enter a number for Subtraction:");
            Value2 = double.Parse(Console.ReadLine());

            return Value1 - Value2;
        }
    }
}
