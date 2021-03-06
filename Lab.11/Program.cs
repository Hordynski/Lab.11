﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> moviesData = new List<Movie>();

            // James  - cool use of constructors here, makes the code look cleaner. 
            // I would maybe have a seperate method or class to handle initializing the initial data.
            moviesData.Add(new Movie("My Neighbor Totoro", "Animated"));
            moviesData.Add(new Movie("The Room", "Drama"));
            moviesData.Add(new Movie("Gundam Wing: Endless Waltz", "Animated"));
            moviesData.Add(new Movie("Star Wars: A New Hope", "Sci Fi"));
            moviesData.Add(new Movie("13 Ghosts", "Horror"));
            moviesData.Add(new Movie("A Hitchhiker's Guide to the Galaxy", "Sci Fi"));
            moviesData.Add(new Movie("The Notebook", "Drama"));
            moviesData.Add(new Movie("Hellraiser", "Horror"));
            moviesData.Add(new Movie("Howl's Movie Castle", "Animated"));
            moviesData.Add(new Movie("Spirited Away", "Animated"));
            Console.WriteLine("Hello! Welcome to Movie List, your premiere service for finding movies!");
            Console.WriteLine("******************************************************************");
            Console.WriteLine("There are 10 movies in this list.");
            Console.WriteLine("******************************************************************");

            var doAgain = true;

            while (doAgain)
            {

                Console.Write("What category are you interested in? Your options are SciFi, Horror, Drama, and Animated: ");
                var userEntry = Console.ReadLine();

                // James - I like how this is sorted, easy to read. if you only care about a user entering one letter
                // look into Console.ReadKey(), that may help you out.
                if (userEntry.StartsWith("H", StringComparison.OrdinalIgnoreCase))
                {
                    Movie.PrintHorror(moviesData);
                }

                else if (userEntry.StartsWith("A", StringComparison.OrdinalIgnoreCase))
                {
                    Movie.PrintAnimated(moviesData);
                }

                else if (userEntry.StartsWith("S", StringComparison.OrdinalIgnoreCase))
                {
                    Movie.PrintScifi(moviesData);
                }

                else if (userEntry.StartsWith("D", StringComparison.OrdinalIgnoreCase))
                {
                    Movie.PrintDrama(moviesData);
                }

                else
                {
                    Console.WriteLine("I'm sorry that is not a valid input.");
                    Console.WriteLine(" ");
                }

                Console.Write("Would you like to choose another category? ");
                var userRepeat = Console.ReadLine();

                if (userRepeat.StartsWith("Y", StringComparison.OrdinalIgnoreCase))
                {
                    doAgain = true;
                }

                else
                {
                    doAgain = false;
                }
            }
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}
