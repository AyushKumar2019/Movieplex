using System;
using System.Collections.Generic;
using System.Text;

namespace Movieplex
{
    static class Keys
    {
        public static string Adminpwd = "1234";
        public static string[] order = new string[]
        {"first","second","third","four","five","sixth","seventh","eigth","ninth","Last"};
        public static string[] Ratings = new string[]
        {"G","PG-13","R","NC-17","PG"};
        public static string Ratingstext ="\nplease choose from the following ratings"+
            "\nG – General Audience, any age is good \nPG – We will take PG as 10 years or old" +
            "\nPG-13 – We will take PG-13 as 13 years or older " +
            "\nR – We will take R as 15 years or older.Don’t worry about accompany by parent case." +
            "\nNC-17 – We will take NC-17 as 17 years or older";
        public static string Title = "\t\t***************************************\n" +
                                  "\t\t***Welcome to the Movie Plex Theatre***\n" +
                                  "\t\t***************************************\n";

    }
}
