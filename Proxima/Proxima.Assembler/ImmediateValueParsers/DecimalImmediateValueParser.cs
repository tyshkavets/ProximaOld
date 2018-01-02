namespace Proxima.Assembler.ImmediateValueParsers
{
    public class DecimalImmediateValueParser : ImmediateValueParserBase
    {
        public DecimalImmediateValueParser()
        {
            Validator = new DecimalImmediateValueValidator();
            Converter = new DecimalImmediateValueConverter();
        }
    }
}
