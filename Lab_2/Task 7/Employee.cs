using System;

namespace Lab_2.Task_7
{
    public class Employee
    {
        public static string[] Positions = {"Junior", "Middle", "Senior", "Team Lead", "Architect", "Project Manager", "Product Manager", "Senior Leadership"};
        public static double IncomeTax = 0.10;
        
        private string _name, _lastname;
        public int Experience { get; set; }
        public string Position { get; set; }

        public Employee(string name, string lastname, int experience, string position)
        {
            _name = name;
            _lastname = lastname;
            Experience = experience;
            Position = position;
        }

        public double Salary()
        {
            int positionRank = 0;
            for (int i = 0; i < Positions.Length; i++)
                if (Positions[i].Equals(Position))
                    positionRank = i;
            return 3000 * Math.Pow(1.2, positionRank + Experience);
        }

        public double Tax(double salary) => salary * IncomeTax;

        public void Info()
        {
            Console.WriteLine(nameof(Employee));
            Console.WriteLine($"{_name} {_lastname}");
            Console.WriteLine(Position);
            Console.WriteLine($"Salary: ${Salary()}, Tax: ${Tax(Salary())}");
        }
    }
}