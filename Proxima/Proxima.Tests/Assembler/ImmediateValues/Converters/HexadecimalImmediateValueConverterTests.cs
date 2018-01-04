using System;
using NUnit.Framework;
using Proxima.Assembler.ImmediateValues.Converters;

namespace Proxima.Tests.Assembler.ImmediateValues.Converters
{
    class HexadecimalImmediateValueConverterTests
    {
        [Test]
        public void CheckConversionFromPrefixFormIsCorrect()
        {
            var converter = new HexadecimalImmediateValueConverter();
            var result = converter.Convert("0xFFFF");
            Assert.AreEqual(65535, result);
        }

        [Test]
        public void ConversionFromPostfixFormIsCorrect()
        {
            var converter = new HexadecimalImmediateValueConverter();
            var result = converter.Convert("FFFFh");
            Assert.AreEqual(65535, result);
        }

        [Test]
        public void BothUpperAndLowerCaseLettersAreSupported()
        {
            var converter = new HexadecimalImmediateValueConverter();
            var result = converter.Convert("FfFfh");
            Assert.AreEqual(65535, result);
        }

        [Test]
        public void UnderscoresAreIgnored()
        {
            var converter = new HexadecimalImmediateValueConverter();
            var result = converter.Convert("0xFF_FF");
            Assert.AreEqual(65535, result);
        }

        [Test]
        public void ConversionThrowsForIncorrectSymbols()
        {
            var converter = new HexadecimalImmediateValueConverter();
            Assert.Throws<FormatException>(() => converter.Convert("0xGGGG"));
        }
    }
}
