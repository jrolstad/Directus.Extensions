﻿using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Rhino.Mocks;

namespace Directus.Extensions.Core.Test.Given_an_enumerable
{
    [TestFixture]
    public class When_enumerating_over_it
    {
        private List<log4net.ILog> Items;
        private IEnumerable<log4net.ILog> Result;

        [TestFixtureSetUp]
        public void BeforeAll()
        {
            Items = new List<log4net.ILog>
                             {
                                 MockRepository.GenerateStub<log4net.ILog>(),
                                 MockRepository.GenerateStub<log4net.ILog>(),
                                 MockRepository.GenerateStub<log4net.ILog>()
                             };

            Result = this.Items.Each(i => i.Debug("foo"));
        }


        [Test]
        public void Then_Each_returns_the_enumerable()
        {
            // Assert
            Assert.That(this.Result, Is.SameAs(this.Items));
        }

        [Test]
        public void Then_Each_acts_on_each_item()
        {
            // Assert
            foreach (var item in Items)
            {
                item.AssertWasCalled(i => i.Debug("foo"));
            }
        }


    }
}