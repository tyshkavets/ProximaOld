using NUnit.Framework;
using Proxima.Assembler.ImmediateValues.Validators;

namespace Proxima.Tests.Assembler.ImmediateValues.Converters
{
    public class HexadecimalImmediateValueValidatorTests
    {
        [Test]
        public void CorrectPrefixFormIsValid()
        {
            var validator = new HexadecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("0x1234ABCD");
            Assert.IsTrue(result);
        }

        [Test]
        public void UnderscoresAreValid()
        {
            var validator = new HexadecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("0x1234_ABCD");
            Assert.IsTrue(result);
        }

        [Test]
        public void CorrectPostfixFormIsValid()
        {
            var validator = new HexadecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("1234ABCDh");
            Assert.IsTrue(result);
        }

        [Test]
        public void BothLowerAndUpperCaseLettersAreAllowed()
        {
            var validator = new HexadecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("1234AbCdh");
            Assert.IsTrue(result);
        }

        [Test]
        public void InvalidDigitsAreDetected()
        {
            var validator = new HexadecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("Gh");
            Assert.IsFalse(result);
        }

        [Test]
        public void EitherPostfixOrPrefixAreRequired()
        {
            var validator = new HexadecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("1234ABCD");
            Assert.IsFalse(result);
        }

        [Test]
        public void BothPostfixAndPrefixAtTheSameTimeAreInvalid()
        {
            var validator = new HexadecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("0x1234ABCDh");
            Assert.IsFalse(result);
        }

        [Test]
        public void EmptyPrefixFormIsInvalid()
        {
            var validator = new HexadecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("0x");
            Assert.IsFalse(result);
        }

        [Test]
        public void EmptyPostfixFormIsInvalid()
        {
            var validator = new HexadecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("h");
            Assert.IsFalse(result);
        }

        [Test]
        public void SmallestPossiblePrefixHexLexemeIsValid()
        {
            var validator = new HexadecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("0x0");
            Assert.IsTrue(result);
        }

        [Test]
        public void SmallestPossiblePostfixHexLexemeIsValid()
        {
            var validator = new HexadecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("0h");
            Assert.IsTrue(result);
        }

        [Test]
        public void EmptyPrefixAndPostfixFormIsInvalid()
        {
            var validator = new HexadecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("0xh");
            Assert.IsFalse(result);
        }
    }
}
