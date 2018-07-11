using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class HistoryTests
    {
        //public HistoryTests() {}

        [Fact]
        public void Test_HistoryId()
        {
            var expected = typeof(Guid);
            var sut = new History();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_HistoryMovieList()
        {
            // testing if there's anything in the movie list
            var expected = 1;
            var sut = new History();
            // we will need to create a method MovieList in the History class
            var actual = sut.MovieList;

            Assert.True(typeof(List<Movie>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }
    }
}