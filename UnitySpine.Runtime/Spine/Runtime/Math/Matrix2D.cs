using System;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Math
{
    [Serializable]
    public struct Matrix2D
    {
        public float A;
        public float B;
        public float C;
        public float D;
        public float TX;
        public float TY;

        public Matrix2D(float a = 1, float b = 0, float c = 0, float d = 1, float tx = 0, float ty = 0)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            TX = tx;
            TY = ty;
        }

        public Matrix2D Identity()
        {
            A = D = 1;
            B = C = TX = TY = 0;
            return this;
        }

        public Matrix2D Concat(Matrix2D other, bool includeRotation = true, bool includeScale = true)
        {
            var a = A;
            var b = B;
            var c = C;
            var d = D;
            var tx = TX;
            var ty = TY;

            if (!includeRotation)
            {
                var acLength = Mathf.Sqrt(other.A * other.A + other.C * other.C);
                var bdLength = Mathf.Sqrt(other.B * other.B + other.D * other.D);
                other.A = acLength;
                other.D = bdLength;
                other.B = other.C = 0;
            }
            else if(!includeScale)
            {
                var acLength = Mathf.Sqrt(other.A * other.A + other.C * other.C);
                var bdLength = Mathf.Sqrt(other.B * other.B + other.D * other.D);
                other.A /= acLength;
                other.B /= bdLength;
                other.C /= acLength;
                other.D /= bdLength;
            }

            if (includeRotation || includeScale)
            {
                A = other.A * a + other.C * b;
                B = other.B * a + other.D * b;
                C = other.A * c + other.C * d;
                D = other.B * c + other.D * d;
            }

            TX = other.A * tx + other.C * ty + other.TX;
            TY = other.B * tx + other.D * ty + other.TY;
            return this;
        }

        public Matrix2D Make(float scaleX, float scaleY, float tx = 0, float ty = 0, float rotation = 0, float shearX = 0,float shearY = 0)
        {
            if (rotation == 0.0f && shearX == 0.0f && shearY == 0.0f)
            {
                A = D = 1;
                B = C = 0;
            }
            else
            {
                A = Mathf.Cos(Mathf.Deg2Rad * (rotation + shearX));
                B = Mathf.Sin(Mathf.Deg2Rad * (rotation + shearY));
                C = -B;
                D = A;
            }
            if (scaleX != 1.0f)
            {
                A *= scaleX;
                C *= scaleX;
            }
            if (scaleY != 1.0f)
            {
                B *= scaleY;
                D *= scaleY;
            }
            TX = tx;
            TY = ty;
            return this;
        }

        public Matrix2D Invert()
        {
            var a = A;
            var b = B;
            var c = C;
            var d = D;
            var tx = TX;
            var ty = TY;
            var determinant = a * d - c * b;
            A = d / determinant;
            B = -b / determinant;
            C = -c / determinant;
            D = a / determinant;
            TX = -(A * tx + C * ty);
            TY = -(B * tx + D * ty);
            return this;
        }
        
        public static Vector2 operator *(Matrix2D m, Vector2 v)
        {
            return new Vector2(m.A * v.x + m.C * v.y + m.TX, m.B * v.x + m.D * v.y + m.TY);
        }

        public static Vector2 operator *(Vector2 v, Matrix2D m)
        {
            return m*v;
        }

        public static Vector3 operator *(Matrix2D m, Vector3 v)
        {
            return new Vector3(m.A * v.x + m.C * v.y + m.TX, m.B * v.x + m.D * v.y + m.TY);
        }

        public static Vector3 operator *(Vector3 v, Matrix2D m)
        {
            return m * v;
        }
        
        public override string ToString()
        {
            return string.Format("(a:{0},b:{1},c:{2},d:{3},tx:{4},ty:{5})", A, B, C, D, TX, TY);
        }
    }
}
