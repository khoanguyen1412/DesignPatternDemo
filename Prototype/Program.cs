using System;

namespace Prototype
{
    class Client
    {
        static void Main(string[] args)
        {
            MovieDatabase firstMovie = new MovieDatabase();
            firstMovie.GetData();
            Client.ShowMovieInfor(firstMovie);

            MovieDatabase secondMovie = firstMovie.Clone();
            Client.ShowMovieInfor(secondMovie);
        }

        static void ShowMovieInfor(MovieDatabase movie)
        {
            Console.WriteLine("Movie: " + movie.Name + ", Genre: " + movie.Genre + ", Rating: " + movie.Rating);
        }
    }
}
