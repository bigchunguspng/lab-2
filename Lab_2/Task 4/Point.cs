namespace Lab_2.Task_4
{
    class Point
    {
        public double X { get; }
        public double Y { get; }
        public string Text { get; }

        private static int _charCount = 65;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
            Text = ((char)_charCount).ToString();
            _charCount++;
        }
    }
}
