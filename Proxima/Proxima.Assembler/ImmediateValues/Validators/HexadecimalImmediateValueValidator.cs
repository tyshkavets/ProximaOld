using System.Collections.Generic;

namespace Proxima.Assembler.ImmediateValues.Validators
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

        public bool IsValidLexeme(string rawLexeme)
        {
            return IsValidPrefixLexeme(rawLexeme) ^ IsValidPostfixForm(rawLexeme);
        }

        private bool IsValidPrefixLexeme(string rawLexeme)
        {
            var prefixFound = rawLexeme.StartsWith("0x") && rawLexeme.Length > 2;
            if (!prefixFound)
            {
                return false;
            }

            var trimmedLexeme = rawLexeme.Substring(2);
            return CheckAllowedDigits(trimmedLexeme);
        }

        private bool IsValidPostfixForm(string rawLexeme)
        {
            var postfixFound = rawLexeme.EndsWith("h") && rawLexeme.Length > 1;
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
