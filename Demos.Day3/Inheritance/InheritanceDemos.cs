using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Day3.Inheritance
{
    public struct Vector
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }

    internal static class InheritanceDemos
    {
        public static void DoDemo1()
        {
            var gebouw = new Gebouw();
            var mens = new Mens();
            var robot = new Robot("Wall-E");
            var robot1 = new Robot("Eve");


            /*
            robot.MaakGeluid();
            Entity entity0 = robot;
            Robot zelfdeRobot = (Robot)entity0;
            zelfdeRobot.MaakGeluid();
            */

            SaySomething(gebouw);
            SaySomething(mens);
            SaySomething(robot);

            return;

            PrintPosition(gebouw);
            PrintPosition(mens);
            PrintPosition(robot);


            return;
        }

        static void PrintPosition(Entity entity)
        {
            Console.WriteLine("Entity: " + entity.Position);
        }

        static void SaySomething(Entity entity)
        {
            
            Console.WriteLine(entity.Description + ": " + entity.MaakGeluid());
        }
    }
}
