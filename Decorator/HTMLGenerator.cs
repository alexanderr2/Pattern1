using Design_Patterns_Assignment.Decorator;
using System;

namespace Design_Patterns_Assignment
{
    class HTMLGenerator : IDecorator
    {
        IDecorator Text { get; set; }

        public string HtmlTag { get; set; }

        public HTMLGenerator(IDecorator text)
        {
            Text = text;
        }

        public string GetDecor()
        {
            return "<" + HtmlTag + ">" + Text.GetDecor() + "</" + HtmlTag + ">";
        }


        internal static string TagProcessor(string tagSelection, string textInput)
        {
            tagSelection = tagSelection.ToLower();
            var taglist = tagSelection.Split(' ');
            foreach (var tag in taglist)
            {
                if (tag=="bold")
                {
                    textInput = "<b>" + textInput + "</b>";
                }
                if (tag == "deleted")
                {
                    textInput = "<del>" + textInput + "</del>";
                }
                if (tag == "emphasized")
                {
                    textInput = "<em>" + textInput + "</em>";
                }
                if (tag == "important")
                {
                    textInput = "<strong>" + textInput + "</strong>";
                }
                if (tag == "inserted")
                {
                    textInput = "<ins>" + textInput + "</ins>";
                }
                if (tag == "italic")
                {
                    textInput = "<i>" + textInput + "</i>";
                }
                if (tag == "marked")
                {
                    textInput = "<mark>" + textInput + "</mark>";
                }
                if (tag == "smaller")
                {
                    textInput = "<small>" + textInput + "</small>";
                }
                if (tag == "subscript")
                {
                    textInput = "<sub>" + textInput + "</sub>";
                }
                if (tag == "superscript")
                {
                    textInput = "<sup>" + textInput + "</sup>";
                }
            }
            return textInput;
        }
    }
}