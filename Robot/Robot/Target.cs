using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{

    
    internal class Target
    {

        public int Health;
        int Damage;
        public bool CurrentTargetisAlive ()
        {

            if ( Health > 0)
            {
                return true;
            }
            return false;
        }
    }
}
