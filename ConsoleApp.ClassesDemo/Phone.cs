using System;

namespace ConsoleApp.ClassesDemo
{
    public class Phone
    {
        public string brand = "Samsung";
        public string model;
        public bool isSmartphone;

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
