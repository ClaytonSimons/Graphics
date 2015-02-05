using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GraphicsQuaternionLab3
{
    public class Quaternion
    {
        private double s=0, i=0, j=0, k=0;
        public Quaternion()
        {

        }
        public Quaternion(Double S,Double I, Double J, Double K)
        {
            s = S;
            i = I;
            j = J;
            k = K;
        }
        /// <summary>
        /// Computes the inverse of the quaternion this.
        /// </summary>
        /// <returns>
        /// Returns the inverse.
        /// </returns>
        public Quaternion Inverse()
        {
            Quaternion answer = new Quaternion();
            double inversemagnitude = 1 / (s*s + i*i + j*j + k*k);
            answer.s = s * inversemagnitude;
            answer.i = -i * inversemagnitude;
            answer.j = -j * inversemagnitude;
            answer.k = -k * inversemagnitude;
            return answer;
        }
        /// <summary>
        /// The subtraction operator for two quaternions.
        /// </summary>
        /// <param name="lhs">
        /// The left hand quaternion.
        /// </param>
        /// <param name="rhs">
        /// The right hand quaternion.
        /// </param>
        /// <returns>
        /// Returns the resulting quaternion.
        /// </returns>
        public static Quaternion operator /(Quaternion lhs, Quaternion rhs)//lhs -> numerator
        {
            return lhs * rhs.Inverse();
        }
        /// <summary>
        /// The multiplication operator for two quternions.
        /// </summary>
        /// <param name="lhs">
        /// The left hand quaternion.
        /// </param>
        /// <param name="rhs">
        /// The right hand quaternion.
        /// </param>
        /// <returns>
        /// Returns the resulting quaternion.
        /// </returns>
        public static Quaternion operator *(Quaternion lhs, Quaternion rhs)
        {
            Quaternion answer = new Quaternion();
            //  (s i j k) * (s i j k)
            answer.s = lhs.s * rhs.s - lhs.i * rhs.i - lhs.j * rhs.j - lhs.k * rhs.k;
            answer.i = lhs.s * rhs.i + lhs.i * rhs.s + lhs.j * rhs.k - lhs.k * rhs.j;
            answer.j = lhs.s * rhs.j - lhs.i * rhs.k + lhs.j * rhs.s + lhs.k * rhs.i;
            answer.k = lhs.s * rhs.k + lhs.i * rhs.j - lhs.j * rhs.i + lhs.k * rhs.s;
            return answer;
        }
        /// <summary>
        /// The multiplication operator for a scalar and a quaternion.
        /// </summary>
        /// <param name="lhs">
        /// The left hand scalar.
        /// </param>
        /// <param name="rhs">
        /// The right hand quaternion.
        /// </param>
        /// <returns>
        /// Returns the resulting quaternion.
        /// </returns>
        public static Quaternion operator *(double lhs, Quaternion rhs)
        {
            Quaternion answer = new Quaternion();
            answer.s = rhs.s;
            answer.i = rhs.i * lhs;
            answer.j = rhs.j * lhs;
            answer.k = rhs.k * lhs;
            return answer;
        }
        /// <summary>
        /// The division operator for a quaternion and a scalar.
        /// </summary>
        /// <param name="lhs">
        /// The left hand quaternion.
        /// </param>
        /// <param name="rhs">
        /// The right hand scalar.
        /// </param>
        /// <returns>
        /// Returns the resulting quaternion.
        /// </returns>
        public static Quaternion operator /(Quaternion lhs, double rhs)
        {
            Quaternion answer = new Quaternion();
            answer.s = lhs.s;
            answer.i = lhs.i / rhs;
            answer.j = lhs.j / rhs;
            answer.k = lhs.k / rhs;
            return answer;
        }
        /// <summary>
        /// The subtraction operator for two quaternions.
        /// </summary>
        /// <param name="lhs">
        /// The left hand quaternion.
        /// </param>
        /// <param name="rhs">
        /// The right hand quaternion.
        /// </param>
        /// <returns>
        /// Returns the resulting quaternion.
        /// </returns>
        public static Quaternion operator -(Quaternion lhs, Quaternion rhs)
        {
            return new Quaternion(lhs.s - rhs.s, lhs.i - rhs.i, lhs.j - rhs.j, lhs.k - rhs.k);
        }
        /// <summary>
        /// The multiplication operator for two quaternions.
        /// </summary>
        /// <param name="lhs">
        /// The left hand quaternion.
        /// </param>
        /// <param name="rhs">
        /// The right hand quaternion.
        /// </param>
        /// <returns>
        /// Returns the resulting quaternion.
        /// </returns>
        public static Quaternion operator +(Quaternion lhs, Quaternion rhs)
        {
            return new Quaternion(lhs.s + rhs.s, lhs.i + rhs.i, lhs.j + rhs.j, lhs.k + rhs.k);
        }
        /// <summary>
        /// Calculates the magnitude of this quaternion.
        /// </summary>
        /// <returns>
        /// Returns the quaternion's magnitude.
        /// </returns>
        public double Magnitude()
        {
            return Math.Sqrt(s*s + i*i + j*j + k*k);
        }
        /// <summary>
        /// Calculates the resulting quaternion of a rotation on point about the given axis by angle amount
        /// in radians.
        /// </summary>
        /// <param name="point">
        /// The point to rotate.
        /// </param>
        /// <param name="angle">
        /// The amount to rotate in radians.
        /// </param>
        /// <param name="axis">
        /// The axis to rotate about.
        /// </param>
        /// <returns>
        /// Returns the resulting quaternion.
        /// </returns>
        public Quaternion rotatePointByAngleAboutAxisVector(Quaternion point, double angle, Quaternion axis)
        {
            Quaternion answer;
            double d = Math.Cos(angle);
            Quaternion q = Math.Sin(angle / 2) * axis / axis.Magnitude();
            q.s += Math.Cos(angle / 2);
            answer = q * point * q.Inverse();
            return answer;
        }
        public void sets(double coord)
        {
            s = coord;
        }
        public void seti(double coord)
        {
            i = coord;
        }
        public void setj(double coord)
        {
            j = coord;
        }
        public void setk(double coord)
        {
            k = coord;            
        }
        public double gets()
        {
            return s;
        }
        public double geti()
        {
            return i;
        }
        public double getj()
        {
            return j;
        }
        public double getk()
        {
            return k;
        }

    }
}
