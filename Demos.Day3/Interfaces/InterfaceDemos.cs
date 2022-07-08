using Demos.Day3.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Day3.Interfaces
{
    public interface IEntity
    {
        public Vector Position { get; set; }
    }

    public interface IMechanischObject : IEntity 
    {
        public void Beweeg();
    }
    public interface IVliegendObject : IEntity 
    {
        public void Beweeg();
        void Vlieg();
    }

    public class Entity : IEntity
    {
        public Vector Position { get; set; }
    }

    public class Robot : Entity
    {
    }

    public class Vogel : Entity{ }
    public class Vliegtuig : Entity, IVliegendObject, IMechanischObject
    {
        public Vector Position { get; set; }


        public void Vlieg()
        {
            
        }

        public void Beweeg()
        {
            Console.WriteLine("Ik ben aan het rollen");
        }

        void IVliegendObject.Beweeg()
        {
            Console.WriteLine("Ik ben aan het vliegen");
        }

    }


    public static class InterfaceDemos
    {
        public static void DoDemo1()
        {
            var vliegtuig = new Vliegtuig();

            vliegtuig.Beweeg();


            Beweeg((IVliegendObject)vliegtuig);
            Beweeg((IMechanischObject)vliegtuig);

            return;
        }

        static void GaVliegen(IVliegendObject obj) { }

        static void Beweeg(IVliegendObject obj)
        {
            obj.Beweeg();
        }
        static void Beweeg(IMechanischObject obj)
        {
            obj.Beweeg();
        }
    }
}
