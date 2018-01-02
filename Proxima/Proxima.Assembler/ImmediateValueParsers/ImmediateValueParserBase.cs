namespace Proxima.Assembler.ImmediateValueParsers
{
    public abstract class ImmediateValueParserBase : IImmediateValueParser
    {
        protected IImmediateValueValidator Validator = null;
        protected IImmediateValueConverter Converter = null;

        public (bool, ulong?) ParseLexeme(string rawLexeme)
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
