using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucutreAlgorithm
{
    public class Anagram
    {
        public static void AnagramCheck()
        {
            Console.WriteLine("Enter the First String");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the Second String");
            string str2 = Console.ReadLine();
            char[] c1 = str1.ToLower().ToCharArray();
            char[] c2 = str2.ToLower().ToCharArray();
            Array.Sort(c1);
            Array.Sort(c2);
            string v1 = new string(c1);
            string v2 = new string(c2);
            Console.WriteLine(v1 + " " + v2);
            if(v1 == v2)
            {
                Console.WriteLine("Its a Anagram");
            }
            else
            {
                Console.WriteLine("Its Not a Anagram");
            }

        }
    }
}
