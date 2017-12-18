using NUnit.Framework;
using Proxima.Utilities;

namespace Proxima.Tests.Utilities
{
    public class ByteExtensionsTests
    {
        [Test]
        public void FourMostSignificantBitsReturnExpectedResult()
        {
            var result = ByteExtensions.GetFourMostSignificantBits(0b0100_0000);
            Assert.AreEqual(result, 0b0100);
        }

        [Test]
        public void LeastSignificantBitsAreDiscardedByGetFourMostSignificantBits()
        {
            var result = ByteExtensions.GetFourMostSignificantBits(0b1010_1111);
            Assert.AreEqual(result, 0b0000_1010);
        }

        [Test]
        public void FourLeastSignificantBitsReturnExpectedResult()
        {
            var result = ByteExtensions.GetFourLeastSignificantBits(0b0000_0100);
            Assert.AreEqual(result, 0b0100);
        }

        [Test]
        public void MostSignificantBitsAreDiscardedByGetFourLeastSignificantBits()
        {
            var result = ByteExtensions.GetFourLeastSignificantBits(0b1010_1111);
            Assert.AreEqual(result, 0b0000_1111);
        }
    }
}
