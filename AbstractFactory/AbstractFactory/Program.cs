using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie(new EnLanguage());

            movie.showMovie();
        }
    }
}
