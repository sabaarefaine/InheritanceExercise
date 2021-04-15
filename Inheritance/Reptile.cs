using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {

            Name = "Lizzy";
            Age = 2;
            IsWarmBlooded = false;
            MakeNoise = "slither";
         
        }

        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class

        public string Habitat { get; set; }
        public bool IsScaly { get; set; }
        public string FavoriteFood { get; set; }
        public bool GiveLiveBirth { get; set; }
    }
}
