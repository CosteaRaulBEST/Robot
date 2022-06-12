using System;

namespace Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot(50, Intensity.Low);
            Console.WriteLine((int)Intensity.Kill);
        }
    }
}
