using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class History : AModel
    {
        public List<Movie> MovieList
        {
            get;
            set;
        }

        public History()
        {
            // when we create a history object, we create a list with one movie object in it
            // , using the list initializer.
            MovieList = new List<Movie>() {new Movie()};
        }
    }
}
