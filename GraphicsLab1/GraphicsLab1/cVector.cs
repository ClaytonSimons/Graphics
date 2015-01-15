using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLab1
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
        public cVector dot(cVector lhs)
        {
            cVector answer = new cVector();
            answer.x = x * lhs.x;
            answer.y = y * lhs.y;
            answer.z = z * lhs.z;
            return answer;
        }
    }
}
