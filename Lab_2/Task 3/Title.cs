using System;

namespace Lab_2.Task_3
{
    public class Title
    {
        private readonly string _text;
        public Title(string text) => _text = text;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}