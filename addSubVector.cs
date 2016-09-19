using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class addSubVector : Form
    {
        #region
        string inputAx, inputAy, inputAz, inputBx, inputBy, inputBz;
        double Ax = 0, Ay = 0, Az = 0, Bx = 0, By = 0, Bz = 0, Rx = 0, Ry = 0, Rz = 0, Magnitude = 0, Theta = 0, Alpha = 0;
        #endregion

        /*private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSubVector));
            this.SuspendLayout();
            // 
            // addSubVector
            // 
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(357, 253);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addSubVector";
            this.ResumeLayout(false);

        }*/

        public addSubVector()
        {
            InitializeComponent();
        }

        private void addSubVector_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string inputAx, inputAy, inputAz, inputBx, inputBy, inputBz;
            //double Ax = 0, Ay = 0, Az = 0, Bx = 0, By = 0, Bz = 0, Rx = 0, Ry = 0, Rz = 0, Magnitude = 0, Theta = 0, Alpha = 0;
            double[] resultR = new double[3];

            inputAx = txtAx.Text;
            inputAy = txtAy.Text;
            inputAz = txtAz.Text;

            inputBx = txtBx.Text;
            inputBy = txtBy.Text;
            inputBz = txtBz.Text;

            if( checkForNumber(inputAx))
            {
                Ax = convertToDouble(inputAx);
            }

            if ( checkForNumber(inputAy))
            {
                Ay = convertToDouble(inputAy);
            }

            if (checkForNumber(inputAz))
            {
                Az = convertToDouble(inputAz);
            }

            if ( checkForNumber(inputBx))
            {
                Bx = convertToDouble(inputBx);
            }

            if ( checkForNumber(inputBy))
            {
                By = convertToDouble(inputBy);
            }

            if (checkForNumber(inputBz))
            {
                Bz = convertToDouble(inputBz);
            }

            resultR = addVectors(Ax, Ay, Az, Bx, By, Bz);

            lblRX.Text = resultR[0].ToString() + "î";
            lblRY.Text = resultR[1].ToString() + "ĵ";
            lblRZ.Text = resultR[2].ToString() + "k";

            Rx = resultR[0];
            Ry = resultR[1];
            Rz = resultR[2];

            Magnitude = getMag(Rx, Ry, Rz);
            lblMagRes.Text = "Sqrt(" + Rx + "² + " + Ry + "² + " + Rz + "²) = " + Magnitude.ToString();

            Theta = getTheta(Rx, Ry);
            lblThetaRes.Text = "Atan(" + Ry + "/" + Rx + ") = " + Theta.ToString() + "°";

            if(Rz < 0 || Rz > 0)
            {
                Alpha = getAlpha(Rx, Ry, Rz);
                lblAlphaRes.Text = Alpha.ToString() + "°";
            }
            else
            {
                lblAlphaRes.Text = Alpha.ToString();
            }


        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            //string inputAx, inputAy, inputAz, inputBx, inputBy, inputBz;
            //double Ax = 0, Ay = 0, Az = 0, Bx = 0, By = 0, Bz = 0, Rx = 0, Ry = 0, Rz = 0, Magnitude = 0, Theta = 0, Alpha = 0;
            double[] resultR = new double[3];

            inputAx = txtAx.Text;
            inputAy = txtAy.Text;
            inputAz = txtAz.Text;

            inputBx = txtBx.Text;
            inputBy = txtBy.Text;
            inputBz = txtBz.Text;

            if (checkForNumber(inputAx))
            {
                Ax = convertToDouble(inputAx);
            }

            if (checkForNumber(inputAy))
            {
                Ay = convertToDouble(inputAy);
            }

            if ( checkForNumber(inputAz))
            {
                Az = convertToDouble(inputAz);
            }

            if ( checkForNumber(inputBx))
            {
                Bx = convertToDouble(inputBx);
            }

            if (checkForNumber(inputBy))
            {
                By = convertToDouble(inputBy);
            }

            if ( checkForNumber(inputBz))
            {
                Bz = convertToDouble(inputBz);
            }

            resultR = subVectors(Ax, Ay, Az, Bx, By, Bz);

            lblRX.Text = resultR[0].ToString() + "î";
            lblRY.Text = resultR[1].ToString() + "ĵ";
            lblRZ.Text = resultR[2].ToString() + "k";

            Rx = resultR[0];
            Ry = resultR[1];
            Rz = resultR[2];

            Magnitude = getMag(Rx, Ry, Rz);
            lblMagRes.Text = "Sqrt(" + Rx + "² + " + Ry + "² + " + Rz + "²) = " + Magnitude.ToString();

            Theta = getTheta(Rx, Ry);
            lblThetaRes.Text = "Atan(" + Ry + "/" + Rx + ") = " + Theta.ToString() + "°";

            if (Rz < 0 || Rz > 0)
            {
                Alpha = getAlpha(Rx, Ry, Rz);
                lblAlphaRes.Text = Alpha.ToString() + "°";
            }
            else
            {
                lblAlphaRes.Text = Alpha.ToString();
            }

        }

        public double[] addVectors(double Ax, double Ay, double Az, double Bx, double By, double Bz)
        {
            double[] result = new double[3];

            result[0] = Math.Round(Ax + Bx, 2);
            result[1] = Math.Round(Ay + By, 2);
            result[2] = Math.Round(Az + Bz, 2);

            return result; 
        }

        public double[] subVectors(double Ax, double Ay, double Az, double Bx, double By, double Bz)
        {
            double[] result = new double[3];

            result[0] = Math.Round(Ax - Bx, 2);
            result[1] = Math.Round(Ay - By, 2);
            result[2] = Math.Round(Az - Bz, 2);

            return result;
        }

        public double getMag(double Rx, double Ry, double Rz)
        {
            return Math.Round(Math.Sqrt(Math.Pow(Rx, 2) + Math.Pow(Ry, 2) + Math.Pow(Rz, 2)));
        }

        public double getTheta(double Rx, double Ry)
        {
            double Theta;

            Theta = Math.Round(Math.Atan(Ry / Rx));
            Theta = Math.Round(convertToAngle(Theta));
            Theta = Math.Round(checkQuadrant(Theta, Rx, Ry));

            return Theta;
        }

        public double getAlpha(double Rx, double Ry, double Rz)
        {
            return Math.Round(convertToAngle(Math.Atan((Math.Sqrt(Math.Pow(Rx, 2) + Math.Pow(Ry, 2)) / Rz))));
        }

        public double checkQuadrant(double Theta, double Rx, double Ry)
        {
            if (Theta < 0 && Rx > 0 && Ry > 0)
            {
                Math.Abs(Theta);
            }
            else if (Rx < 0 && Ry > 0)
            {
                Theta += 180;
            }
            else if (Rx < 0 && Ry < 0)
            {
                Theta += 180;
            }
            else if (Theta < 0 && Rx > 0 && Ry < 0)
            {
                Theta += 360;
            }
            else if (Theta > 0 && Rx > 0 && Ry < 0)
            {
                Theta = 360 - Theta;
            }

            return Theta;
        }

        public double convertToAngle(double radiant)
        {
            return radiant * (180 / Math.PI);
        }

        //Check and process user input code
      

        public bool checkForNumber(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            else

                foreach (char c in input)
                {
                    if (c < '0' || c > '9')
                        if (c != '.' && c != '-')
                        {
                            return false;
                        }



                }
            return true;
        }

        public double convertToDouble(string input)
        {
            return Convert.ToDouble(input);
        }

    }
}
