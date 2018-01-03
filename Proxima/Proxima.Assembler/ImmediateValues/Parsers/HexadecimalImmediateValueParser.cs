using Proxima.Assembler.ImmediateValues.Converters;
using Proxima.Assembler.ImmediateValues.Validators;

namespace Proxima.Assembler.ImmediateValues.Parsers
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
