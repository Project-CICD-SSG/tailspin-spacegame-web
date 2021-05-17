using NUnit.Framework;
using System;

namespace Tailsping.SpaceGame.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldGameFunctionWithoutPlayers()
        {
            Assert.Pass();
        }

        [Test]
        public void ShouldPlayerWinIfCheating()
        {
            var rnd = new Random();

            var rndVal = rnd.Next(1, 100);

            Assert.IsTrue(rndVal > 50);
        }

        [Test]
        public void CanSupport10Players()
        {
            Assert.Pass();
        }
    }
}