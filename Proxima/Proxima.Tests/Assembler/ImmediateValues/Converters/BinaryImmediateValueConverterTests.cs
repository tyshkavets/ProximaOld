using System;
using NUnit.Framework;
using Proxima.Assembler.ImmediateValues.Converters;

namespace Proxima.Tests.Assembler.ImmediateValues.Converters
{
    public class BinaryImmediateValueConverterTests 
    {
        [Test]
        public void CheckConversionFromPrefixFormIsCorrect()
        {
            var converter = new BinaryImmediateValueConverter();
            var result = converter.Convert("0b00001111");
            Assert.AreEqual(15, result);
        }

        [Test]
        public void CheckConversionFromPostfixFormIsCorrect()
        {
            var converter = new BinaryImmediateValueConverter();
            var result = converter.Convert("00001111b");
            Assert.AreEqual(15, result);
        }

        [Test]
        public void CheckConversionFromPrefixUnderscoredFormIsCorrect()
        {
            var converter = new BinaryImmediateValueConverter();
            var result = converter.Convert("0b0000_1111");
            Assert.AreEqual(15, result);
        }

        [Test]
        public void ConversionThrowsForIncorrectSymbols()
        {
            var converter = new BinaryImmediateValueConverter();
            Assert.Throws<FormatException>(() => converter.Convert("0b0000_1234"));
        }
    }
}
