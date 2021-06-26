using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Reverse : SpecialCard
    {
        //Constructor
        public Reverse(String colour) : base("Reverse", colour, -1, false)
        {
        }

        //This method reverses the turn direction
        public override void runEffect()
        {
            Game.reverseDir();
        }
    }
}
