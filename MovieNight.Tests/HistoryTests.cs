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
            var actual =sut.Id;

            Assert.True(expected == actual.GetType());
        }
    }

    public void Test_HistoryMovieList()
    {
        
    }
}