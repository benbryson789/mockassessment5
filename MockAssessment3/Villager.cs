using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3
{
    public abstract class Villager
    {
        // Properties
        public int Hunger { get; set; }

        // Methods
        public abstract int Farm();
    }

}
