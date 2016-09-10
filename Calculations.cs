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
        
            angle =(angle *Math.PI)/180; //Converts radian to Deg
           coordCart[0]= Math.Round(mag * Math.Cos(angle),3);
            coordCart[1] = Math.Round(mag * Math.Sin(angle),3);
            return coordCart;
        }

        internal void polarToCart(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
