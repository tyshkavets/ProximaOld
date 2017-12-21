using System;
using System.Text.RegularExpressions;

namespace Proxima.Assembler
{
    public class LineLexer
    {
        public void JustToSaveItBeforeILostItCompletely()
        {
            string s1;

            // TODO: Move to tests
            s1 = @" label: MOV A, 43 //test";
            s1 = @"";
            s1 = @"NOP";
            s1 = @"JMP label // unconditional jump";
            s1 = @"label_on_empty_string:";
            s1 = @"// comment only";

            var parseSingleLineRegex = new Regex(@"^(\s*(\w+)*\s*:)?\s*(\w+)?\s*([\w,\s]+)*\s*(//.*)?$");

            var isMatch = parseSingleLineRegex.IsMatch(s1);
            
            MatchCollection allMatches = parseSingleLineRegex.Matches(s1);
            if (allMatches.Count > 0)
            {
                foreach (Match someMatch in allMatches)
                {
                    Console.WriteLine("Label Lexeme: " + someMatch.Groups[2].Value);
                    Console.WriteLine("Operation: " + someMatch.Groups[3].Value);
                    Console.WriteLine("Operands: " + someMatch.Groups[4].Value);
                    Console.WriteLine("Comment: " + someMatch.Groups[5].Value);
                }
            }
        }
    }
}
