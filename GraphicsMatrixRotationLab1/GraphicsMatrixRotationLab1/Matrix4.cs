using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsMatrixRotationLab1
{
    class Matrix4
    {
        public double[,] matrix;
        public Matrix4()
        {
            matrix = new double[4, 4] {{0,0,0,0},
                                    {0,0,0,0},
                                    {0,0,0,0},
                                    {0,0,0,0}};
        }
        /// <summary>
        /// Constructor that takes a 4x4 2d array of doubles.
        /// </summary>
        /// <param name="mat">
        /// 4x4 2d array of doubles.
        /// </param>
        public Matrix4(double[,] mat)
        {
            if(mat.Length == 16)
                matrix = mat;
        }
        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="copy">
        /// The copy.
        /// </param>
        public Matrix4(Matrix4 copy)
        {
            matrix = copy.matrix;
        }
        /// <summary>
        /// Creates translation matrix with respect to dir as direction and magnitude.
        /// </summary>
        /// <param name="dir">
        /// Direction and magnitude.
        /// </param>
        /// <returns>
        /// Translation Matrix
        /// </returns>
        public static Matrix4 TranslateMatrix(cVector dir)
        {
            return new Matrix4(new double[4,4] {{1,0,0,dir.x},
                                                        {0,1,0,dir.y},
                                                        {0,0,1,dir.z},
                                                        {0,0,0,1}});
        }
        /// <summary>
        /// Creates scale matrix with respect to dir as direction and magnitude.
        /// </summary>
        /// <param name="dir">
        /// direction and magnitude
        /// </param>
        /// <returns>
        /// scale matrix
        /// </returns>
        public static Matrix4 Scalematrix(cVector dir)
        {
            return new Matrix4(new double[4, 4] {{dir.x,0,0,0},
                                                        {0,dir.y,0,0},
                                                        {0,0,dir.z,0},
                                                        {0,0,0,1}});
        }
        /// <summary>
        /// creates rotation matrix with respect to angle as the angle in the x, y, and z directions.
        /// </summary>
        /// <param name="angle">
        /// x, y, and z angles to be rotated by.
        /// </param>
        /// <returns>
        /// rotation matrix for x, y, and z
        /// </returns>
        public static Matrix4 RotateMatrix(cVector angle)
        {
            Matrix4 answer = new Matrix4();
            int round = 6;
            cVector rot = new cVector(angle.x * (Math.PI / 180), angle.y * (Math.PI / 180), angle.z * (Math.PI / 180));
            Matrix4 rotz = new Matrix4(new double[4, 4] {{Math.Round(Math.Cos(rot.z),round),Math.Round(-Math.Sin(rot.z),round),0,0},
                                                        {Math.Round(Math.Sin(rot.z),round),Math.Round(Math.Cos(rot.z),round),0,0},
                                                        {0,0,1,0},
                                                        {0,0,0,1}});
            Matrix4 rotx = new Matrix4(new double[4, 4] {{1,0,0,0},
                                                        {0,Math.Round(Math.Cos(rot.x),round),Math.Round(-Math.Sin(rot.x),round),0},
                                                        {0,Math.Round(Math.Sin(rot.x),round),Math.Round(Math.Cos(rot.x),round),0},
                                                        {0,0,0,1}});
            Matrix4 roty = new Matrix4(new double[4, 4] {{Math.Round(Math.Cos(rot.y),round),0,Math.Round(Math.Sin(rot.y),round),0},
                                                        {0,1,0,0},
                                                        {Math.Round(-Math.Sin(rot.y),round),0,Math.Round(Math.Cos(rot.y),round),0},
                                                        {0,0,0,1}});
            answer = rotz * roty * rotx;
            return answer;
        }
        /// <summary>
        /// Multiplication operator for lhs and rhs matrices.
        /// </summary>
        /// <param name="lhs">
        /// The left hand side matrix.
        /// </param>
        /// <param name="rhs">
        /// The right hand side matrix.
        /// </param>
        /// <returns>
        /// Matrix from resulting multiplication
        /// </returns>
        public static Matrix4 operator*(Matrix4 lhs, Matrix4 rhs)
        {
            Matrix4 answer = new Matrix4();
            double element = 0;
            for (int c = 0; c < 4; c++)
                for (int r = 0; r < 4; r++)
                {
                    for(int i = 0; i<4;i++)
                    {
                        element = element + lhs.matrix[r, i] * rhs.matrix[i, c];
                    }
                    answer.matrix[r, c] = element;
                    element = 0;
                }
            return answer;
        }
        /// <summary>
        /// Multiplies the lhs matrix and the rhs vector.
        /// </summary>
        /// <param name="lhs">
        /// The left hand side matrix.
        /// </param>
        /// <param name="rhs">
        /// The right hand side vector.
        /// </param>
        /// <returns>
        /// Vector resulting from the multiplication.
        /// </returns>
        public static cVector operator*(Matrix4 lhs, cVector rhs)
        {
            cVector answer = new cVector();
            double[,] vector = new double[4, 1] { { rhs.x }, { rhs.y }, { rhs.z }, { 1 } };
            double[,] ans = new double[4,1] {{0},{0},{0},{0}};
            double element = 0;
            for (int c = 0; c < 1; c++)
                for (int r = 0; r < 4; r++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        element = element + lhs.matrix[r, i] * vector[i, 0];
                    }
                    ans[r, 0] = element;
                    element = 0;
                }
            answer.x = ans[0, 0];
            answer.y = ans[1, 0];
            answer.z = ans[2, 0];
            return answer;
        }
        /// <summary>
        /// Multiplies several matrices together.
        /// </summary>
        /// <param name="series">
        /// array of matrices to be multiplied together.
        /// </param>
        /// <param name="number">
        /// Number of matrices in the array of matrices.
        /// </param>
        /// <returns>
        /// Matrix resulting from the multiplications.
        /// </returns>
        public static Matrix4 ComboMatrix(Matrix4[] series, int number)
        {
            Matrix4 answer = series[0];
            for (int i = 1; i < number;i++ )
            {
                answer = answer * series[i];
            }
            return answer;
        }
    }
}
