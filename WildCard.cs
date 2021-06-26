using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class WildCard : SpecialCard
    {
        //Constructor
        public WildCard() : base("WildCard", "black", -1, true)
        {
        }
        
        //This method allows the caster to change the coloru of the card.
        public override void runEffect()
        {
            String newColour = Console.ReadLine();
            colour = newColour;          
        }
    }
}
