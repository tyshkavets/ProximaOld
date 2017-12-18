namespace Proxima.Utilities
{
    public static class ByteArrayExtensions
    {
        public static ushort GetWordValue(this byte[] array, uint index)
        {
            return (ushort)((array[index] << 8) + array[index + 1]);
        }

        public static uint GetDwordValue(this byte[] array, uint index)
        {
            return (uint)((array[index] << 24) + (array[index + 1] << 16) + (array[index + 2] << 8) + array[index+3]);
        }
    }
}
