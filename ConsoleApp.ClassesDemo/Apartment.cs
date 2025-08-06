using System;

namespace ConsoleApp.ClassesDemo
{
    public class Apartment
    {
        public int unitNumber;
        public int floor;
        public int numberOfRooms;
        public void displayInfo()
        {
            Console.WriteLine($"Apartment {unitNumber} on floor {floor} has {numberOfRooms} rooms.");
        }

    }
    
}
