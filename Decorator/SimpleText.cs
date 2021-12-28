using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    class SimpleText : IDecorator
    {
        public string Text { get; set; }
        public SimpleText(string textInput)
        {
            Text = textInput;
        }

        public string GetDecor()
        {
            return Text;
        }
    }
}
