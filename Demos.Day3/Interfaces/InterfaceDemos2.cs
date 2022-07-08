using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Day3.Interfaces
{
    // voertuig
    // tractor (magopnweg, motor)
    // auto (magopnweg, motor)
    // fiets
    // scooter (motor)
    // skateboard
    // benenwagen
    // jetski (boot, motor)
    // titanic (boot, motor)


    // class
    // 0 of meer interfaces

    public interface IMagOpNWeg
    {
        public void RijdNaarBestemming(string bestemming);
    }
    public interface IHeeftMotor
    {
        public float BrandstofInhoud { get; set; }
        public void StartMotor();
    }

    public abstract class Voertuig 
    {
        public string Kleur { get; protected set; }
        public float Snelheid { get; protected set; } = 0;

        public abstract void GaNaar();
    }

    public abstract class Boot : Voertuig { }

    public abstract class Auto : Voertuig, IMagOpNWeg
    {
        public void RijdNaarBestemming(string bestemming)
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Titanic : Boot, IHeeftMotor
    {
        public float BrandstofInhoud { get; set; }

        public void StartMotor()
        {
            throw new NotImplementedException();
        }
    }
}
