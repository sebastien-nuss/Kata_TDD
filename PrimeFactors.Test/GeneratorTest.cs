using NUnit.Framework;
using System.Collections.Generic;

namespace PrimeFactors.Test
{
    public class PrimeFactorTests
    {
        private List<int> result;
        private List<int> expected;
        private PrimeFactorGenerator gen;

        [SetUp]
        public void Setup()
        {
            gen = new PrimeFactorGenerator();
        }

        [Test]
        public void Generate_With1_ReturnEmpty()
        {
            result = gen.Generate(1);
            expected = new List<int>();
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Generate_With2_ReturnListOf2()
        {
            result = gen.Generate(2);
            expected = new List<int>{ 2 };
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Generate_With3_ReturnListOf3()
        {
            result = gen.Generate(3);
            expected = new List<int> { 3 };
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Generate_With4_ReturnListOf22()
        {
            result = gen.Generate(4);
            expected = new List<int> { 2, 2 };
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Generate_With6_ReturnListOf23()
        {
            result = gen.Generate(6);
            expected = new List<int> { 2, 3 };
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Generate_With8_ReturnListOf222()
        {
            result = gen.Generate(8);
            expected = new List<int> { 2, 2, 2 };
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Generate_With9_ReturnListOf33()
        {
            result = gen.Generate(9);
            expected = new List<int> { 3, 3 };
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Generate_With10_ReturnListOf25()
        {
            result = gen.Generate(10);
            expected = new List<int> { 2, 5 };
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}