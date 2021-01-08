using System;
using System.Collections.Generic;
using System.Text;
namespace Movieplex
{
   public static class Movies
    {
        public static IList<movie> movielist = new List<movie>();

        public static void  getMovies()
        {
            movielist.Clear();
            Console.WriteLine("How many movies are playing today?:");
            int mov = Commonfnc.GetInteger();
            while (mov > 10)
            {
                Console.WriteLine("Maximum 10 movies are allowed");
                mov = Commonfnc.GetInteger();
            }
            for (int i = 0; i < mov; i++) 
            {
                Console.WriteLine("\nWhat is the name of {0} movie ?:",Keys.order[i]);
                string name = Console.ReadLine().Trim();
                Console.WriteLine("\nPlease enter rating for this movie");
                string rating = Console.ReadLine().Trim();
                while(!(Array.IndexOf(Keys.Ratings, rating) >= 0))
                {
                    Console.WriteLine(Keys.Ratingstext);
                     rating = Console.ReadLine().Trim();
                }
                movielist.Add(new movie() { Name = name, Rating = rating });

            }
            ShowMovies();
            satisfy();
        }

        public static IList<movie> ShowMovies()
        {
            int num = 1;
            Console.WriteLine("\nThere are {0} movies playing today.Please choose from the following movies\n",movielist.Count);
            foreach (movie i in movielist)
            {
                Console.WriteLine("\t"+num++ +". "+ i.Name+"  {"+ i.Rating +"}");
            }
            return movielist;
        }
        public static void satisfy()
        {
            Console.WriteLine("Your movies playing today are listed above.Are you satisfied?(Y/N) ");
            string answer = (Console.ReadLine()).ToUpper();
            while (!((string.Equals(answer, "Y")) || (string.Equals(answer, "N"))))
            {
                Console.WriteLine("Your movies playing today are listed above.Are you satisfied?(Y/N) ");
                answer = (Console.ReadLine()).Trim().ToUpper();
            }
            if (string.Equals(answer, "Y"))
                Welcome.welcome();
            else if (string.Equals(answer, "N"))
                Movies.getMovies();
        }
    }
}
