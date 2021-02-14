using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie(new EnLanguageFactory());
            movie.showMovie();

            movie.setLanguage(new UaLanguageFactory());
            movie.showMovie();
        }
    }
}
