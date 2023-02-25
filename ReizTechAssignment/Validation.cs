using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTechAssignment
{
    public class Validation
    {
        public Validation()
        {

        }
        public bool ValidateData(string input)
        {
            string[] time;            
            if (input.IndexOf(':') != 2 || input.Length != 5)
                return false;
            time = input.Split(':');
            if (time.Length != 2)
                return false;
            if (!CheckValue(time[0], 12) || !CheckValue(time[1], 59))
                return false;
            return true;
        }
        private bool CheckValue(string input, int maxValue)
        {
            if (!int.TryParse(input, out int i))
            {
                return false;
            }
            if (i > maxValue || i < 0)
            {
                return false;
            }
            return true;
        }
    }
}
