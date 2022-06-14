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
        public int HealthRobot;
        public  Intensity EyeLasserIntensity;
        public Target CurrentTarget;
        public Target[] Targets;
        public int i;
        public bool Active;
        public void initialize()
        {
            i = 0;
            HealthRobot = 100;
            Active = true;
        }

        public void FireLaserAt(Target CurrentTarget)            
        {
           
           CurrentTarget.Health =  CurrentTarget.Health - (int)EyeLasserIntensity;
            Console.WriteLine($"Robotul ataca {CurrentTarget} si i da {(int)EyeLasserIntensity} damage");
            Console.WriteLine($"Prin urmare {CurrentTarget} ramane cu {CurrentTarget.Health} hp");
        }
        public void AcquireNextTarget()
        {
            Console.WriteLine($"{CurrentTarget} a murit");
            if ( i < Targets.Length - 1)
            CurrentTarget = Targets[++i];
            else
            {
                Active = false;
            }
        }



    }
}
