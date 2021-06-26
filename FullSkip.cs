using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class FullSkip : SpecialCard
    {
        //Constructor
        public FullSkip() : base("FullSkip", "black", -1, true)
        {
        }
        
        //This method skips all players and gives the caster another change
        public override void runEffect()
        {
            Game.changeTurn(3);
        }
    }    
}
