using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DiggerPixelArt
{
    public struct MyIntVect
    {
        public static MyIntVect zero = new MyIntVect(0, 0, 0);
        public MyIntVect(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public int x;
        public int y;
        public int z;
        public static bool operator ==(MyIntVect vect1, MyIntVect vect2)
        {
            return vect1.x == vect2.x && vect1.y == vect2.y && vect1.z == vect2.z;
        }
        public static bool operator !=(MyIntVect vect1, MyIntVect vect2)
        {
            return vect1.x != vect2.x && vect1.y != vect2.y && vect1.z != vect2.z;
        }
        public static MyIntVect operator *(MyIntVect vect1, float value)
        {
            return new MyIntVect((int)(vect1.x * value), (int)(vect1.y * value), (int)(vect1.z * value));
        }
        public static MyIntVect operator +(MyIntVect vect1, MyIntVect vect2)
        {
            return new MyIntVect((int)(vect1.x + vect2.x), (int)(vect1.y + vect2.y), (int)(vect1.z + vect2.z));
        }
        public static MyIntVect operator -(MyIntVect vect1, MyIntVect vect2)
        {
            return new MyIntVect((int)(vect1.x - vect2.x), (int)(vect1.y - vect2.y), (int)(vect1.z - vect2.z));
        }
        public static MyIntVect operator /(MyIntVect vect1, float value)
        {
            if (value == 0)
                return zero;
            return new MyIntVect((int)(vect1.x / value), (int)(vect1.y / value), (int)(vect1.z / value));
        }

        public static implicit operator MyIntVect(Vector3 vector)
        {
            return new MyIntVect((int)vector.X, (int)vector.Y, (int)vector.Z);
        }
        public static MyIntVect Lerp(MyIntVect myInt1, MyIntVect myInt2, float value)
        {
            return Vector3.Lerp(myInt1.GetVector(), myInt2.GetVector(), value);
        }
        public static float Distance(MyIntVect myInt, MyIntVect vect)
        {
            return Vector3.Distance(myInt.GetVector(), vect.GetVector());
        }
        public override string ToString()
        {
            return $"x: {x}, y: {y}, z: {z}";
        }
        public MyIntVect NormalizedVector3()
        {
            return this + new MyIntVect(1,1,1) * 0.5F;
        }
        public Vector3 GetVector()
        {
            return new Vector3(x, y, z);
        }

    }
}
