using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Unit_Converter.Measurements; 

namespace Unit_Converter
{
    public class Converter
    {
        Measurements measurement = new();

        public decimal UnitConvert(string from, string to, int value)
        {

            //decimal decVal = Convert.ToDecimal(value); 

            if(from == to)
            {
                return value; 

            } else if(from == "meter" && to == "kilometer")
            {
                //decVal /= 1000;
                // to decimal value /= 1000;

            } else if(from == "meter" && to == "centimeter")
            {
                value *= 100;
            } else if(from == "meter" && to == "millimeter")
            {
                value *= 1000;
            } else if(from == "meter" && to == "yard")
            {
                // to decimal value *= 1.0936
            } else if (from == "kilometer" && to == "meter")
            {
                value *= 1000;
            } else if (from == "kilometer" && to == "centimeter")
            {
                value *= 100000;
            } else if(from == "kilometer" && to == "millimeter")
            {
                value *= 1000000;
            }

            return value; 
        }
    }
}
