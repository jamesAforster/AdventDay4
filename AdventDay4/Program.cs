using System;
using System.IO;
using System.Text;

namespace AdventDay4
{
    public class Passport
    {
        string[] fields = { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid", "cid" };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int Valid()
        {
            string path = @"/Users/james.forster/Projects/AdventDay4/AdventDay4/input.txt";
            string inputText = File.ReadAllText(path);
            string[] textArray = inputText.Split("\n\n");
            
            int count = 0;

            foreach (string s in textArray)
            {
               if (fieldsCheck(s) == true)
                {
                    count++;
                }
            }

            return count;
        }

        public bool fieldsCheck(string input)
        {
            int count = 0;
            foreach (string field in fields)
            {
                if (input.Contains(field))
                {
                    count++;
                }
            }
            if (count == 8 || count == 7 && !input.Contains("cid"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
