using NUnit.Framework;
using Proxima.Assembler.ImmediateValues.Validators;

namespace Proxima.Tests.Assembler.ImmediateValues.Validators
{
    public class DecimalImmediateValueValidatorTests
    {
        [Test]
        public void CorrectNoAffixFormIsValid()
        {
            var validator = new DecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("12345678");
            Assert.IsTrue(result);
        }

        [Test]
        public void UnderscoresAreValid()
        {
            var validator = new DecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("1234_5678");
            Assert.IsTrue(result);
        }

        [Test]
        public void CorrectPostfixFormIsValid()
        {
            var validator = new DecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("12345678d");
            Assert.IsTrue(result);
        }

        [Test]
        public void InvalidDigitsAreDetected()
        {
            var validator = new DecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("1234ABCD");
            Assert.IsFalse(result);
        }
        
        [Test]
        public void EmptyPostfixFormIsInvalid()
        {
            var validator = new DecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("d");
            Assert.IsFalse(result);
        }

        [Test]
        public void SmallestPossibleDecimalLexemeIsValid()
        {
            var validator = new DecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("0");
            Assert.IsTrue(result);
        }

        [Test]
        public void EmptyStringIsInvalid()
        {
            var validator = new DecimalImmediateValueValidator();
            var result = validator.IsValidLexeme("");
            Assert.IsFalse(result);
        }
    }
}
