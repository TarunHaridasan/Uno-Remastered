using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Skip : SpecialCard
    {
        //Constructor
        public Skip(String colour) : base("Skip", colour, -1, false)
        {

        }

        //This method skips the next player
        public override void runEffect()
        {
            Game.changeTurn(1);
        }
    }
}
