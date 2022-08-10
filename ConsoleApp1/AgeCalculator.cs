using System;

namespace ConsoleApp1
{
    public class AgeCalculator
    {
        public int CalculateAge(DateTime dateOfBirth)
        {
            var now = DateTime.UtcNow;
            var difference = now - dateOfBirth;
            return difference.Days / 365;
        }
    }
}
