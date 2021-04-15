using System;
namespace Inheritance
{
    // Set this class to inherit from your Animal Class
    public class Bird : Animal
    {
        public Bird()
        {
            Name = "Baldy";
            Age = 4;
            IsWarmBlooded = true;
            MakeNoise = "caaaah";
        }

        // give this class 4 members that are specific to Bird
        public string WingColor { get; set; }
        public double WingLength { get; set; }
        public bool CanFly { get; set; }
        public int NumberOfEggs { get; set; }
       
    }
}
