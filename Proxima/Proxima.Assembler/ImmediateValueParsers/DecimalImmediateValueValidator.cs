using System.Collections.Generic;

namespace Proxima.Assembler.ImmediateValueParsers
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
            var isInvalidSymbolFound = false;

            var trimmedLexeme = rawLexeme;
            if (trimmedLexeme.EndsWith("d"))
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
