using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3
{
    public class Farmer : Villager
    {
        // Constructor
        public Farmer()
        {
            Hunger = 1;
        }

        // Methods
        public override int Farm()
        {
            return 2;
        }
    }
}
