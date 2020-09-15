using System;

namespace Lab_2.Task_3
{
    public class Content
    {
        private readonly string _text;
        public Content(string text) => _text = text;
        public void Show() => Console.WriteLine(_text);
    }
}