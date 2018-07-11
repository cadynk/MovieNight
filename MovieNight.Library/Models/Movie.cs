using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Movie : AModel
    {
        public List<Person> MovieActorList
        {
            get;
            set;
        }

        public Movie()
        {
            MovieActorList = new List<Person>() {new Person()};
        }
    }
}
