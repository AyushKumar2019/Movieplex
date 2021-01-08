using System;
using System.Collections.Generic;
using System.Text;

namespace Movieplex
{
   public static class Welcome
    {
         public static void welcome()
        {
                Console.WriteLine(Keys.Title);
                Console.WriteLine("Please select from the following two options\n1: Administrator\n2: Guests\n Selection");
                Login.choice(Commonfnc.GetInteger());
        }


    }
}
