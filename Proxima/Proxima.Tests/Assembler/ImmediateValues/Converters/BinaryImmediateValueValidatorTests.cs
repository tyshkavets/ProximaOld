using NUnit.Framework;
using Proxima.Assembler.ImmediateValues.Validators;

namespace Proxima.Tests.Assembler.ImmediateValues.Converters
{
    public class BinaryImmediateValueValidatorTests
    {
        [Test]
        public void CorrectPrefixFormIsValid()
        {
            var validator = new BinaryImmediateValueValidator();
            var result = validator.IsValidLexeme("0b11110000");
            Assert.IsTrue(result);
        }

        [Test]
        public void UnderscoresAreValid()
        {
            var validator = new BinaryImmediateValueValidator();
            var result = validator.IsValidLexeme("0b1111_0000");
            Assert.IsTrue(result);
        }

        [Test]
        public void CorrectPostfixFormIsValid()
        {
            var validator = new BinaryImmediateValueValidator();
            var result = validator.IsValidLexeme("11110000b");
            Assert.IsTrue(result);
        }

        [Test]
        public void InvalidDigitsAreDetected()
        {
            var validator = new BinaryImmediateValueValidator();
            var result = validator.IsValidLexeme("2b");
            Assert.IsFalse(result);
        }

        [Test]
        public void EitherPostfixOrPrefixAreRequired()
        {
            var validator = new BinaryImmediateValueValidator();
            var result = validator.IsValidLexeme("01010101");
            Assert.IsFalse(result);
        }

        [Test]
        public void BothPostfixAndPrefixAtTheSameTimeAreInvalid()
        {
            var validator = new BinaryImmediateValueValidator();
            var result = validator.IsValidLexeme("0b11110000b");
            Assert.IsFalse(result);
        }

        [Test]
        public void EmptyPostfixFormIsInvalid()
        {
            var validator = new BinaryImmediateValueValidator();
            var result = validator.IsValidLexeme("b");
            Assert.IsFalse(result);
        }

        [Test]
        public void SmallestPossibleBinaryLexemeIsValid()
        {
            var validator = new BinaryImmediateValueValidator();
            var result = validator.IsValidLexeme("0b");
            Assert.IsTrue(result);
        }

        [Test]
        public void EmptyPrefixAndPostfixFormIsInvalid()
        {
            var validator = new BinaryImmediateValueValidator();
            var result = validator.IsValidLexeme("0bb");
            Assert.IsFalse(result);
        }
    }
}
