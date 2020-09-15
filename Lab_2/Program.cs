using System;
using Lab_2.Task_1;
using Lab_2.Task_2;
using Lab_2.Task_3;
using Lab_2.Task_4;
using Lab_2.Task_5;
using Lab_2.Task_6;
using Lab_2.Task_7;
using Lab_2.Task_8;

namespace Lab_2
{
    class Program
    {
        private static int _task = 1;
        static void Main(string[] args)
        {
            TaskNumber(); //1
            Address address = new Address {Index = "TN 38115", Country = "USA", City = "Memphis", Street = "Elk Grove Rd", House = 6052, Apartment = 6};
            address.Info();

            TaskNumber(); //2
            double[] sides = new double[2];
            for (int i = 0; i < 2; i++)
                do Console.WriteLine("Side {0}", i + 1);
                while (!double.TryParse(Console.ReadLine(), out sides[i]));
            Rectangle rectangle = new Rectangle(sides[0], sides[1]);

            TaskNumber(); //3
            Book book = new Book("How to code?", "unknown", "Hmmmm, I don`t know...");
            book.Show();

            TaskNumber(); //4
            Figure figure = new Figure(new Point(1, 2), new Point(8, 5), new Point(2, 10), new Point(-3, 4));
            Console.WriteLine($"{figure.Name()} perimeter = {figure.PerimeterCalculator()}");

            TaskNumber(); //5
            User u1 = new User("asdfgh123", "John", "Cena", 15);
            u1.Info();

            TaskNumber(); //6
            Converter converter = new Converter(27.855, 32.818, 0.332);
            converter.FromUAH();
            Console.ReadKey();
            converter.ToUAH();

            TaskNumber(); //7
            Employee employee = new Employee("John", "Smith", 2, Employee.Positions[1]);
            employee.Info();
            
            TaskNumber(); //8
            Invoice invoice = new Invoice(3506884, "John Jones", "KFC", "nuggets", 9);
            invoice.Info();
        }

        private static void TaskNumber()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (_task > 1) Console.ReadKey();
            Console.WriteLine($"- Task {_task} -");
            Console.ResetColor();
            _task++;
        }
    }
}
