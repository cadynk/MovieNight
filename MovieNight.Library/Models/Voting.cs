using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Voting : AModel
    {
        public Movie Movie
        {
            get;
            set;
        }

        public List<Person> PeopleList
        {
            get;
            set;
        }

        public Voting()
        {
            PeopleList = new List<Person>() { new Person() };
        }
    }
}
