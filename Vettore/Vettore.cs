using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettore
{
    internal class Vettore
    {
        public Vettore(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public override string ToString()
        {
            return string.Format("{0}, {1}", X, Y);
        }
        public static Vettore Parse(string s)
        {
            var p = s.Split(';');
            return new Vettore(int.Parse(p[0]), int.Parse(p[1]));
        }
        public static Vettore operator +(Vettore v1, Vettore v2)
        {
            Vettore v = new Vettore(v1.X + v2.X, v1.Y + v2.Y);
            return v;
        }
        public static Vettore operator -(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X - v2.X, v1.Y - v2.Y);

        }
        public static Vettore operator *(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X * v2.X, v1.Y * v2.Y);
        }
        public static Vettore operator *(Vettore v, double s)
        {
            return new Vettore(v.X * s, v.Y * s);
        }

        public static Vettore operator /(Vettore v, double s)
        {
            return new Vettore(v.X / s, v.Y / s);
        }
        public static Vettore operator +(Vettore v)
        {
            return v;
        }
        public static Vettore operator -(Vettore v)
        {
            return new Vettore(-v.Y, v.X);

        }
        public static bool operator !=(Vettore v1, Vettore v2)
        {
            return !(v1 == v2);
        }
        public static bool operator ==(Vettore v1, Vettore v2)
        {
            if (object.ReferenceEquals(v1, null))
                return object.ReferenceEquals(v2, null);
            else if (object.ReferenceEquals(v2, null))
                return false;
            else
                return v1.X == v2.X && v1.Y == v2.Y;
        }

    }
}

