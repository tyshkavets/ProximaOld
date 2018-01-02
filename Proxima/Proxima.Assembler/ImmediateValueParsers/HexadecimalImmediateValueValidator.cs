using System;
using System.Collections.Generic;

namespace Proxima.Assembler.ImmediateValueParsers
{
    // Hexadecimal value is okay if
    // 1) It either starts with 0x or ends with h, but not both simultaneously.
    // 2) It consists only of hexadecimal digits, both upper and lower cases are allowed.
    // 3) It may contain underscores between digits.
    public sealed class HexadecimalImmediateValueValidator : IImmediateValueValidator
    {
        private static readonly List<char> allowedSymbols = new List<char>
        {
            '_', // underscore is allowed to be used as a separator between digits for readability purposes
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', // decimal digits
            'A', 'B', 'C', 'D', 'E', 'F', // uppercase hexadecimal digits
            'a', 'b', 'c', 'd', 'e', 'f' // lowercase hexadecimal digits
        };

        public bool IsValidLexeme(String rawLexeme)
        {
            return CheckAllowedDigits(rawLexeme) && CheckPostfixAndPrefix(rawLexeme);
        }

        private bool CheckPostfixAndPrefix(String rawLexeme)
        {
            var prefixFound = rawLexeme.StartsWith("0x");
            var postfixFound = rawLexeme.EndsWith("h");
            return prefixFound ^ postfixFound;
        }

        private bool CheckAllowedDigits(String rawLexeme)
        {
            var isInvalidSymbolFound = false;

            var trimmedLexeme = rawLexeme;
            if (trimmedLexeme.StartsWith("0x"))
            {
                trimmedLexeme = trimmedLexeme.Substring(2);
            }
            if (trimmedLexeme.EndsWith("h"))
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
