using System;
using NUnit.Framework;
using Proxima.Utilities;

namespace Proxima.Tests.Utilities
{
    public class ByteArrayExtensionsTests
    {
        [Test]
        public static void GetWordDoesNotOverflow()
        {
            var array = new byte[] {0b1111_1111, 0b1111_1111};
            Assert.AreEqual(array.GetWordValue(0), UInt16.MaxValue);
        }

        [Test]
        public static void GetDwordDoesNotOverflow()
        {
            var array = new byte[] {0b1111_1111, 0b1111_1111, 0b1111_1111, 0b1111_1111};
            Assert.AreEqual(array.GetDwordValue(0), UInt32.MaxValue);
        }
    }
}
