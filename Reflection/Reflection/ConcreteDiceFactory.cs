using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class ConcreteDiceFactory : DiceFactory
    {
               
        public override Dice GetDice()
        {

            return new ConcreteDice();

        }//GetDice

    }//ConcreteDiceFactory
}
