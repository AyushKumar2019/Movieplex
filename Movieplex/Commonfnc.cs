using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Movieplex
{
    public static class Commonfnc
    {
       public static int GetInteger()
        {
            int num;
            while(true){
                try
                {
                    num = Int32.Parse(Console.ReadLine().Trim());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message+"\nPlease Try Again");
                    continue;
                }
                break;
            }
            return num;
        }
        public static string GetAlbhabets()
        {
            while (true)
            {
                string inputString = Console.ReadLine().Trim();

                Regex r = new Regex("^[a-zA-Z ]+$");
                if (r.IsMatch(inputString))
                    return inputString;
                else
                {
                    Console.WriteLine("Please enter an appropriate name");
                }
            }
        }
    }
}
