using System;

namespace ConsoleApp.ClassesDemo
{
    public class Phone
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool IsSmartphone { get; set; }
        public Phone(string brand, string model, bool isSmartphone)
        {
            this.Brand = brand;
            this.Model = model;
            this.IsSmartphone = isSmartphone;
        }
        public void ringTone(string tone)
        {
            if (IsSmartphone)
            {
                Console.WriteLine($"My {Brand} {Model} plays {tone} as a ringtone");
            }
            else
            {
                Console.WriteLine($"My {Brand} {Model} goes tring tring");
            }
        }
    }
    
}
