using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ReizTechAssignment
{
    public class Calculations
    {
        private Validation validation;
        public Calculations()
        {
            validation = new Validation();
        }
        public string GetData()
        {
            string? time = "";
            while (true)
            {

                Console.Write("Please enter time (format hh:mm), to quit press enter : ");
                time = Console.ReadLine();
                if (time == "")
                {
                    return time;
                }
                if (time != null && validation.ValidateData(time))
                {
                    return time;
                }
                else
                {
                    Console.WriteLine("Entered time is in wrong format!!!");
                }

            }
        }
        public double CalculateAngle(string input)
        {
            double shortArrowPerMinute = 0.5;
            double shortArrowPerHour = 30.0;
            double longArrowPerMinute = 6.0;
            int hrs = int.Parse(input.Split(':')[0]);
            int min = int.Parse(input.Split(':')[1]);
            double degrees = Math.Abs(hrs * shortArrowPerHour + min * shortArrowPerMinute - min * longArrowPerMinute);
            return degrees > 180 ? 360 - degrees : degrees;
        }
    }
}