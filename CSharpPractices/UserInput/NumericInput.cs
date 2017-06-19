using System;

namespace CSharpPractices.UserInput
{
    public class NumericInput : TextInput
    {
        public override void Add(char input)
        {
            if (Char.IsDigit(input))
            {
                Builder.Append(input);
            }
        }
    }
}
