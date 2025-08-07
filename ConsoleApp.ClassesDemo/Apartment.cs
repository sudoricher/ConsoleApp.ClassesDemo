using System;

namespace ConsoleApp.ClassesDemo
{
    public class Apartment
    {
        public int UnitNumber;
        public int Floor;
        public int NumberOfRooms;

        public Apartment(int unitNumber, int floor, int numberOfRooms) {
            //You can go without "this." keyword, but it's a good practice to use it
            Floor = floor;
            UnitNumber = unitNumber; 
            NumberOfRooms = numberOfRooms;
        }
        public void displayInfo()
        {
            Console.WriteLine($"Apartment {UnitNumber} on floor {Floor} has {NumberOfRooms} rooms.");
        }

    }
    
}
