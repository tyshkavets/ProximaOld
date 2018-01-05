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
            return IsValidPrefixForm(rawLexeme) ^ IsValidPostfixForm(rawLexeme);
        }

        private bool IsValidPrefixForm(string rawLexeme)
        {
            var prefixFound = rawLexeme.StartsWith("0b") && rawLexeme.Length > 2;
            if (!prefixFound)
            {
                return false;
            }

            var trimmedLexeme = rawLexeme.Substring(2);
            return CheckAllowedDigits(trimmedLexeme);
        }

        private bool IsValidPostfixForm(string rawLexeme)
        {
            var postfixFound = rawLexeme.EndsWith("b") && rawLexeme.Length > 1;
            if (!postfixFound)
            {
                return false;
            }

            var trimmedLexeme = rawLexeme.Substring(0, rawLexeme.Length - 1);
            return CheckAllowedDigits(trimmedLexeme);
        }
        
        private bool CheckAllowedDigits(string lexeme)
        {
            var isInvalidSymbolFound = false;
            
            foreach (var character in lexeme.ToCharArray())
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
