namespace Proxima.Assembler.ImmediateValueParsers
{
    public class HexadecimalImmediateValueParser : ImmediateValueParserBase
    {
        public HexadecimalImmediateValueParser()
        {
            Validator = new HexadecimalImmediateValueValidator();
            Converter = new HexadecimalImmediateValueConverter();
        }
    }
}
