using System;
using System.Collections.Generic;
using Proxima.Assembler.ImmediateValues.Parsers;

namespace Proxima.Assembler.ImmediateValues
{
    public class ImmediateValueLexer
    {
        // TODO: byte/word/dword options

        private readonly List<IImmediateValueParser> _supportedParsers =
            new List<IImmediateValueParser>
            {
                new BinaryImmediateValueParser(),
                new HexadecimalImmediateValueParser(),
                new DecimalImmediateValueParser()
            };

        public bool IsImmediateValue(string rawLexeme)
        {
            foreach (var parser in _supportedParsers)
            {
                try
                {
                    var result = parser.ParseLexeme(rawLexeme);
                    if (result.CanBeParsed)
                    {
                        return true;
                    }
                }
                catch (OverflowException)
                {
                    return false;
                }
            }

            return false;
        }

        public ulong? GetImmediateValue(string rawLexeme)
        {
            foreach (var parser in _supportedParsers)
            {
                try
                {
                    var result = parser.ParseLexeme(rawLexeme);
                    if (result.CanBeParsed)
                    {
                        return result.Value;
                    }
                }
                catch (OverflowException)
                {
                    return null;
                }
            }

            return null;
        }
    }
}