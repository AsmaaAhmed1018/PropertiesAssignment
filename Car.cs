using System;

namespace PropertiesAssignment
{
    internal class Car
    {
        public int Make { get; set; }
        public int Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; } = 0;
        public void Drive(int distance)
        {
            if (distance > 0)
            {
                Mileage += distance;
            }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                age = DateTime.Now.Year - Year;
            }
        }
        public Car()
        {
            Year = 2012;
        }
    }
}
