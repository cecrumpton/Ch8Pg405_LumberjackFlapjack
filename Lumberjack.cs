using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Pg405_LumberjackFlapjack
{
    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public int Flapjack { get { return meal.Count; } }
        public void TakeFlapjacks(Flapjack food, int howMany)
        {
            for (int i = 1; i <= howMany; i++)
            {
                meal.Push(food);
            }
        }
        public void EatFlapjacks()
        {
            Console.WriteLine(name + "'s eating flapjacks");
            foreach (Flapjack flapjack in meal)
            {
                Console.WriteLine(name + " ate a " + flapjack.ToString().ToLower() + " flapjack");
            }
        }
    }
}
