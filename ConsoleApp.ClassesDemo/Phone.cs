using System;

namespace ConsoleApp.ClassesDemo
{
    public class Phone
    {
        public string brand;
        public string model;
        public bool isSmartphone;

        public Phone(string brand, string model, bool isSmartphone)
        {
            this.brand = brand;
            this.model = model;
            this.isSmartphone = isSmartphone;
        }
        public void ringTone()
        {
            if (isSmartphone)
            {
                Console.WriteLine($"My {brand} {model} plays music as a ringtone");
            }
            else
            {
                Console.WriteLine($"My {brand} {model} goes tring tring");
            }
        }
    }
    
}
