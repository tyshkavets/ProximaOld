using System.Collections.Generic;

namespace Proxima.Assembler.ImmediateValues.Validators
{
    // Binary value is okay if
    // 1) It either starts with 0b or ends with b, but not both simultaneously.
    // 2) It consists only of 0 and 1.
    // 3) It may contain underscores between digits.
    public sealed class BinaryImmediateValueValidator : IImmediateValueValidator
    {
        private static readonly List<char> allowedSymbols = new List<char> {'_', '0', '1'};

        public bool IsValidLexeme(string rawLexeme)
        {
            return CheckAllowedDigits(rawLexeme) && CheckPostfixAndPrefix(rawLexeme);
        }

        private bool CheckPostfixAndPrefix(string rawLexeme)
        {
            var prefixFound = rawLexeme.StartsWith("0b");
            var postfixFound = rawLexeme.EndsWith("b");
            return prefixFound ^ postfixFound;
        }

        private bool CheckAllowedDigits(string rawLexeme)
        {
            var isInvalidSymbolFound = false;

            var trimmedLexeme = rawLexeme;
            if (trimmedLexeme.StartsWith("0b"))
            {
                trimmedLexeme = trimmedLexeme.Substring(2);
            }
            if (trimmedLexeme.EndsWith("b"))
            {
                trimmedLexeme = trimmedLexeme.Substring(0, rawLexeme.Length - 1);
            }

            foreach (var character in trimmedLexeme.ToCharArray())
            {
                if (!allowedSymbols.Contains(character))
                {
                    isInvalidSymbolFound = true;
                }
            }

            return !isInvalidSymbolFound;
        }
    }
}
