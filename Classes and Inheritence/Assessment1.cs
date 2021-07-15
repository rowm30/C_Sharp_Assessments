using System;

namespace CI
{
    public class Assessment1
    {
        public static void Main(String[] args)
        {
            var Scorpio = new Car();

            Scorpio.CarMaker = "Mahindra";
            Scorpio.MfgYear = "2022";
            Scorpio.CarModel = "Scorpio";
            Scorpio.City = "Mumbai";

            Scorpio.DisplayCar();
        }
    }

    public class Car
    {
        public string CarMaker;
        public string MfgYear;
        public string CarModel;
        public string City;

        public void DisplayCar()
        {
            Console.WriteLine("This car {2} is made by {0} in year {1} in the city of {3}",CarMaker,MfgYear,CarModel,City);
        }
    }
}
