using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harsha_Vowel_Consonants
{
    public class FiscalCodeGenerator
    {
        static char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

        public static string GenerateSurnameCode(string surname)
        {
               
            var consonants = surname.ToUpper().Where(c => !vowels.Contains(c));
            if (consonants.Count() >= 3)
            {
                return new string(consonants.Take(3).ToArray());
            }
            else
            {
                var vowelsInSurname = surname.ToUpper().Where(c => vowels.Contains(c));
                return new string(consonants.Concat(vowelsInSurname).Take(3).ToArray()).PadRight(3, 'X');
            }
        }

        public static string GenerateNameCode(string name)
        {
            string code = "";
            var consonants = name.ToUpper().Where(c => !vowels.Contains(c));
            if (consonants.Count() == 3)
            {
                return new string(consonants.ToArray());
            }
            else if (consonants.Count() > 3)
            {
                return new string(new char[] { consonants.ElementAt(0), consonants.ElementAt(2), consonants.ElementAt(3) });
            }
            else
            {
                var vowelsInSurname = name.ToUpper().Where(c => vowels.Contains(c));
                code = new string(consonants.Concat(vowelsInSurname).Take(3).ToArray());
                code = code.PadRight(3, 'X');
            }
            return code.ToUpper();
        }

        public static string GenerateDateCode(string gender, string dob)
        {       

            int dayValue = int.Parse(dob.Split("/")[0]);
            string day = "";
            string month = MonthCode(int.Parse(dob.Split("/")[1]));
            int year = int.Parse(dob.Split("/")[2])%100;
            if (gender.ToUpper() == "M")
            {
                if (dayValue < 10)
                {
                     day= "0" + dayValue;         
                }               
            }
            else if (gender.ToUpper() == "F")
            {
                day += 40+dayValue;
            }
            return year.ToString() + month + day;
        }

        private static string MonthCode(int month)
        {
            string[] codes = { "A", "B", "C", "D", "E", "H", "L", "M", "P", "R", "S", "T" };
            return codes[month - 1];
        }
    }
}

