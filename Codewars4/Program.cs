using System;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;


//Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2,
//    otherwise returns false.

//Notes:

//Only lower case letters will be used (a-z). No punctuation or digits will be included.
//Performance needs to be considered.
//Examples
//scramble('rkqodlw', 'world') ==> True
//scramble('cedewaraaossoqqyt', 'codewars') ==> True
//scramble('katas', 'steak') ==> False


namespace Codewars4
{
    
    public class Scramblies
    {
         

        public static bool Scramble(string str1, string str2)
        {
            bool result = true;
            
            foreach (var ch in str2)
            {
                if(str1.Contains(ch) == false )
                {
                   result = false;
                    break;
                }
                else
                {
                    char[] textarray = str1.ToCharArray();

                    for (int i = 0; i < str1.Length; i++)
                    {
                        if (textarray[i].Equals(ch))
                        {
                            str1 = str1.Remove(i, 1);
                            break;
                        }
                    }
                        
                }
            }
            return result;


        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("False  Below here............");
            Console.WriteLine(Scramblies.Scramble("katas", "steak"));
            Console.WriteLine(Scramblies.Scramble("javscripts", "javascript"));
            Console.WriteLine(Scramblies.Scramble("scriptjavx", "javascript"));


            Console.WriteLine("**************************");


            Console.WriteLine("True below here...........");
            Console.WriteLine(Scramblies.Scramble("scriptingjava", "javascript")); 
            Console.WriteLine(Scramblies.Scramble("scriptsjava", "javascript"));  
            Console.WriteLine(Scramblies.Scramble("sammoc", "commas"));        
            Console.WriteLine(Scramblies.Scramble("rkqodlw", "world"));
            Console.WriteLine(Scramblies.Scramble("aabbcamaomsccdd", "commas"));  // wrong 
            Console.WriteLine(Scramblies.Scramble("commas", "commas"));          // wrong 
            Console.WriteLine(Scramblies.Scramble("cedewaraaossoqqyt", "codewars"));// wrong
        }
    }
    //var count = str1.Count(x => x == ch);
    //str1 = string.Join("", str1.Split(ch));
    //str1 = str1.PadRight((count -1) + str1.Length, ch);
}
