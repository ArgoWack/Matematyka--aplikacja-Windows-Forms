using System;
using System.Collections.Generic;

namespace Matematyka.Technical
{
    class Other_Methods
    {
        public static double NAN(double variable)
        {
            if (double.IsNaN(variable))
                return variable = 0;
            else
                return variable;
        }
        public static double INFINITY(double variable)
        {
            if (double.IsInfinity(variable))
                return variable = 0;
            else
                return variable;
        }
        public static double NULL_INFINITY(object variable)
        {
            if (variable == null)
            {
                return Convert.ToDouble(0);
            }
            else
            {
                return INFINITY(Convert.ToDouble(variable));
            }
        }

        public static bool If_not_zero_of_two(double variable1, double variable2)
        {
            if (variable1 != 0 && variable2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double Kąt_na_radiany(double variable)
        {
            while (variable >= 360 || variable < 0)
            {
                if (variable >= 360)
                    variable -= 360;
                if (variable < 0)
                    variable += 360;
            }
            return variable = (variable / 180) * Math.PI;
        }
        public static double Radiany_na_kąt(double variable)
        {
            return variable = (variable / Math.PI) * 180;
        }
    }
}
