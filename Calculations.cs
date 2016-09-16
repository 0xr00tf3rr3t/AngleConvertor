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
            alpha = GetAlpha(mag, angleRoll, anglepitch);

            coordCart[0] = PtcGetX(mag, angleRoll);
            coordCart[1] = PtcGetY(mag, angleRoll);
            coordCart[2] = PtcGetZ(mag, angleRoll, anglepitch);//Alpha


            return coordCart;
        }

        public double PtcGetX(double mag, double angle) //mag cos angle
        {
            return Math.Round(mag* Math.Cos(angle), 2);
        }

        public double PtcGetY(double mag, double angle) //mag sin angle
        {
            return Math.Round(mag* Math.Sin(angle), 2);
        }

        public double PtcGetZ(double mag, double tetha, double alpha) //mag cos alpha
        {
            return Math.Round(mag* Math.Cos(alpha), 2);
        }
        #endregion
        /*//////////////////////////////////////////////////////
         /              Cartesean to Polar methods             /
         //////////////////////////////////////////////////////*/
#region "Cartesean to Polar Methods"
        public double[] CartToPolars(double x, double y)
        {
            var coordPolars = new double[2];
            coordPolars[0] = CtpGetR(x, y);
            coordPolars[1] = GetTetha(x, y);
            return coordPolars;
        }

        public double[] CartToPolars(double x, double y, double z)
        {
            var coordPolars = new double[3];
            coordPolars[0] = CtpGetR(x, y, z);
            coordPolars[1] = GetTetha(x, y);
            coordPolars[2] = GetAlpha(x, y, z);
            return coordPolars;
        }

        public double CtpGetR(double x, double y, double z)
        {
            return Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2))); // Rz(X^2+Y^2+^2)
        }

        public double CtpGetR(double x, double y)
        {
            return Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))); // Rz(X^2+Y^2)
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

        public double ConvertToAngle(double radiant)
        {
            return radiant*(180/Math.PI);
        }

        public double ConvertToRadiant(double angle)
        {
            return angle*(Math.PI/180);
        }

        public double GetTetha(double x, double y)
        {
            double newvalue = 0;
            newvalue = Math.Atan2(y,x);
            newvalue = Math.Round(ConvertToAngle(newvalue), 2);
            newvalue = CheckQuadrant(newvalue, x, y);

            return newvalue;
        }

        public double GetAlpha(double x, double y, double z)
        {
            
            var d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return Math.Round(Math.Atan(d)/z,2);
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