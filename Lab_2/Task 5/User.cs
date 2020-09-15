using System;

namespace Lab_2.Task_5
{
    class User
    {
        private readonly string _login;
        private readonly string _name;
        private readonly string _lastname;
        private readonly int _age;
        private readonly DateTime _date;

        public User(string login, string name, string lastname, int age)
        {
            _login = login;
            _name = name;
            _lastname = lastname;
            _age = age;
            _date = DateTime.UtcNow;
        }

        public void Info()
        {
            Console.WriteLine($"@{_login} | {_name} {_lastname}, {_age} y.o.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Joined: {_date:dd MM yyyy}");
            Console.ResetColor();
        }
    }
}
