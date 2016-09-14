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
        public double[] polarToCart(double mag, double angleRoll)
        {
            double[] coordCart = new double[2];

            angleRoll = convertToAngle(angleRoll);
            coordCart[0] = ptcGetX(mag, angleRoll);
            coordCart[1] = ptcGetY(mag, angleRoll);

            return coordCart;
        }
        public double[] polarToCart(double mag, double angleRoll,double anglepitch)
        {
            double[] coordCart = new double[3];
            double alpha;
            mag = convertToAngle(mag);
           angleRoll = convertToAngle(angleRoll);
            alpha = getAlpha(mag, angleRoll, anglepitch);
     
            coordCart[0] = ptcGetX(mag, angleRoll);
            coordCart[1] = ptcGetY(mag, angleRoll);
            coordCart[2] = ptcGetZ(mag, alpha);
            

            return coordCart;
        }
        public double ptcGetX(double mag,double angle)//mag cos angle
        {
            return Math.Round(mag * Math.Cos(angle), 2);
        }
        public double ptcGetY(double mag, double angle)//mag sin angle
        {
           return  Math.Round(mag * Math.Sin(angle), 2);
        }
        public double ptcGetZ(double mag, double alpha)//
        {
            return Math.Round(mag * Math.Cos(alpha), 2);
        }       

        /*//////////////////////////////////////////////////////
         /              Cartesean to Polar methods             /
         //////////////////////////////////////////////////////*/
        public double[] cartToPolars(double x, double y)
        {
            double[] coordPolars = new double[2];
            coordPolars[0] = ctpGetR(x, y);
            coordPolars[1] = getTetha(x, y);
            return coordPolars;
        }
        public double[] cartToPolars(double x, double y, double z)
        {
            
            double[] coordPolars = new double[3];
            coordPolars[0] = ctpGetR(x, y, z);
            coordPolars[1] = getTetha(x, y);
            coordPolars[2] = getAlpha(x, y, z);
            return coordPolars;
        }
        public double ctpGetR(double x,double y,double z)
        {
            return (Math.Round(Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)))));// Rz(X^2+Y^2+^2)
        }
        public double ctpGetR(double x, double y)
        {
            return (Math.Round(Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)))));// Rz(X^2+Y^2)
        }


        //Gets Magnitude for Polar
      
        
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
        public double getTetha(double x, double y)
        {
            double newvalue;
            newvalue = Math.Atan(y / x);
            newvalue = Math.Round(convertToAngle(newvalue), 2);
            newvalue = checkQuadrant(newvalue, x, y);

            return newvalue;


        }
        public double getAlpha(double x, double y, double z)
        {
            return Math.Round(convertToAngle(Math.Atan((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) / z))));//Tan^-1((Rz(x^2+Y^2)/z))
        }//Gets the Angle for Polar
         /*/////////////////////////////////////////////////////////
         /                                                         /
         /////////////////////////////////////////////////////////*/

        internal void polarToCart(bool v)
        {
            throw new NotImplementedException();
        }

    }
}
