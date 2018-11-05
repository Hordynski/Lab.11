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