using Proxima.Assembler.ImmediateValues.Converters;
using Proxima.Assembler.ImmediateValues.Validators;

namespace Proxima.Assembler.ImmediateValues.Parsers
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
