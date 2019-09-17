using System;
using Xunit;

namespace BadSuperBowlNamer.Tests
{
    public class SuperBowlNamerTests
    {
        [Fact]
        public void Tests1()
        {
            var number = 1;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("I", result);
        }

        [Fact]
        public void Tests5()
        {
            var number = 5;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("V", result);
        }

        [Fact]
        public void Tests9()
        {
            var number = 9;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("IX", result);
        }
        [Fact]
        public void Tests12()
        {
            var number = 12;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("XII", result);
        }
        [Fact]
        public void Tests16()
        {
            var number = 16;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("XVI", result);
        }
        [Fact]
        public void Tests29()
        {
            var number = 29;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("XXIX", result);
        }
        [Fact]
        public void Tests44()
        {
            var number = 44;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("XLIV", result);
        }
        [Fact]
        public void Tests45()
        {
            var number = 45;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("XLV", result);
        }
        [Fact]
        public void Tests68()
        {
            var number = 68;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("LXVIII", result);
        }
        [Fact]
        public void Tests83()
        {
            var number = 83;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("LXXXIII", result);
        }
        [Fact]
        public void Tests97()
        {
            var number = 97;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("XCVII", result);
        }
        [Fact]
        public void Tests99()
        {
            var number = 99;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("XCIX", result);
        }
        [Fact]
        public void Tests500()
        {
            var number = 500;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("D", result);
        }
        [Fact]
        public void Tests501()
        {
            var number = 501;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("DI", result);
        }
        [Fact]
        public void Test649()
        {
            var number = 649;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("DCXLIX", result);
        }
        [Fact]
        public void Tests798()
        {
            var number = 798;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("DCCXCVIII", result);
        }
        [Fact]
        public void Tests891()
        {
            var number = 891;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("DCCCXCI", result);
        }
        [Fact]
        public void Tests1000()
        {
            var number = 1000;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("M", result);
        }
        [Fact]
        public void Tests1004()
        {
            var number = 1004;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("MIV", result);
        }
        [Fact]
        public void Tests1006()
        {
            var number = 1006;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("MVI", result);
        }
        [Fact]
        public void Tests1023()
        {
            var number = 1023;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("MXXIII", result);
        }
        [Fact]
        public void Tests2014()
        {
            var number = 2014;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("MMXIV", result);
        }
        [Fact]
        public void Tests3999()
        {
            var number = 3999;
            var romanizer = new Romanizer();

            var result = romanizer.Romanized(number);

            Assert.Equal("MMMCMXCIX", result);
        }
    }
}
