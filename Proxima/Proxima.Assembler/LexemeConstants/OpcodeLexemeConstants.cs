using System;
using System.Collections.Generic;

namespace Proxima.Assembler.LexemeConstants
{
    public class OpcodeLexemeConstants
    {
        public const String Mov = "MOV";
        public const String Add = "ADD";
        public const String Sub = "SUB";
        public const String Mul = "MUL";
        public const String Mli = "MLI";
        public const String Div = "DIV";
        public const String Dvi = "DVI";
        public const String Mod = "MOD";
        public const String Mdi = "MDI";
        public const String And = "AND";
        public const String Bor = "BOR";
        public const String Xor = "XOR";
        public const String Lsh = "LSH";
        public const String Rsh = "RSH";
        public const String Arsh = "ARSH";

        public const String Cmp = "CMP";
        public const String Test = "TEST";
        public const String Jeq = "JEQ";
        public const String Jneq = "JNEQ";
        public const String Jb = "JB";
        public const String Jbeq = "JBEQ";
        public const String Ja = "JA";
        public const String Jaeq = "JAEQ";
        public const String Jl = "JL";
        public const String Jleq = "JLEQ";
        public const String Jg = "JG";
        public const String Jgeq = "JGEQ";
        public const String Jsz = "JSZ";
        public const String Jsnz = "JSNZ";
        public const String Joz = "JOZ";
        public const String Jonz = "JONZ";

        public const String Jcz = "JCZ";
        public const String Jcnz = "JCNZ";
        public const String Jpz = "JPZ";
        public const String Jpnz = "JPNZ";
        public const String Jiz = "JIZ";
        public const String Jinz = "JINZ";
        public const String Jjz = "JJZ";
        public const String Jjnz = "JJNZ";

        public const String Nop = "NOP";
        public const String Jmp = "JMP";
        public const String Call = "CALL";
        public const String Ret = "RET";

        public const String Inc = "INC";
        public const String Faa = "FAA";
        public const String Tsl = "TSL";

        public static List<String> GetAllOpcodeLexemes()
        {
            return new List<String>()
            {
                Mov,
                Add,
                Sub,
                Mul,
                Mli,
                Div,
                Dvi,
                Mod,
                Mdi,
                And,
                Bor,
                Xor,
                Lsh,
                Rsh,
                Arsh,
                Cmp,
                Test,
                Jeq,
                Jneq,
                Jb,
                Jbeq,
                Ja,
                Jaeq,
                Jl,
                Jleq,
                Jg,
                Jgeq,
                Jsz,
                Jsnz,
                Joz,
                Jonz,
                Jcz,
                Jcnz,
                Jpz,
                Jpnz,
                Jiz,
                Jinz,
                Jjz,
                Jjnz,
                Nop,
                Jmp,
                Call,
                Ret,
                Inc,
                Faa,
                Tsl
            };
        }
    }
}
