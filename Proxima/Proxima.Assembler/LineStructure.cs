using System;

namespace Proxima.Assembler
{
    public class LineStructure
    {
        public String Label { get; set; }
        public String Operation { get; set; }
        public String RawOperands { get; set; }
        public String Comment { get; set; }
    }
}
