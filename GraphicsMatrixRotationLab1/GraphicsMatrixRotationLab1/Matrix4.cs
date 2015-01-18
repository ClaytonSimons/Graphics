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
        public Matrix4(double[,] mat)
        {
            if(mat.Length == 16)
                matrix = mat;
        }
        public Matrix4(Matrix4 copy)
        {
            matrix = copy.matrix;
        }
        public static Matrix4 TranslateMatrix(cVector dir)
        {
            return new Matrix4(new double[4,4] {{1,0,0,dir.x},
                                                        {0,1,0,dir.y},
                                                        {0,0,1,dir.z},
                                                        {0,0,0,1}});
        }
        public static Matrix4 Scalematrix(cVector dir)
        {
            return new Matrix4(new double[4, 4] {{dir.x,0,0,0},
                                                        {0,dir.y,0,0},
                                                        {0,0,dir.z,0},
                                                        {0,0,0,1}});
        }
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
