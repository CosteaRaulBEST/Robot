using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





enum Intensity
{
    Low = 10,
    Medium = 20,
    High = 30,
    Kill = 40,
}
namespace Robot
{

    internal class Robot
    {
        int HealthRobot;
        public Intensity Intens;
        public bool isActive()
        {

            if (HealthRobot > 0)
            {
                return true;
            }
            return false;
        }
        public Robot  (int healthRobot , Intensity intensity)
        {
           HealthRobot = healthRobot;
           Intens = intensity;  
        } 


        public int FireLaserAt()
        {
            int Damage =  (int)Intensity.Medium;
            var ct = new Target();
            int Health  = ct.Health - Damage;
            Health = ct.Health;
            return Health;
        }



    }
}
