namespace Lab_2.Task_3
{
    class Book
    {
        private Title _title;
        private Author _author;
        private Content _content;

        public Book(string title, string author, string content)
        {
            _title = new Title(title);
            _author = new Author(author);
            _content = new Content(content);
        }

        public void Show()
        {
            _title.Show();
            _author.Show();
            _content.Show();
        }
    }
}
