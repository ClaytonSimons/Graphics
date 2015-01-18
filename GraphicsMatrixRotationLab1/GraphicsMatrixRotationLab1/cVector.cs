using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsMatrixRotationLab1
{
    class cVector
    {
        public double x, y, z;
        public cVector(double X = 0, double Y = 0, double Z = 0)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public cVector(cVector copy):this(copy.x,copy.y,copy.z)
        {
        }
        //************************************Operators*************************************************
        //*********************Comparitors**********************************
        #region Comparitors
        public static bool operator ==(cVector lhs, cVector rhs)
        {
            if (System.Object.ReferenceEquals(lhs, rhs))
                return true;
            if ((object)lhs == null || (object)rhs == null)
                return false;
            return lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z;
        }
        public static bool operator !=(cVector lhs, cVector rhs)
        {
            if (System.Object.ReferenceEquals(lhs, rhs))
                return false;
            if ((object)lhs == null || (object)rhs == null)
                return true;
            return lhs.x != rhs.x || lhs.y != rhs.y || lhs.z != rhs.z;
        }
        #endregion
        //**********************Math*************************************
        #region Math operators
        /// <summary>
        /// Returns the addition lhs + rhs.
        /// </summary>
        /// <param name="lhs"></param>
        /// Left hand vector.
        /// <param name="rhs"></param>
        /// Right hand vector.
        /// <returns></returns>
        public static cVector operator +(cVector lhs, cVector rhs)
        {
            cVector answer = new cVector(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
            return answer;
        }
        /// <summary>
        /// Returns the addition lhs + rhs.
        /// </summary>
        /// <param name="lhs"></param>
        /// Left hand vector.
        /// <param name="rhs"></param>
        /// Right hand scalar.
        /// <returns></returns>
        public static cVector operator +(cVector lhs, double rhs)
        {
            cVector answer = new cVector(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
            return answer;
        }
        /// <summary>
        /// Returns the subtraction lhs - rhs.
        /// </summary>
        /// <param name="lhs"></param>
        /// Left hand vector.
        /// <param name="rhs"></param>
        /// Right hand vector.
        /// <returns></returns>
        public static cVector operator -(cVector lhs, cVector rhs)
        {
            cVector answer = new cVector(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
            return answer;
        }
        /// <summary>
        /// Returns the subtraction lhs - rhs.
        /// </summary>
        /// <param name="lhs"></param>
        /// Left hand vector.
        /// <param name="rhs"></param>
        /// Right hand scalar.
        /// <returns></returns>
        public static cVector operator -(cVector lhs, double rhs)
        {
            cVector answer = new cVector(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
            return answer;
        }
        /// <summary>
        /// Returns the multiplication lhs * rhs.
        /// </summary>
        /// <param name="lhs"></param>
        /// Left hand vector.
        /// <param name="rhs"></param>
        /// Right hand vector.
        /// <returns></returns>
        public static cVector operator *(cVector lhs, cVector rhs)
        {
            cVector answer = new cVector(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
            return answer;
        }
        /// <summary>
        /// Returns the Multiplication lhs * rhs.
        /// </summary>
        /// <param name="lhs"></param>
        /// Left hand vector.
        /// <param name="rhs"></param>
        /// Right hand scalar.
        /// <returns></returns>
        public static cVector operator *(cVector lhs, double rhs)
        {
            cVector answer = new cVector(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
            return answer;
        }
        /// <summary>
        /// Returns the division of lhs / rhs
        /// </summary>
        /// <param name="lhs"></param>
        /// Left hand vector.
        /// <param name="rhs"></param>
        /// Right hand scalar.
        /// <returns></returns>
        public static cVector operator /(cVector lhs, double rhs)
        {
            cVector answer = new cVector(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
            return answer;
        }
        #endregion
        //*************************Operations*********************************
        #region Operations
        /// <summary>
        /// Returns a vector with direction of lhs and magnitude of rhs.
        /// </summary>
        /// <param name="lhs"></param>
        /// left hand vector.
        /// <param name="rhs"></param>
        /// right hand vector.
        /// <returns></returns>
        public static cVector operator |(cVector lhs, double rhs)//returns a vector with direction of lhs and magnitude of rhs
        {
            return lhs * (rhs / !lhs);
        }
        /// <summary>
        /// Returns the cross product of this and parameter.
        /// </summary>
        /// <param name="lhs"></param>
        /// Left hand vector.
        /// <param name="rhs"></param>
        /// Right hand vector.
        /// <returns></returns>
        public static cVector operator ^(cVector lhs, cVector rhs)
        {
            cVector answer = new cVector(lhs.y * rhs.z - lhs.z * rhs.y, lhs.z * rhs.x - lhs.x * rhs.z, lhs.x * rhs.y - lhs.y * rhs.x);
            return answer;
        }
        /// <summary>
        /// Returns the dot product of lhs and rhs.
        /// </summary>
        /// <param name="lhs"></param>
        /// Left hand vector.
        /// <param name="rhs"></param>
        /// Right hand vector.
        /// <returns></returns>
        public static double operator %(cVector lhs, cVector rhs)
        {
            return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
        }
        //************************Single condition****************************
        /// <summary>
        /// Returns the magnitude of this vector to the rhs.
        /// </summary>
        /// <param name="rhs"></param>
        /// right hand vector.
        /// <returns></returns>
        public static double operator !(cVector rhs)
        {
            return Math.Sqrt((double)(rhs.x * rhs.x + rhs.y * rhs.y + rhs.z * rhs.z));
        }
        /// <summary>
        /// Returns negative vector.
        /// </summary>
        /// <param name="rhs"></param>
        /// right hand vector.
        /// <returns></returns>
        public static cVector operator -(cVector rhs)//negative
        {
            cVector answer = new cVector(-rhs.x, -rhs.y, -rhs.z);
            return answer;
        }
#endregion
    }
}
