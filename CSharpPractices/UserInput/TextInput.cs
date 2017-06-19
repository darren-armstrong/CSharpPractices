using System;
using System.Text;

namespace CSharpPractices.UserInput
{
    public class TextInput
    {
        protected readonly StringBuilder Builder = new StringBuilder();
        
        public virtual void Add(char input)
        {
            Builder.Append(input);
        }

        public String GetValue()
        {
            return Builder.ToString();
        }

    }
}
