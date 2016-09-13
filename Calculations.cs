using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculations
    {


        /*//////////////////////////////////////////////////////
         /              Polar to Cortesean methods             /
         //////////////////////////////////////////////////////*/
        public double[] polarToCart(double mag, double angle)
        {
            double[] coordCart = new double[3];

            angle = angle * (Math.PI / 180); //Converts radian to Deg
            coordCart[0] = Math.Round(mag * Math.Cos(angle), 2);//mag cos angle
            coordCart[1] = Math.Round(mag * Math.Sin(angle), 2);//mag sin angle

            return coordCart;
        }

        /*//////////////////////////////////////////////////////
         /              Cortesean to Polar methods             /
         //////////////////////////////////////////////////////*/
        public double[] cartToPolars(double x, double y)
        {
            double radian, angle;
            double[] coordPolars = new double[2];
            radian = Math.Atan(y / x);//tan^-1(Y/X)
            //radian = Math.Atan2(y, x);
            angle = Math.Round(convertToAngle(radian), 2);

            angle = checkQuadrant(angle, x, y);
            coordPolars[0] = Math.Round(Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2))), 2);
            coordPolars[1] = angle;
            return coordPolars;
        }
        public double[] cartToPolars(double x, double y, double z)
        {
            double radian, angle;
            double[] coordPolars = new double[3];
            radian = Math.Atan(y / x);
            //radian = Math.Atan2(y, x);
            angle = Math.Round(convertToAngle(radian), 2);

            angle = checkQuadrant(angle, x, y);
            coordPolars[0] = ctpGetR(x, y, z);
            coordPolars[1] = angle;
            coordPolars[2] = ctpGetAlpha(x, y, z);
            return coordPolars;
        }
        public double ctpGetR(double x,double y,double z)
        {
            return (Math.Round(Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)))));// Rz(X^2+Y^2+^2)
        }//Gets Magnitude for Polar
        public double ctpGetAlpha(double x,double y,double z)
        {
            return Math.Round(convertToAngle(Math.Atan((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) / z))));//Tan^-1((Rz(x^2+Y^2)/z))
        }//Gets the Angle for Polar
        /*//////////////////////////////////////////////////////
         /              Other Methods                          /
         //////////////////////////////////////////////////////*/
        public double checkQuadrant(double angle, double x, double y)
        {

            if (x < 0 && y > 0)//if (-x && y) QUADRANT II
            {
                angle += 180;

            }
            else if (x < 0 && y < 0)//if (-x && -y) QUADRANT III
            {
                angle += 180;
            }
            else if (x > 0 && y < 0)//if (x && -y) QUADRANT IV
            {
                angle += 360;
            }
            return angle;
        }
        public double convertToAngle(double radiant)
        {
            return radiant * (180 / Math.PI);
        }
        internal void polarToCart(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
