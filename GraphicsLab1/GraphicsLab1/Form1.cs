using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ClearAnswers()
        {
            scalarAnswerTxt.Text = "";
            vectorxAnswerTxt.Text = "";
            vectoryAnswerTxt.Text = "";
            vectorzAnswerTxt.Text = "";
        }
        public void ClearEntries()
        {
            scalarTxt.Text = "";
            
            vector1xTxt.Text = "";
            vector1yTxt.Text = "";
            vector1zTxt.Text = "";

            vector2xTxt.Text = "";
            vector2yTxt.Text = "";
            vector2zTxt.Text = "";
        }
        public void ClearAll()
        {
            ClearAnswers();
            ClearEntries();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(addVectorRad.Checked && VectorsFilled())
            {
                cVector v1 = new cVector(Double.Parse(vector1xTxt.Text), 
                    Double.Parse(vector1yTxt.Text), 
                    Double.Parse(vector1zTxt.Text));
                cVector v2 = new cVector(Double.Parse(vector2xTxt.Text), 
                    Double.Parse(vector2yTxt.Text), 
                    Double.Parse(vector2zTxt.Text));
                cVector answer = v1 + v2;
                vectorxAnswerTxt.Text = answer.x.ToString();
                vectoryAnswerTxt.Text = answer.y.ToString();
                vectorzAnswerTxt.Text = answer.z.ToString();
            }
            else if(addScalarRBtn.Checked && ScalarFilled())
            {
                cVector v1 = new cVector(Double.Parse(vector1xTxt.Text),
                    Double.Parse(vector1yTxt.Text),
                    Double.Parse(vector1zTxt.Text));
                double s = Double.Parse(scalarTxt.Text);
                cVector answer = v1 + s;
                vectorxAnswerTxt.Text = answer.x.ToString();
                vectoryAnswerTxt.Text = answer.y.ToString();
                vectorzAnswerTxt.Text = answer.z.ToString();
            }
            else if(subVectorRBtn.Checked && VectorsFilled())
            {
                cVector v1 = new cVector(Double.Parse(vector1xTxt.Text),
                    Double.Parse(vector1yTxt.Text),
                    Double.Parse(vector1zTxt.Text));
                cVector v2 = new cVector(Double.Parse(vector2xTxt.Text),
                    Double.Parse(vector2yTxt.Text),
                    Double.Parse(vector2zTxt.Text));
                cVector answer = v1 - v2;
                vectorxAnswerTxt.Text = answer.x.ToString();
                vectoryAnswerTxt.Text = answer.y.ToString();
                vectorzAnswerTxt.Text = answer.z.ToString();
            }
            else if(SubScalarRBtn.Checked && ScalarFilled())
            {
                cVector v1 = new cVector(Double.Parse(vector1xTxt.Text),
                    Double.Parse(vector1yTxt.Text),
                    Double.Parse(vector1zTxt.Text));
                double s = Double.Parse(scalarTxt.Text);
                cVector answer = v1 - s;
                vectorxAnswerTxt.Text = answer.x.ToString();
                vectoryAnswerTxt.Text = answer.y.ToString();
                vectorzAnswerTxt.Text = answer.z.ToString();
            }
            else if(multVectorRBtn.Checked && VectorsFilled())
            {
                cVector v1 = new cVector(Double.Parse(vector1xTxt.Text),
                    Double.Parse(vector1yTxt.Text),
                    Double.Parse(vector1zTxt.Text));
                cVector v2 = new cVector(Double.Parse(vector2xTxt.Text),
                    Double.Parse(vector2yTxt.Text),
                    Double.Parse(vector2zTxt.Text));
                cVector answer = v1 * v2;
                vectorxAnswerTxt.Text = answer.x.ToString();
                vectoryAnswerTxt.Text = answer.y.ToString();
                vectorzAnswerTxt.Text = answer.z.ToString();
            }
            else if(multScalarRBtn.Checked && ScalarFilled())
            {
                cVector v1 = new cVector(Double.Parse(vector1xTxt.Text),
                    Double.Parse(vector1yTxt.Text),
                    Double.Parse(vector1zTxt.Text));
                double s = Double.Parse(scalarTxt.Text);
                cVector answer = v1 * s;
                vectorxAnswerTxt.Text = answer.x.ToString();
                vectoryAnswerTxt.Text = answer.y.ToString();
                vectorzAnswerTxt.Text = answer.z.ToString();
            }
            else if(divScalarRBtn.Checked && ScalarFilled())
            {
                cVector v1 = new cVector(Double.Parse(vector1xTxt.Text),
                    Double.Parse(vector1yTxt.Text),
                    Double.Parse(vector1zTxt.Text));
                double s = Double.Parse(scalarTxt.Text);
                cVector answer = v1 / s;
                vectorxAnswerTxt.Text = answer.x.ToString();
                vectoryAnswerTxt.Text = answer.y.ToString();
                vectorzAnswerTxt.Text = answer.z.ToString();
            }
            else if(dotRBtn.Checked && VectorsFilled())
            {
                cVector v1 = new cVector(Double.Parse(vector1xTxt.Text),
                    Double.Parse(vector1yTxt.Text),
                    Double.Parse(vector1zTxt.Text));
                cVector v2 = new cVector(Double.Parse(vector2xTxt.Text),
                    Double.Parse(vector2yTxt.Text),
                    Double.Parse(vector2zTxt.Text));
                double answer = v1 % v2;
                scalarAnswerTxt.Text = answer.ToString();
            }
            else if(crossRBtn.Checked && VectorsFilled())
            {
                cVector v1 = new cVector(Double.Parse(vector1xTxt.Text),
                    Double.Parse(vector1yTxt.Text),
                    Double.Parse(vector1zTxt.Text));
                cVector v2 = new cVector(Double.Parse(vector2xTxt.Text),
                    Double.Parse(vector2yTxt.Text),
                    Double.Parse(vector2zTxt.Text));
                cVector answer = v1 ^ v2;
                vectorxAnswerTxt.Text = answer.x.ToString();
                vectoryAnswerTxt.Text = answer.y.ToString();
                vectorzAnswerTxt.Text = answer.z.ToString();
            }
            else if(magRBtn.Checked && Vector1Filled())
            {
                cVector v1 = new cVector(Double.Parse(vector1xTxt.Text),
                    Double.Parse(vector1yTxt.Text),
                    Double.Parse(vector1zTxt.Text));
                double answer = !v1;
                scalarAnswerTxt.Text = answer.ToString();
            }
            else if(unitRBtn.Checked && ScalarFilled())
            {
                cVector v1 = new cVector(Double.Parse(vector1xTxt.Text),
                    Double.Parse(vector1yTxt.Text),
                    Double.Parse(vector1zTxt.Text));
                double s = Double.Parse(scalarTxt.Text);
                cVector answer = v1 | s;
                vectorxAnswerTxt.Text = answer.x.ToString();
                vectoryAnswerTxt.Text = answer.y.ToString();
                vectorzAnswerTxt.Text = answer.z.ToString();
            }
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void clearEntriesBtn_Click(object sender, EventArgs e)
        {
            ClearEntries();
        }
        private bool VectorsFilled()
        {
            bool answer = false;
            double x = 1, y = 1, z = 1;
            if (Double.TryParse(vector1xTxt.Text, out x) && Double.TryParse(vector1yTxt.Text, out y) && Double.TryParse(vector1zTxt.Text, out z)
                && Double.TryParse(vector2xTxt.Text, out x) && Double.TryParse(vector2yTxt.Text, out y) && Double.TryParse(vector2zTxt.Text, out z))
            {
                answer = true;
            }
            return answer;
        }
        private bool Vector1Filled()
        {
            bool answer = false;
            double x = 1, y = 1, z = 1;
            if (Double.TryParse(vector1xTxt.Text, out x) && Double.TryParse(vector1yTxt.Text, out y) && Double.TryParse(vector1zTxt.Text, out z))
            {
                answer = true;
            }
            return answer;
        }
        private bool ScalarFilled()//and vector 1 entries
        {
            bool answer = false;
            double x = 1, y = 1, z = 1;
            if (Double.TryParse(vector1xTxt.Text, out x) && Double.TryParse(vector1yTxt.Text, out y) && Double.TryParse(vector1zTxt.Text, out z)
                && Double.TryParse(scalarTxt.Text,out x))
            {
                answer = true;
            }
            return answer;
        }
    }
}
