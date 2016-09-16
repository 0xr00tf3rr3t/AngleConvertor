using System;

namespace Calculator
{
    internal class Calculations
    {
        /*//////////////////////////////////////////////////////
         /              Polar to Cortesean methods             /
         //////////////////////////////////////////////////////*/
        #region "Polar to Cartesean Methods"

        public double[] PolarToCart(double mag, double angleRoll)
        {
            var coordCart = new double[2] {0, 0};
            angleRoll = ConvertToRadiant(angleRoll);

            coordCart[0] = PtcGetX(mag, angleRoll);
            coordCart[1] = PtcGetY(mag, angleRoll);
            return coordCart;
        }

        public double[] PolarToCart(double mag, double angleRoll, double anglepitch)
        {
            var coordCart = new double[3] {0, 0, 0};
            double alpha = 0;
            angleRoll = ConvertToRadiant(angleRoll);
            anglepitch = ConvertToRadiant(anglepitch);

            coordCart[0] = Math.Round(PtcGetX(mag, angleRoll),2);
            coordCart[1] = Math.Round(PtcGetY(mag, angleRoll),2);
            coordCart[2] = Math.Round(PtcGetZ(mag, angleRoll, anglepitch),2);//Alpha


            return coordCart;
        }

        public double PtcGetX(double mag, double angle) //mag cos angle
        {
            return mag* Math.Cos(angle);
        }

        public double PtcGetY(double mag, double angle) //mag sin angle
        {
            return mag* Math.Sin(angle);
        }

        public double PtcGetZ(double mag, double tetha, double alpha) //mag cos alpha
        {
            return mag* Math.Cos(alpha);
        }
        #endregion
        /*//////////////////////////////////////////////////////
         /              Cartesean to Polar methods             /
         //////////////////////////////////////////////////////*/
#region Cartesean to Polar Methods
        public double[] CartToPolars(double x, double y)
        {
            var coordPolars = new double[2];
            coordPolars[0] = Math.Round(CtpGetR(x, y),2);
            coordPolars[1] = Math.Round(GetTetha(x, y),2);
            return coordPolars;
        }

        public double[] CartToPolars(double x, double y, double z)
        {
            var coordPolars = new double[3];
            coordPolars[0] = Math.Round(CtpGetR(x, y, z),2);
            coordPolars[1] =Math.Round(GetTetha(x, y),2);
            coordPolars[2] = Math.Round(ConvertToDegree(GetAlpha(x, y, z)),2);
            return coordPolars;
        }

        public double CtpGetR(double x, double y, double z)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)); // Rz(X^2+Y^2+^2)
        }

        public double CtpGetR(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)); // Rz(X^2+Y^2)
        }
        #endregion

        /*//////////////////////////////////////////////////////
         /              Other Methods                          /
         //////////////////////////////////////////////////////*/
        #region  Other Methods
        public double CheckQuadrant(double angle, double x, double y)
        {
            if (x < 0 && y > 0) //if (-x && y) QUADRANT II
            {
                angle += 180;
            }
            else if (x < 0 && y < 0) //if (-x && -y) QUADRANT III
            {
                angle += 180;
            }
            else if (x > 0 && y < 0) //if (x && -y) QUADRANT IV
            {
                angle += 360;
            }
            return angle;
        }

        public double ConvertToDegree(double radiant)
        {
            return radiant*(180/Math.PI);
        }

        public double ConvertToRadiant(double angle)
        {
            return (Math.PI/180)*angle;
        }

        public double GetTetha(double x, double y)
        {
            double newvalue = 0;
            newvalue = Math.Atan2(y,x);
            newvalue = ConvertToDegree(newvalue);
            newvalue = CheckQuadrant(newvalue, x, y);

            return newvalue;
        }

        public double GetAlpha(double x, double y, double z)
        {

            var d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return Math.Atan2(d,z);
                //Tan^-1((Rz(x^2+Y^2)/z))
        }
#endregion

        /*/////////////////////////////////////////////////////////
         /                                                         /
         /////////////////////////////////////////////////////////*/

        internal void PolarToCart(bool v)
        {
            throw new NotImplementedException();
        }
    }
}