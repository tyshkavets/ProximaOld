using System;
using NUnit.Framework;
using Proxima.Assembler.ImmediateValues.Converters;

namespace Proxima.Tests.Assembler.ImmediateValues.Converters
{
    public class DecimalImmediateValueConverterTests
    {
        [Test]
        public void CheckConversionFromNoAffixFormIsCorrect()
        {
            var converter = new DecimalImmediateValueConverter();
            var result = converter.Convert("0000_1357");
            Assert.AreEqual(1357, result);
        }

        [Test]
        public void CheckConversionFromPostfixFormIsCorrect()
        {
            var converter = new DecimalImmediateValueConverter();
            var result = converter.Convert("00001357d");
            Assert.AreEqual(1357, result);
        }

        [Test]
        public void CheckConversionFromNoAffixUnderscoredFormIsCorrect()
        {
            var converter = new DecimalImmediateValueConverter();
            var result = converter.Convert("0000_1357");
            Assert.AreEqual(1357, result);
        }

        [Test]
        public void ConversionThrowsForIncorrectSymbols()
        {
            var converter = new DecimalImmediateValueConverter();
            Assert.Throws<FormatException>(() => converter.Convert("0000_1234_S"));
        }
    }
}
