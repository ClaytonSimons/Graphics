using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsMatrixRotationLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (AllFilled())
            {
                cVector point = new cVector(Double.Parse(pointxTxt.Text),
                                        Double.Parse(pointyTxt.Text),
                                        Double.Parse(pointzTxt.Text));
                cVector translation = new cVector(Double.Parse(translatexTxt.Text),
                                                Double.Parse(translateyTxt.Text),
                                                Double.Parse(translatezTxt.Text));
                cVector rot = new cVector(Double.Parse(rotationxTxt.Text),
                                        Double.Parse(rotationyTxt.Text),
                                        Double.Parse(rotationzTxt.Text));
                cVector scaling = new cVector(Double.Parse(scalexTxt.Text),
                                            Double.Parse(scaleyTxt.Text),
                                            Double.Parse(scalezTxt.Text));
                Matrix4 transmat = Matrix4.TranslateMatrix(translation);
                Matrix4 rotmat = Matrix4.RotateMatrix(rot);
                Matrix4 scalmat = Matrix4.Scalematrix(scaling);
                Matrix4[] series = new Matrix4[3] { scalmat, rotmat, transmat };
                Matrix4 answer = Matrix4.ComboMatrix(series, 3);

                answer00Txt.Text = answer.matrix[0, 0].ToString();
                answer10Txt.Text = answer.matrix[1, 0].ToString();
                answer20Txt.Text = answer.matrix[2, 0].ToString();
                answer30Txt.Text = answer.matrix[3, 0].ToString();
                answer01Txt.Text = answer.matrix[0, 1].ToString();
                answer11Txt.Text = answer.matrix[1, 1].ToString();
                answer21Txt.Text = answer.matrix[2, 1].ToString();
                answer31Txt.Text = answer.matrix[3, 1].ToString();
                answer02Txt.Text = answer.matrix[0, 2].ToString();
                answer12Txt.Text = answer.matrix[1, 2].ToString();
                answer22Txt.Text = answer.matrix[2, 2].ToString();
                answer32Txt.Text = answer.matrix[3, 2].ToString();
                answer03Txt.Text = answer.matrix[0, 3].ToString();
                answer13Txt.Text = answer.matrix[1, 3].ToString();
                answer23Txt.Text = answer.matrix[2, 3].ToString();
                answer33Txt.Text = answer.matrix[3, 3].ToString();

                cVector panswer = answer * point;
                pointAnswerxTxt.Text = panswer.x.ToString();
                pointAnsweryTxt.Text = panswer.y.ToString();
                pointAnswerzTxt.Text = panswer.z.ToString();
            }
        }
        private bool AllFilled()
        {
            bool answer = false;
            double n;
            if (Double.TryParse(pointxTxt.Text, out n) && 
                Double.TryParse(pointyTxt.Text, out n) &&
                Double.TryParse(pointzTxt.Text, out n) &&
                Double.TryParse(translatexTxt.Text, out n) &&
                Double.TryParse(translateyTxt.Text, out n) &&
                Double.TryParse(translatezTxt.Text, out n) &&
                Double.TryParse(rotationxTxt.Text, out n) &&
                Double.TryParse(rotationyTxt.Text, out n) &&
                Double.TryParse(rotationzTxt.Text, out n) &&
                Double.TryParse(scalexTxt.Text, out n) &&
                Double.TryParse(scaleyTxt.Text, out n) &&
                Double.TryParse(scalezTxt.Text, out n))
            {
                answer = true;
            }
            return answer;
        }
    }
}

