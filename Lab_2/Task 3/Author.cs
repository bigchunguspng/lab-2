using System;

namespace Lab_2.Task_3
{
    public class Author
    {
        private readonly string _text;
        public Author(string text) => _text = text;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(_text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}