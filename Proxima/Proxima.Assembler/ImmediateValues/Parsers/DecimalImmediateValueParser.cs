using Proxima.Assembler.ImmediateValues.Converters;
using Proxima.Assembler.ImmediateValues.Validators;

namespace Proxima.Assembler.ImmediateValues.Parsers
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
