using System;
using System.Collections.Generic;
using System.Text;

namespace Movieplex
{
    public static class Login
    {
        public  static void choice(int sel) 
        {
            while (sel != 1 && sel != 2)
            {
                Console.WriteLine("please choose the correct option");
                Welcome.welcome();

            }
            switch (sel) {
                case 1:
                    Admin();
                    break;
                case 2:
                    Guest();
                    break;
                default:
                    Console.WriteLine("please choose the correct option");
                    break;
            }
        }
        public static void Admin()
        {
            int count = 5;
            string pwd = "";
            while (!pwd.Equals("B") && count > 0)
            {
                Console.WriteLine("please Enter the Admin Password");
                pwd = Console.ReadLine().Trim();
                if (pwd.Equals(Keys.Adminpwd))
                {
                    Movies.getMovies();
                    break;
                }
                else if (pwd.Equals("B"))
                {
                    Welcome.welcome();
                    break;

                }
                else
                {
                    count--;
                    Console.WriteLine("\nYou have entered invalid Password\nYou have {0} Attempts left to enter the correct password"
                        + "OR Press B to go back to the previous screen", count);

                }
            }
            if (count == 0)
            {
                Welcome.welcome();
            }


        }
        public static void Guest()
        { 
            bool status = false;
            IList<movie> movies= Movies.ShowMovies();
            if (movies.Count == 0)
            {
                Console.WriteLine("\n\nSorry! There are no movies in the records today.\n\n Please ask admin to add some movies\n\n");
                Welcome.welcome();
            }

            Console.WriteLine("Which movie do you like to watch?");
            int movie= Commonfnc.GetInteger();
            while (movie > movies.Count)
            {
                Console.WriteLine("PLease enter the number seen in the movie list");
                 movie = Commonfnc.GetInteger();

            }
            Console.WriteLine("Please enter your age for verification");
            int age = Commonfnc.GetInteger();
            movie--;
            while (age <= 0 || age > 200)
            {
                Console.WriteLine("Please enter the valid  age for verification");
                age = Commonfnc.GetInteger();
            }

            if (string.Equals(movies[movie].Rating, "G"))
                 status = true;
            else if (string.Equals(movies[movie].Rating, "PG") && age >= 10)
                { 
                    status = true;
                }
            else if (string.Equals(movies[movie].Rating, "PG-13")&& age >= 13)
            {
                    status = true;
            }
            else if (string.Equals(movies[movie].Rating, "R") && age >= 15)
            {
                    status = true;
            }
            else if (string.Equals(movies[movie].Rating, "NC-17") && age > 17)
            {
                    status = true;

            }
            else 
            {
                Console.WriteLine("\nPlease enter the valid age");
                status = false;
            }
            if (status == true)
            {
                Console.WriteLine("\n\tEnjoy the movie\n");
                Console.WriteLine("Press M to go back to the Guest main menu\n");
                Console.WriteLine("\tPress S to go back to the start page\n");
                string sel = Console.ReadLine().ToUpper();
                while (!(string.Equals(sel, "M") || string.Equals(sel, "S")))
                {
                    Console.WriteLine("Press M to go back to the Guest main menu\n");
                    Console.WriteLine("\tPress S to go back to the start page\n");
                    sel = Console.ReadLine().ToUpper();
                }
                if (string.Equals(sel, "M"))
                    Guest();
                else
                    Welcome.welcome();

            }
            else
            {
                Console.WriteLine("\nPlease select another movie");
                Guest();

            }

        }
    }
}
