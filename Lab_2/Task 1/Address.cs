using System;

namespace Lab_2.Task_1
{
    class Address
    {
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }

        public void Info() => Console.WriteLine($"Address: {House} / {Apartment} {Street}, {City}, {Index}, {Country}.");
    }
}
