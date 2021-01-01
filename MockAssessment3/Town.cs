using System;
using System.Collections.Generic;

namespace MockAssessment3
{
    public class Town
    {
        // Properties
        public List<Villager> Villagers { get; set; }

        // Constructor
        public Town(Farmer farmer, Slacker slacker1, Slacker slacker2, Slacker slacker3)
        {
            Villagers = new List<Villager>();

            Villagers.Add(farmer);
            Villagers.Add(slacker1);
            Villagers.Add(slacker2);
            Villagers.Add(slacker3);
        }

        // Methods

        public int Harvest()
        {
            int total = 0;
            foreach (Villager villager in Villagers)
            {
                total = total + villager.Farm();
            }

            return total;
        }

        public int CalcFoodConsumption()
        {
            int total = 0;
            foreach (Villager villager in Villagers)
            {
                total = total + villager.Hunger;
            }

            return total;
        }

        public bool SurviceTheWinter()
        {
            bool surviceTheWinter = false;
            int harvest = Harvest();
            int calcFoodConsumption = CalcFoodConsumption();

            if (calcFoodConsumption <= harvest)
            {
                surviceTheWinter = true;
            }
            else if (calcFoodConsumption > harvest)
            {
                surviceTheWinter = false;
            }

            return surviceTheWinter;
        }
    }
}
