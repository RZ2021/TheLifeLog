using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLifeLog
{
    class Validation
    {

        string removeSpace(string str)
        {
            string var = str.Replace(" ", String.Empty);
            return var;
        }

        bool isDigits(string s)
        {
            bool isDig = double.TryParse(s, out _);
            return isDig;
        }
    }
}
