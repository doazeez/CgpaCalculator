using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CgpaCalculator
{
    public class Validation
    {
        private string courseCodePattern = "^[A-Z]{3}[0-9]{3}";
        public bool isLetterOrDigit(string s)
        {
            return Regex.IsMatch(s, courseCodePattern);
        }
        public static string numCheck(string number)
        {
            return int.TryParse(number, out _) == true ? number.Trim() : "INVALID INPUT"; 
        }
    }
}
