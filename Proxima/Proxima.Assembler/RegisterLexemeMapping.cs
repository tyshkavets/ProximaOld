using System;
using System.Collections.Generic;
using Proxima.Assembler.LexemeConstants;

namespace Proxima.Assembler
{
    public static class RegisterLexemeMapping
    {
        private static Dictionary<String, uint> _registerLexemeMapping = new Dictionary<string, uint>
        {
            {RegisterLexemeConstants.A, 0x01},
            {RegisterLexemeConstants.B, 0x02},
            {RegisterLexemeConstants.C, 0x03},
            {RegisterLexemeConstants.I, 0x04},
            {RegisterLexemeConstants.J, 0x05},
            {RegisterLexemeConstants.X, 0x06},
            {RegisterLexemeConstants.Y, 0x07},
            {RegisterLexemeConstants.Z, 0x08},
            {RegisterLexemeConstants.Sp, 0x09},
            {RegisterLexemeConstants.Pc, 0x0A},
            {RegisterLexemeConstants.Ex, 0x0B},
            {RegisterLexemeConstants.Flags, 0x0F},
        };

        private static Dictionary<uint, String> _reverseMapping = new Dictionary<uint, string>();

        static RegisterLexemeMapping()
        {
            foreach (var registerLexemeIndexPair in _registerLexemeMapping)
            {
                _reverseMapping.Add(registerLexemeIndexPair.Value, registerLexemeIndexPair.Key);
            }
        }

        public static bool IsRegisterLexeme(String lexeme)
        {
            return _registerLexemeMapping.ContainsKey(lexeme);
        }

        public static bool IsRegisterIndex(uint index)
        {
            return _reverseMapping.ContainsKey(index);
        }

        public static uint GetRegisterIndexByLexeme(String lexeme)
        {
            return _registerLexemeMapping[lexeme];
        }

        public static String GetRegisterLexemeByIndex(uint index)
        {
            return _reverseMapping[index];
        }
    }
}
