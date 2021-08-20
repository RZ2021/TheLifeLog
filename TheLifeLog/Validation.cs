using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLifeLog
{
    class Validation
    {

        public bool IsDigits(string s)
        {
            s = s.Replace(" ", String.Empty);
            bool isDig = double.TryParse(s, out _);
            return isDig;
        }

        public double ToDigits(string s)
        {
            s = s.Replace(" ", String.Empty);
            if(s == "")
            {
                return -2;
            }
            bool isDig = double.TryParse(s, out double num);
            if(isDig)
            {
                return num;
            }
            else
            {
                return -1;
            }
        }
    }
}
