using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hi_Tech_Order_Management_System.VALIDATION
{
    public class Validator
    {
        public static bool IsValidId(string input)
        {
            if (!Regex.IsMatch(input, @"^\d{5}$"))
            {
                return false;
            }

            return true;
        }
        public static bool IsValidName(string input)
        {
            if (input.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (!(Char.IsLetter(input[i])) && !(Char.IsWhiteSpace(input[i])))
                {
                    return false;

                }
            }

            return true;
        }
        public static bool IsValidEmail(string input)
        {
            if (!Regex.IsMatch(input, @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b"))
            {
                return false;
            }

            return true;
        }
        public static bool IsValidPhone(string input)
        {
            string pattern = @"^\(\d{3}\)\s?\d{3}-\d{4}$";
            if (!Regex.IsMatch(input,pattern))
            {
                return false;
            }

            return true;
        }
        
        public static bool IsValidPostaCode(string input)
        {
            string pattern = @"^[A-Za-z]\d[A-Za-z]([ -])?\d[A-Za-z]\d$|^\d{5}-\d{4}$";

            if (!Regex.IsMatch(input, pattern))
            {
                return false;
            }

            return true;
        }
        public static bool IsValidNumber(string input)
        {
            
            string numberPattern = @"^[-+]?[0-9]*\.?[0-9]+$";

            if (!Regex.IsMatch(input, numberPattern))
            {
                return false;
            }

            return true;
        }
        public static bool IsValidISBN(string input)
        {
            string cleanedInput = input.Replace("-", "").Replace(" ", "");
            string isbnPattern = @"^(?:ISBN(?:-10)?:?\s*)?(?=[0-9X]{10}$|(?=(?:[0-9]+[-\s]?){3})[-\s0-9X]{13}$)[0-9]{1,5}[-\s]?[0-9]+[-\s]?[0-9]+[-\s]?[0-9X]$";

            if (!Regex.IsMatch(cleanedInput, isbnPattern, RegexOptions.IgnoreCase))
            {
                return false;
            }

            return true;
        }
        public static bool IsValidTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                return false;       
            }
            string titlePattern = @"^[\p{L}\p{N}\s',\-&():;!]+$";

            if (!Regex.IsMatch(title, titlePattern))
            {
                return false; 
            }
            if (title.Length < 1 || title.Length > 100)
            {
                return false; 
            }
            return true; 
        }

        public static bool IsValidAddress(string input)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    return false; 
                }
                string addressPattern = @"^\d{1,4}\s+[a-zA-Z0-9]+\s+(Blvd|Ave|St|Rd|Ln|Dr|Ct|Pl|Ch|Cir|Way|Sq|Terr)?(\.?)\s*(,?\s+(Apt|Apartment|Unit|Suite)\s+[a-zA-Z0-9]+)?$";

                if (!Regex.IsMatch(input, addressPattern))
                {
                    return false; 
                }
                 if (input.Length < 1 || input.Length > 100)
                {
                    return false; 
                }

                return true; 
        }


    }
}
