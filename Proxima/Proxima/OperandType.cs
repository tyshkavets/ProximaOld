namespace Proxima
{
    public enum OperandType
    {
        // Reserved value 0x0
        ImmediateByte = 0x1,
        ImmediateWord = 0x2,
        ImmediateDword = 0x3,
        // Reserved value 0x4
        Register = 0x5,
        MemoryCell = 0x6,
        // Reserved value 0x7
        PcOffsetByte = 0x8,
        PcOffsetWord = 0x9,
        PcOffsetDword = 0xA,
        // Reserved value 0xB
        MemoryAddressInRegister = 0xC,
        PcOffsetInRegister = 0xD,
        // Reserved value 0xE
        // Reserved value 0xF
    }
}
