using System;
namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {
        }

        // give this class 4 members that all Animals have in common

        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsWarmBlooded { get; set; }
        public string MakeNoise { get; set; }
    }
}
