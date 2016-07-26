using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "a string";
            string s2 = "This is a \r\n multi-line string";
            Console.WriteLine(s);
            Console.WriteLine();
            Console.WriteLine(s2);

            //Concatenation
            string s3 = s + s2;
            Console.WriteLine($"Concatenation:   {s3}");
            Console.WriteLine();
            GetSubString.RetInfo();
            Console.WriteLine(GetSubString.RevStr("taco cat"));
            Console.ReadLine();

        }
    }

    //Substring

    public class GetSubString
    {
        public static void RetInfo()
        {
            string[] records = { "Name: Jake Blues", "Address: 1060 West Addison, Chicago, IL", "Occupation: Musician", "Age: 35" };

            int endOfRecord = 0;

            Console.WriteLine("The total array information is ");
            foreach (string s in records)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nThe array information without the tags is");
            foreach (string s in records)
            {
                endOfRecord = s.IndexOf(": ");
                Console.WriteLine("   {0}", s.Substring(endOfRecord + 2));

            }
        }

        // Reverse a string

        public static char [] RevStr(string x)
        {

            char [] charArray = new char [x.Length];
            int len = x.Length - 1;
            for (int i = 0; i <= len; i++)
                charArray[i] = x[len - i];
            return charArray;
        }
    }
}


