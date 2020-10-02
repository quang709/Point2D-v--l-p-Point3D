using System;
using System.Collections.Generic;
using System.Text;

namespace Point2D_và_lớp_Point3D
{
    class Point3D : Point2D
    {
        public float z = 0.0f;
        public Point3D(float x, float y, float z) : base(x, y)
        {
            ;
            this.z = z;
        }
        public Point3D() { }
        public float GetZ()
        {
            return z;
        }

        public void SetZ(float z)
        {
            this.z = z;
        }
        public float[] GetXYZ()
        {
            return new float[3] { base.GetX(), base.GetY(), z };
        }

        public void SetXYZ(float z)
        {

            this.z = z;
        }
        public override string ToString()
        {
            return "x = " + GetX() + "\ny = " + GetY() + "\nz = " + GetZ() + "\n(x,y,z) = " + string.Join(", ", GetXYZ());
        }
    }
}
