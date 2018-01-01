using System;
using System.Collections.Generic;
using Proxima.Assembler.Exceptions;
using Proxima.Assembler.LexemeConstants;

namespace Proxima.Assembler
{
    public static class OpcodeLexemeMapping
    {
        private static Dictionary<String, uint> _opcodeLexemeMapping = new Dictionary<string, uint>
        {
            {OpcodeLexemeConstants.Mov, 0x01},
            {OpcodeLexemeConstants.Add, 0x02},
            {OpcodeLexemeConstants.Sub, 0x03},
            {OpcodeLexemeConstants.Mul, 0x04},
            {OpcodeLexemeConstants.Mli, 0x05},
            {OpcodeLexemeConstants.Div, 0x06},
            {OpcodeLexemeConstants.Dvi, 0x07},
            {OpcodeLexemeConstants.Mod, 0x08},
            {OpcodeLexemeConstants.Mdi, 0x09},
            {OpcodeLexemeConstants.And, 0x0A},
            {OpcodeLexemeConstants.Bor, 0x0B},
            {OpcodeLexemeConstants.Xor, 0x0C},
            {OpcodeLexemeConstants.Lsh, 0x0D},
            {OpcodeLexemeConstants.Rsh, 0x0E},
            {OpcodeLexemeConstants.Arsh, 0x0F},

            {OpcodeLexemeConstants.Cmp, 0x10},
            {OpcodeLexemeConstants.Test, 0x11},
            {OpcodeLexemeConstants.Jeq, 0x12},
            {OpcodeLexemeConstants.Jneq, 0x13},
            {OpcodeLexemeConstants.Jb, 0x14},
            {OpcodeLexemeConstants.Jbeq, 0x15},
            {OpcodeLexemeConstants.Ja, 0x16},
            {OpcodeLexemeConstants.Jaeq, 0x17},
            {OpcodeLexemeConstants.Jl, 0x18},
            {OpcodeLexemeConstants.Jleq, 0x19},
            {OpcodeLexemeConstants.Jg, 0x1A},
            {OpcodeLexemeConstants.Jgeq, 0x1B},
            {OpcodeLexemeConstants.Jsz, 0x1C},
            {OpcodeLexemeConstants.Jsnz, 0x1D},
            {OpcodeLexemeConstants.Joz, 0x1E},
            {OpcodeLexemeConstants.Jonz, 0x1F},

            {OpcodeLexemeConstants.Jcz, 0x20},
            {OpcodeLexemeConstants.Jcnz, 0x21},
            {OpcodeLexemeConstants.Jpz, 0x22},
            {OpcodeLexemeConstants.Jpnz, 0x23},
            {OpcodeLexemeConstants.Jiz, 0x24},
            {OpcodeLexemeConstants.Jinz, 0x25},
            {OpcodeLexemeConstants.Jjz, 0x26},
            {OpcodeLexemeConstants.Jjnz, 0x27},

            {OpcodeLexemeConstants.Nop, 0x30},
            {OpcodeLexemeConstants.Jmp, 0x31},
            {OpcodeLexemeConstants.Call, 0x32},
            {OpcodeLexemeConstants.Ret, 0x33},

            {OpcodeLexemeConstants.Inc, 0x40},
            {OpcodeLexemeConstants.Faa, 0x41},
            {OpcodeLexemeConstants.Tsl, 0x42},
        };

        public static uint GetOpcodeByLexeme(String lexeme)
        {
            if (!_opcodeLexemeMapping.ContainsKey(lexeme))
            {
                throw new UnknownOpcodeLexemeException($"Unknown opcode lexeme {lexeme}");
            }

            return _opcodeLexemeMapping[lexeme];
        }
    }
}
