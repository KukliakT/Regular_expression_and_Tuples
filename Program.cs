using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular_expression
{
    class Program
    {
        public static (int, int) Count_Numbers(string str)
        {
            Regex regLife = new Regex(@"093[0-9]{7}");
            MatchCollection matLife = regLife.Matches(str);
            int Life_Count = matLife.Count;

            Regex regMTC = new Regex(@"095[0-9]{7}");
            MatchCollection matMTC = regMTC.Matches(str);
            int MTC_Count = matMTC.Count;

            (int, int) tuple = (Life_Count, MTC_Count);
            return tuple;

        }

        static void Main(string[] args)
        {
            string Phone_numbers = "0932324970 0935638669 0955638461 0939568143 0959105593 0959182232 0934654778 0934533648";
            Console.WriteLine("Life: " + Count_Numbers(Phone_numbers).Item1 + "\nMTC: " + Count_Numbers(Phone_numbers).Item2);
        }
    }
}
