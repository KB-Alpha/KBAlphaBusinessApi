using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KBAlphaBusinessApi.Helpers
{
    public static class TickerCheck
    {
        //Checks weather the ticker is valid
        public static bool CheckIsValidTicker(string ticker)
        {
            //search for characters like = ^ - .
            //Assume the string is valid
            bool result = true;

            //check the string
            if(
                ticker.Contains('-')  || ticker.Contains('^') || ticker.Contains('=') || ticker.Contains('.')){
                result = false;
            }

            return result;
        }
    }
}
