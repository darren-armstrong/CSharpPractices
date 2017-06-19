using CSharpPractices.UserInput;
using Xunit;

namespace CSharpPractices.Tests
{
    public class UserInputTest
    {
        /* Task Requirements
            User interface contains two types of user input controls: TextInput, 
            which accepts all characters and NumericInput, which accepts only digits.

            Implement the class TextInput that contains:

            Public method void add(char c) - adds the given character to the current value
            Public method String getValue() - returns the current value
            Implement the class NumericInput that:

            Inherits from TextInput
            Overrides the add method so that each non-numeric character is ignored
            For example, the following code should output "10":
                TextInput input = new NumericInput();
                input.add('1');
                input.add('a');
                input.add('0');
                System.out.println(input.getValue());
        */

        [Fact]
        public void GetValueFromTextInput()
        {
            TextInput input = new TextInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');

            Assert.Equal("1a0", input.GetValue());
        }

        [Fact]
        public void GetValueFromNumericInput()
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');

            Assert.Equal("10", input.GetValue());
        }

        [Fact]
        public void GetValueFromTextInputWithWhitespaceChar()
        {
            TextInput input = new TextInput();
            input.Add(' ');

            Assert.Equal(" ", input.GetValue());
        }

        [Fact]
        public void GetValueFromNumericInputWithWhitespaceChar()
        {
            TextInput input = new NumericInput();
            input.Add(' ');

            Assert.Equal("", input.GetValue());
        }

    }
}
