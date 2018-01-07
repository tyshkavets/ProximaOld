using NUnit.Framework;
using Proxima.Assembler.ImmediateValues;

namespace Proxima.Tests.Assembler.ImmediateValues
{
    public class ImmediateValueLexerTests
    {
        [Test]
        public void BinaryLexemeTestsPositiveByIsImmediateValueMethod()
        {
            var lexeme = new ImmediateValueLexer();
            var result = lexeme.IsImmediateValue("0b01010101");
            Assert.IsTrue(result);
        }

        [Test]
        public void DecimalLexemeTestsPositiveByIsImmediateValueMethod()
        {
            var lexeme = new ImmediateValueLexer();
            var result = lexeme.IsImmediateValue("01010101");
            Assert.IsTrue(result);
        }

        [Test]
        public void HexadecimalLexemeTestsPositiveByIsImmediateValueMethod()
        {
            var lexeme = new ImmediateValueLexer();
            var result = lexeme.IsImmediateValue("01010101h");
            Assert.IsTrue(result);
        }

        [Test]
        public void NegativeTestForIsImmediateValueMethod()
        {
            var lexeme = new ImmediateValueLexer();
            var result = lexeme.IsImmediateValue("DAFFODILS!");
            Assert.IsFalse(result);
        }

        [Test]
        public void BinaryLexemeParsedCorretly()
        {
            var lexeme = new ImmediateValueLexer();
            var result = lexeme.GetImmediateValue("0b01010101");
            Assert.AreEqual(85, result);
        }

        [Test]
        public void DecimalLexemeParsedCorrectly()
        {
            var lexeme = new ImmediateValueLexer();
            var result = lexeme.GetImmediateValue("01010101");
            Assert.AreEqual(1010101, result);
        }

        [Test]
        public void HexadecimalLexemeParsedCorrectly()
        {
            var lexeme = new ImmediateValueLexer();
            var result = lexeme.GetImmediateValue("01010101h");
            Assert.AreEqual(16843009, result);
        }

        [Test]
        public void NegativeTestForGetImmediateValueMethod()
        {
            var lexeme = new ImmediateValueLexer();
            var result = lexeme.GetImmediateValue("DAFFODILS!");
            Assert.IsNull(result);
        }

        [Test]
        public void EmptyStringDoesNotParse()
        {
            var lexeme = new ImmediateValueLexer();
            var result = lexeme.GetImmediateValue("");
            Assert.IsNull(result);
        }

        [Test]
        public void OverflowTest()
        {
            var lexeme = new ImmediateValueLexer();
            var result = lexeme.GetImmediateValue("0xFFFFFFFFFFFFFFFFFF");
            Assert.IsNull(result);
        }
    }
}
