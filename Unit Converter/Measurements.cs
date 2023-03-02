using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    public class Measurements
    {
        public static string Meter => "meter";
        public static string Kilometer => "kilometer";
        public static string Centimeter => "centimeter";
        public static string Millimeter => "millimeter";
        public static string Mile => "mile";
        public static string Yard => "yard";
        public static string Foot => "foot";
        public static string Inch => "inch";
        public static string Lighyear => "lightyear";

        public string GetMeasurementType(int num)
        {
            string result = "";

            switch (num)
            {
                case 1:
                    result = Meter;
                    break;
                case 2:
                    result = Kilometer;
                    break;
                case 3:
                    result = Centimeter;
                    break;
                case 4:
                    result = Millimeter;
                    break;
                case 5:
                    result = Mile;
                    break;
                case 6:
                    result = Yard;
                    break;
                case 7:
                    result = Foot;
                    break;
                case 8:
                    result = Inch;
                    break;
                case 9:
                    result = Lighyear;
                    break;
            }

            return result;
        }
    }
}
