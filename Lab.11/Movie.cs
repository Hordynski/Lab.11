using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._11
{
    class Movie
    {
        private string _title{ get; set; }

        private string _category { get; set; }

        public Movie(string Title, string Category)
        {
            _title = Title;
            _category = Category;
        }

        // James - I do think it is clever that you have a seperate method for each genre, cool stuff.
        // what you could do is make only ONE method and as an argument it takes the letter.
        // also I would recommend that this/these methods return either a string or the objects themselves.
        // the reason I make this recommendation is to help keep your presentation layer, the console writelining,
        // and the data in this class.  like what if you want to port this entire class over to a web app instead?
        // well it is tightly coupled to a console right now, so it's not re-usable for other mediums.  just food
        // for thought, otherwise great job man
        public static void PrintScifi(List<Movie> movieList)
        {
            foreach (var movie in movieList)
            {
                if (movie._category.StartsWith("S", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(movie._title);
                }
            }
        }

        public static void PrintAnimated(List<Movie> movieList)
        {
            foreach (var movie in movieList)
            {
                if (movie._category.StartsWith("A", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(movie._title);
                }
            }
        }

        public static void PrintHorror(List<Movie> movieList)
        {
            foreach (var movie in movieList)
            {
                if (movie._category.StartsWith("H", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(movie._title);
                }
            }
        }

        public static void PrintDrama(List<Movie> movieList)
        {
            foreach (var movie in movieList)
            {
                if (movie._category.StartsWith("D", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(movie._title);
                }
            }
        }

    }
}