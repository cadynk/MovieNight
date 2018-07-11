using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class MovieTests
    {
        [Fact]
        public void Test_MovieId()
        {
            var expected = typeof(Guid);
            var sut = new Movie();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_MovieActors()
        {
            // testing if there's anything in the actor list
            var expected = 1;
            var sut = new Movie();
            // we will need to create a method MovieList in the History class
            var actual = sut.MovieActorList;

            Assert.True(typeof(List<Person>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }
    }
}
