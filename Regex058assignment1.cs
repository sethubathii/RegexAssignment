using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignmentUC1
{
    class Regex058assignment
    {
        string pattern = "^[A-Z]{1}[a-z]{3,}$";
        //writing the valid pattern
        string[] inputs = { "sethu", "sethubathii", "sethu.4.20", "sethu.com", "qewrty", "ab", "abc@1.com", "SETHU" };//Validating some Example


        /// <summary>
        /// Validation this instance.
        /// </summary>
        public void Validation()
        {
            Regex regrex1 = new Regex(pattern);
            Console.WriteLine("Validating User First name: ");
            ItarateLoop(inputs, regrex1);
        }
        public void ItarateLoop(string[] arr, Regex regrex1)
        {
            for (int i = 0; i < arr.Length; i++)//validation Loop
            {
                bool result = regrex1.IsMatch(arr[i]);
                if (result)
                {
                    Console.WriteLine(arr[i] + " It is --->" + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + " It is --->" + "Invalid");
                }
            }
        }
    }
}