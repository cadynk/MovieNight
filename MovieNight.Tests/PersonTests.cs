﻿using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Test_PersonId()
        {
            var expected = typeof(Guid);
            var sut = new Person();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_PersonHistory()
        {
            var expected = 1;
            var sut = new Person();
            var actual = sut.History;

            Assert.NotNull(sut.History);
        }
    }
}