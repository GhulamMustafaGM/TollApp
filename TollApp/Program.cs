using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // I have tested and checked the results in the following 3 different dates. Results are correct. 
            DateTime[] date = { new DateTime(2021, 08, 17, 6, 25, 0), new DateTime(2021, 08, 17, 7, 40, 0), new DateTime(2021, 08, 17, 15, 40, 0), new DateTime(2021, 08, 17, 17, 5, 0) };
            // DateTime[] date = { new DateTime(2021, 07, 17, 6, 25, 0), new DateTime(2021, 07, 17, 7, 40, 0), new DateTime(2021, 07, 17, 15, 40, 0), new DateTime(2021, 07, 17, 17, 5, 0) };
            // DateTime[] date = { new DateTime(2021, 04, 30, 6, 25, 0), new DateTime(2021, 04, 30, 7, 40, 0), new DateTime(2021, 04, 30, 15, 40, 0), new DateTime(2021, 04, 30, 17, 5, 0) };
            TollCalculator toll = new TollCalculator();
            int tollFee = toll.GetTollFee(new Car(), date);
            // int tollFee = toll.GetTollFee(new Motorbike(), date);
            Console.WriteLine("Today, total toll fee collected is :  " + tollFee);
            Console.ReadLine();
        }
    }
}
