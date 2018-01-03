namespace Proxima.Assembler.ImmediateValues.Validators
{
    public interface IImmediateValueValidator
    {
        bool IsValidLexeme(string rawLexeme);
    }
}