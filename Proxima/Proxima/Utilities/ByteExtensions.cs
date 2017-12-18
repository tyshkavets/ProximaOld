namespace Proxima.Utilities
{
    public static class ByteExtensions
    {
        public static byte GetFourMostSignificantBits(this byte value)
        {
            return (byte)(value >> 4);
        }

        public static byte GetFourLeastSignificantBits(this byte value)
        {
            return (byte)(value & 0b0000_1111);
        }
    }
}
