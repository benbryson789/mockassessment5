using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3
{
    public class Slacker : Villager
    {
        // Constructor
        public Slacker()
        {
            Hunger = 3;
        }

        // Methods
        public override int Farm()
        {
            return 0;
        }
    }
}
