using System.Collections.Generic;

namespace Proxima.Assembler.ImmediateValues.Validators
{
    // 1) 10 decimal digits are allowed
    // 2) Underscore is allowed to be used as a separator between digits for readability
    // 3) Optional postfix "d" for clarity is allowed
    public sealed class DecimalImmediateValueValidator : IImmediateValueValidator
    {
        private static readonly List<char> allowedSymbols =
            new List<char> {'_', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

        public bool IsValidLexeme(string rawLexeme)
        {
            return IsValidNoAffixForm(rawLexeme) ^ IsValidPostfixForm(rawLexeme);
        }

        private bool IsValidNoAffixForm(string rawLexeme)
        {
            if (rawLexeme.Length == 0)
            {
                return false;
            }

            return CheckAllowedDigits(rawLexeme);
        }

        private bool IsValidPostfixForm(string rawLexeme)
        {
            if (rawLexeme.EndsWith("d") && rawLexeme.Length > 1)
            {
                return CheckAllowedDigits(rawLexeme.Substring(0, rawLexeme.Length - 1));
            }

            return false;
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