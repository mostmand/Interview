﻿using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var ageCalculator = new AgeCalculator();
            var age = ageCalculator.CalculateAge(new DateTime(1999, 1, 1));
            Console.WriteLine(age);
        }
    }
}