using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    abstract class SpecialCard : Card
    {
        String type;
        public SpecialCard(String type, String colour, int value, bool isWild) : base(colour, value, isWild)
        {
            this.type = type;
        }
        public override abstract void runEffect();
    }
}
