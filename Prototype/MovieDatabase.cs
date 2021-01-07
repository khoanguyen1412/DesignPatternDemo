using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class MovieDatabase
    {
        public string Name;
        public string Genre;
        public double Rating;

        public void GetData() 
        {
            //charge 1$ call api
            Name = "Batman";
            Genre = "Action";
            Rating = 4.5;
        }

        public MovieDatabase Clone()
        {
            MovieDatabase clonedMovie = new MovieDatabase();
            //copy data without call api
            clonedMovie.Name = this.Name;
            clonedMovie.Genre = this.Genre;
            clonedMovie.Rating = this.Rating;

            return clonedMovie;
        }

    }
}
