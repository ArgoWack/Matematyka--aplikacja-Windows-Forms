using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        public static double Exceptions_double_without_limits(string text)
        {
            double value;
            try
            {
                value = double.Parse(text);
            }
            catch (Exception)
            {
                value = 0;
            }
            return value;
        }
        public static int Exceptions_int_without_limits(string text)
        {
            int value;
            try
            {
                value = int.Parse(text);
                if(value<0)
                {
                    value = 0;
                }
            }
            catch (Exception)
            {
                value = 0;
            }
            return value;
        }
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Menu());
        }
    }
}
// Copyright: Hubert Kieslich