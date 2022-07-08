using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Day2.Lib
{

    public struct Adres
    {
        public string straatnaam;
        int huisnummer;

        public void Verhuis(int nieuwHuisNummer)
        {
            huisnummer = nieuwHuisNummer;
        }
    }

    public struct Vector
    {
        public int _x;
        public int _y;

        public Vector()
        {
            _x = 9;
            _y = 9;
        }
        public Vector(int x, int y)
        {
            _x = x;
            _y = y;
        }

        // var v0 = new Vector(100, 100);
        // var v1 = new Vector(1000, 1000);
        // var result = v0 + v1;
        public static Vector operator +(Vector v0, Vector v1)
        {
            return new Vector(v0._x + v1._x, v0._y + v1._y);
        }

        public Vector Add(Vector v)
        {
            return new Vector(this._x + v._x, this._y + v._y);

        }
    }

    
}
