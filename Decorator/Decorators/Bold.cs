using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Bold : HTMLGenerator
    {
        public Bold(IDecorator textInput) : base(textInput)
        {
            HtmlTag = "b";
        }
    }
}
