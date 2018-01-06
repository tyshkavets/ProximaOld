using Proxima.Assembler.ImmediateValues.Converters;
using Proxima.Assembler.ImmediateValues.Validators;

namespace Proxima.Assembler.ImmediateValues.Parsers
{
    public abstract class ImmediateValueParserBase : IImmediateValueParser
    {
        protected IImmediateValueValidator Validator = null;
        protected IImmediateValueConverter Converter = null;

        public (bool CanBeParsed, ulong? Value) ParseLexeme(string rawLexeme)
        {
            if (!Validator.IsValidLexeme(rawLexeme))
            {
                return (false, null);
            }

            var value = Converter.Convert(rawLexeme);
            return (true, value);
        }
    }
}
