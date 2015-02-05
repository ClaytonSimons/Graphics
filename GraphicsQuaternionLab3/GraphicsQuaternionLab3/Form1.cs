using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsQuaternionLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (inverseRad.Checked && Quaternion1Filled())
            {
                Quaternion q1 = new Quaternion(Double.Parse(quaternion1sTxt.Text),
                                                Double.Parse(quaternion1iTxt.Text),
                                                Double.Parse(quaternion1jTxt.Text),
                                                Double.Parse(quaternion1kTxt.Text));
                Quaternion answer = q1.Inverse();
                quaternionsAnswerTxt.Text = answer.gets().ToString();
                quaternioniAnswerTxt.Text = answer.geti().ToString();
                quaternionjAnswerTxt.Text = answer.getj().ToString();
                quaternionkAnswerTxt.Text = answer.getk().ToString();
            }
            else if(addRad.Checked && QuaternionsFilled())
            {
                Quaternion q1 = new Quaternion(Double.Parse(quaternion1sTxt.Text),
                                                Double.Parse(quaternion1iTxt.Text),
                                                Double.Parse(quaternion1jTxt.Text),
                                                Double.Parse(quaternion1kTxt.Text));
                Quaternion q2 = new Quaternion(Double.Parse(quaternion2sTxt.Text),
                                Double.Parse(quaternion2iTxt.Text),
                                Double.Parse(quaternion2jTxt.Text),
                                Double.Parse(quaternion2kTxt.Text));
                Quaternion answer = q1 + q2;
                quaternionsAnswerTxt.Text = answer.gets().ToString();
                quaternioniAnswerTxt.Text = answer.geti().ToString();
                quaternionjAnswerTxt.Text = answer.getj().ToString();
                quaternionkAnswerTxt.Text = answer.getk().ToString();
            }
            else if(subtractRad.Checked && QuaternionsFilled())
            {
                Quaternion q1 = new Quaternion(Double.Parse(quaternion1sTxt.Text),
                                Double.Parse(quaternion1iTxt.Text),
                                Double.Parse(quaternion1jTxt.Text),
                                Double.Parse(quaternion1kTxt.Text));
                Quaternion q2 = new Quaternion(Double.Parse(quaternion2sTxt.Text),
                                Double.Parse(quaternion2iTxt.Text),
                                Double.Parse(quaternion2jTxt.Text),
                                Double.Parse(quaternion2kTxt.Text));
                Quaternion answer = q1 - q2;
                quaternionsAnswerTxt.Text = answer.gets().ToString();
                quaternioniAnswerTxt.Text = answer.geti().ToString();
                quaternionjAnswerTxt.Text = answer.getj().ToString();
                quaternionkAnswerTxt.Text = answer.getk().ToString();
            }
            else if(multiplyRad.Checked && QuaternionsFilled())
            {
                Quaternion q1 = new Quaternion(Double.Parse(quaternion1sTxt.Text),
                                Double.Parse(quaternion1iTxt.Text),
                                Double.Parse(quaternion1jTxt.Text),
                                Double.Parse(quaternion1kTxt.Text));
                Quaternion q2 = new Quaternion(Double.Parse(quaternion2sTxt.Text),
                                Double.Parse(quaternion2iTxt.Text),
                                Double.Parse(quaternion2jTxt.Text),
                                Double.Parse(quaternion2kTxt.Text));
                Quaternion answer = q1 * q2;
                quaternionsAnswerTxt.Text = answer.gets().ToString();
                quaternioniAnswerTxt.Text = answer.geti().ToString();
                quaternionjAnswerTxt.Text = answer.getj().ToString();
                quaternionkAnswerTxt.Text = answer.getk().ToString();
            }
            else if(divideRad.Checked && QuaternionsFilled())
            {
                Quaternion q1 = new Quaternion(Double.Parse(quaternion1sTxt.Text),
                                Double.Parse(quaternion1iTxt.Text),
                                Double.Parse(quaternion1jTxt.Text),
                                Double.Parse(quaternion1kTxt.Text));
                Quaternion q2 = new Quaternion(Double.Parse(quaternion2sTxt.Text),
                                Double.Parse(quaternion2iTxt.Text),
                                Double.Parse(quaternion2jTxt.Text),
                                Double.Parse(quaternion2kTxt.Text));
                Quaternion answer = q1 / q2;
                quaternionsAnswerTxt.Text = answer.gets().ToString();
                quaternioniAnswerTxt.Text = answer.geti().ToString();
                quaternionjAnswerTxt.Text = answer.getj().ToString();
                quaternionkAnswerTxt.Text = answer.getk().ToString();
            }
            else if(magnitudeRad.Checked && Quaternion1Filled() && ScalarFilled())
            {
                Quaternion q1 = new Quaternion(Double.Parse(quaternion1sTxt.Text),
                                Double.Parse(quaternion1iTxt.Text),
                                Double.Parse(quaternion1jTxt.Text),
                                Double.Parse(quaternion1kTxt.Text));
                Double answer = q1.Magnitude();
                scalarAnswerTxt.Text = answer.ToString();
            }
            else if(rotationRad.Checked && QuaternionsFilled() && ScalarFilled())
            {
                Quaternion q1 = new Quaternion(Double.Parse(quaternion1sTxt.Text),
                                Double.Parse(quaternion1iTxt.Text),
                                Double.Parse(quaternion1jTxt.Text),
                                Double.Parse(quaternion1kTxt.Text));
                Quaternion q2 = new Quaternion(Double.Parse(quaternion2sTxt.Text),
                                Double.Parse(quaternion2iTxt.Text),
                                Double.Parse(quaternion2jTxt.Text),
                                Double.Parse(quaternion2kTxt.Text));
                Double a = Double.Parse(angleTxt.Text);
                Quaternion answer = q1.rotatePointByAngleAboutAxisVector(q1, a, q2);
                quaternionsAnswerTxt.Text = answer.gets().ToString();
                quaternioniAnswerTxt.Text = answer.geti().ToString();
                quaternionjAnswerTxt.Text = answer.getj().ToString();
                quaternionkAnswerTxt.Text = answer.getk().ToString();
            }

        }
            private bool QuaternionsFilled()
            {
                bool answer = false;
                double n = 1;
                if(Double.TryParse(quaternion1sTxt.Text,out n) && Double.TryParse(quaternion1iTxt.Text,out n) && Double.TryParse(quaternion1jTxt.Text,out n) && Double.TryParse(quaternion1kTxt.Text,out n)
                    && Double.TryParse(quaternion2sTxt.Text,out n) && Double.TryParse(quaternion2iTxt.Text,out n) && Double.TryParse(quaternion2jTxt.Text,out n) && Double.TryParse(quaternion2kTxt.Text,out n))
                {
                    answer = true;
                }
                return answer;
            }
            private bool Quaternion1Filled()
            {
                bool answer = false;
                double n = 1;
                if (Double.TryParse(quaternion1sTxt.Text, out n) && Double.TryParse(quaternion1iTxt.Text, out n) && Double.TryParse(quaternion1jTxt.Text, out n) && Double.TryParse(quaternion1kTxt.Text, out n))
                {
                    answer = true;
                }
                return answer;
            }
            private bool ScalarFilled()
            {
                bool answer = false;
                double n = 1;
                if (Double.TryParse(angleTxt.Text, out n))
                {
                    answer = true;
                }
                return answer;
            }
    }
}
