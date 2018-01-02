namespace Proxima.Assembler.ImmediateValueParsers
{
    public sealed class DecimalImmediateValueConverter : IImmediateValueConverter
    {
        public ulong Convert(string rawLexeme)
        {
            return System.Convert.ToUInt64(rawLexeme.Replace("d", "").Replace("_", ""), 10);
        }
    }
}
