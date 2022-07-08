using Demos.Day2.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Day3.Inheritance
{
    // gebouwen
    // autos
    // dieren
    // mensen
    // robot
    
    public abstract class Entity 
    {
        public string Name { get; private set; }
        public abstract string Description { get; }
        public Vector Position { get; protected set; }
        public Vector Velocity { get; protected set; }

        public Entity()
        {

        }
        public Entity(string name)
        {
            Name = name;
        }

        public void Update()
        {
            //Position += Velocity;
            OnUpdate();
            //
        }
        protected virtual void OnUpdate()
        {

        }

        public virtual string MaakGeluid()
        {
            return "[silence]";
        }

        public void DoCollision(Entity entity)
        {

        }
    }

    public class Gebouw : Entity
    {
        // public override string Description => "Gebouw";
        public override string Description
        {
            get
            {
                return "Gebouw";
            }
        }
    }

    public abstract class Mechanical : Entity
    {
        protected Mechanical(string name =  "")
            : base(name)
        {

        }


        public sealed override string ToString()
        {
            return "Mechanical Object";
        }

    }

    public class Robot : Mechanical
    {
        public override string Description
        {
            get
            {
                return "Robot";
            }
        }

        public Robot(string name)
            : base(name)
        {
            
        }

        public override string MaakGeluid()
        {
            return "bleep";
        }

    }

    public class Vliegtuig : Mechanical
    {
        public override string Description => "bla";

        public Vliegtuig()
            : base()
        {

        }

        
        public override string MaakGeluid()
        {
            Console.WriteLine("debug 1");

            var result = base.MaakGeluid();
            
            Console.WriteLine("debug 2");

            return result;
        }
        

    }

    public sealed class Mens : Entity 
    {
        public override string Description
        {
            get
            {
                return "Mens";
            }
        }

        public override string MaakGeluid()
        {
            return "Hello world!";
        }
    }

}
