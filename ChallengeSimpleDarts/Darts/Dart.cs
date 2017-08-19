using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
       
        public int points { get; set; }
        public string band { get; set; }

        public void Throw(Random random)
        {
            int point = random.Next(1, 20);
            int chance = random.Next(1, 100);
            
            if (point == 0)
            {
                if (chance == 1 || chance == 2 || chance == 3 || chance == 4 || chance == 5)
                {
                    this.points = point;
                    this.band = "inner bullseye";

                }
                else
                {
                    this.points = point;
                    this.band = "outer bullseye";
                }
            }

            else
            {
                if (chance == 1 || chance == 2 || chance == 3 || chance == 4 || chance == 5)
                {
                    this.points = point;
                    this.band = "inner band";


                }
                else if (chance == 6 || chance == 7 || chance == 8 || chance == 9 || chance == 10)
                {
                    this.points = point;
                    this.band = "outer band";
                }
                else this.points = point;
            }
        }
    }
}
