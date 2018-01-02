namespace Proxima.Assembler.ImmediateValueParsers
{
    public sealed class BinaryImmediateValueParser : ImmediateValueParserBase
    {
        public BinaryImmediateValueParser()
        {
            Validator = new BinaryImmediateValueValidator();
            Converter = new BinaryImmediateValueConverter();
        }
    }
}
