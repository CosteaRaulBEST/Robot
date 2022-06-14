using System;

namespace Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            robot.initialize();
            robot.EyeLasserIntensity = Intensity.Kill;
            robot.Targets = new Target[] { new SuperHeroes() , new Animals(), new SuperHeroes(), new Humans() };
            robot.CurrentTarget = robot.Targets[0];
            Planets earth = new Earth();
            Console.WriteLine($"Statut robot active: {robot.Active}");
            Console.WriteLine($"Statut pamanul contine viata: {earth.ContainsLife()}");
            while ( robot.Active && earth.ContainsLife())
            {
                if (robot.CurrentTarget.Alive())
                {
                    robot.FireLaserAt(robot.CurrentTarget);
                }
                else
                    robot.AcquireNextTarget();
            }
            robot.Active = false;
            Console.WriteLine($"Statut robot active: {robot.Active}");
            
        }
    }
}
