﻿namespace Proxima
{
    public class ProcessorState
    {
        private uint _a;
        private uint _b;
        private uint _c;

        private uint _i;
        private uint _j;

        private uint _x;
        private uint _y;
        private uint _z;

        private uint _sp;
        private uint _pc;
        private uint _ex;

        private uint _flags;

        /// <summary>
        /// General Purpose Register A
        /// </summary>
        public uint A
        {
            get { return _a; }
            set { _a = value; }
        }

        public uint B
        {
            get { return _b; }
            set { _b = value; }
        }

        /// <summary>
        /// General Purpose Register C
        /// </summary>
        public uint C
        {
            get { return _c; }
            set { _c = value; }
        }

        /// <summary>
        /// General Purpose Register I
        /// </summary>
        public uint I
        {
            get { return _i; }
            set { _i = value; }
        }

        /// <summary>
        /// General Purpose Register J
        /// </summary>
        public uint J
        {
            get { return _j; }
            set { _j = value; }
        }

        /// <summary>
        /// General Purpose Register X
        /// </summary>
        public uint X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// General Purpose Register Y
        /// </summary>
        public uint Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// General Purpose Register Z
        /// </summary>
        public uint Z
        {
            get { return _z; }
            set { _z = value; }
        }

        /// <summary>
        /// Stack Pointer Register SP
        /// </summary>
        public uint SP
        {
            get { return _sp; }
            set { _sp = value; }
        }
        
        /// <summary>
        /// Program Counter Register PC
        /// </summary>
        public uint PC
        {
            get { return _pc; }
            set { _pc = value; }
        }

        /// <summary>
        /// Excess Register EX
        /// </summary>
        public uint EX
        {
            get { return _ex; }
            set { _ex = value; }
        }

        /// <summary>
        /// Flags Register FLAGS
        /// </summary>
        public uint FLAGS
        {
            get { return _flags; }
            set { _flags = value; }
        }
    }
}
