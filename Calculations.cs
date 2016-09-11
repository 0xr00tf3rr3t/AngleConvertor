using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculations
    {
        public double[] polarToCart(double mag,double angle)
        { double[] coordCart = new double[2];
        
            angle =angle *(Math.PI/180); //Converts radian to Deg
           coordCart[0]= Math.Round(mag * Math.Cos(angle),2);
            coordCart[1] = Math.Round(mag * Math.Sin(angle),2);
            return coordCart;
        }
        public double[] cartToPolars(double x, double y)
        {
            double radian, angle;
            double[] coordPolars = new double[2];
             radian = Math.Atan(y / x);
            angle = radian * (180 / Math.PI);

            angle = checkQuadrant(angle, x, y);
            coordPolars[0] = Math.Round(Math.Sqrt((Math.Pow(x, 2) +Math.Pow(y, 2))),2);
            coordPolars[1] = Math.Round(angle,1);
            return coordPolars;
        }
        public double checkQuadrant(double angle,double x, double y)
        {

            if (x < 0 && y > 0)//if -x && y QUADRANT II
            {
                angle += 180;

            }
            else if (x < 0 && y < 0)//if -x && -y QUADRANT III
            {
                angle += 180;
            }
            else if (x > 0 && y < 0)//if x && -y QUADRANT IV
            {
                angle += 360;
            }
            return angle;
        }

        internal void polarToCart(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
