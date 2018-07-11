using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class VotingTests
    {
        [Fact]
        public void Test_VotingTests()
        {
            var expected = typeof(Guid);
            var sut = new Voting();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_VotingPersonList()
        {
            var expected = 1;
            var sut = new Voting();
            var actual = sut.PeopleList;

            Assert.True(typeof(List<Person>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }
    }
}