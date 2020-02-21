using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Validation
    {
        public static bool IsYesOrNo(string input)
        {
            return input.Equals("yes", StringComparison.OrdinalIgnoreCase)
                 || input.Equals("no", StringComparison.OrdinalIgnoreCase);
            
        }
    }
}
