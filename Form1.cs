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
    public partial class fmCalculation : Form
    { Calculations calculations=new Calculations() ;
        double[] newCordinatesCart = new double[3];
        double[] newCordinatesPolars = new double[3];
        public fmCalculation()
        {
            InitializeComponent();
        }

        private void RbPolares_CheckedChanged(object sender, EventArgs e) //Sets textbox on the other to false and to his true
        {
            if (RbPolares.Checked == true)
            {//Cartecian's Radio Button
                RbCartecianas.Checked = false;
                //Cartesian Text Boxes
                TbCartX.Visible = false;
                TbCartY.Visible = false;
                TbCartZ.Visible = false;
                //Polar Text Boxes
                TbPolarX.Visible = true;
                TbPolarY.Visible = true;
                TbPolarZ.Visible = true;
                //Polar Text Boxes
                LblPolarX.Visible = false;
                LblPolarY.Visible = false;
                LblPolarZ.Visible = false;
                //Cartesian labels
                LblCartX.Visible = true;
                LblCartY.Visible = true;
                LblCartZ.Visible = true;
            }
        }

        private void RbCartecianas_CheckedChanged(object sender, EventArgs e)
        {
            if (RbCartecianas.Checked == true)
            {    
                //Polar Radio Button
                RbPolares.Checked = false;
                //Polar Text Boxes
                TbPolarX.Visible = false;
                TbPolarY.Visible = false;
                TbPolarZ.Visible = false;
                //Cartesian Text Boxes
                TbCartX.Visible = true;
                TbCartY.Visible = true;
                TbCartZ.Visible = true;
                //Polar labels 
                LblPolarX.Visible = true;
                LblPolarY.Visible = true;
                LblPolarZ.Visible = true;
                //Cartesian labels
                LblCartX.Visible = false;
                LblCartY.Visible = false;
                LblCartZ.Visible = false;

            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*////////////////////////////////////////////////////////////////////////////////////////////////////////////
             *                                                                                                           *
             *                                           Polar calls from Form                                           *
             *                                                                                                           *
             ////////////////////////////////////////////////////////////////////////////////////////////////////////////*/
            if (RbPolares.Checked== true)
            {if (cb3DPolar.Checked != true)
                {
                    if (checkForNumber(TbPolarX.Text) == true && checkForNumber(TbPolarY.Text) == true&& checkPolarAngles(TbPolarX.Text,TbPolarY.Text))
                    {
                        newCordinatesCart = calculations.PolarToCart(double.Parse(TbPolarX.Text), double.Parse(TbPolarY.Text));
                        LblCartX.Text = newCordinatesCart[0].ToString();
                        LblCartY.Text = newCordinatesCart[1].ToString();
                        LblCartZ.Text = "0";
                    }
                    else MessageBox.Show("Only Numbers are accepted! Make sure the input isn't empty, or 0", "Error Found!");
                }
                else
                {
                    if (checkForNumber(TbPolarX.Text.ToString()) == true && checkForNumber(TbPolarY.Text.ToString()) == true && checkForNumber(TbPolarZ.Text.ToString()) == true&& checkPolarAngles(TbPolarX.Text.ToString(), TbPolarY.Text.ToString(),TbPolarZ.Text.ToString()))
                    {
                        newCordinatesCart = calculations.PolarToCart(double.Parse(TbPolarX.Text), double.Parse(TbPolarY.Text), double.Parse(TbPolarZ.Text));
                        LblCartX.Text = newCordinatesCart[0].ToString();
                        LblCartY.Text = newCordinatesCart[1].ToString();
                        LblCartZ.Text = newCordinatesCart[2].ToString();
                    }
                    else MessageBox.Show("Only Numbers are accepted! Make sure the input isn't empty, or 0", "Error Found!");
                }
            }


            /*////////////////////////////////////////////////////////////////////////////////////////////////////////////
             *                                                                                                           *
             *                                           Cartesian calls from Form                                           *
             *                                                                                                           *
             ////////////////////////////////////////////////////////////////////////////////////////////////////////////*/

            else if (RbCartecianas.Checked == true)
            {  if (cb3DCart.Checked!=true)
                {
                    if (checkForNumber(TbCartX.Text.ToString()) == true && checkForNumber(TbCartY.Text.ToString()) == true)
                    {
                        newCordinatesPolars = calculations.CartToPolars(double.Parse(TbCartX.Text), double.Parse(TbCartY.Text));
                        LblPolarX.Text = newCordinatesPolars[0].ToString();
                        LblPolarY.Text = newCordinatesPolars[1].ToString() + "°";
                        LblPolarZ.Text = "0";
                    }
                    else MessageBox.Show("Only Numbers are accepted! Make sure the input isn't empty, or 0", "Error Found!");
                }
                else
                {
                    if (checkForNumber(TbCartX.Text.ToString()) == true && checkForNumber(TbCartY.Text.ToString()) == true&&checkForNumber(TbCartZ.Text.ToString()))
                    {
                        newCordinatesPolars = calculations.CartToPolars(double.Parse(TbCartX.Text), double.Parse(TbCartY.Text), double.Parse(TbCartZ.Text));
                        LblPolarX.Text = newCordinatesPolars[0].ToString();
                        LblPolarY.Text = newCordinatesPolars[1].ToString() + "°";
                        LblPolarZ.Text = newCordinatesPolars[2].ToString();
                    }
                    else MessageBox.Show("Only Numbers are accepted! Make sure the input isn't empty, or 0", "Error Found!");
                }
               
            }
        }
        
        public bool checkForNumber(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;}

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
        }//Check if there are letters inside the txtboxes
        public bool checkPolarAngles(string mag,string angleRoll,string anglePitch )
        {    if (checkForNumber(mag) == true && checkForNumber(angleRoll) == true && checkForNumber(anglePitch) == true)
            {
                if (double.Parse(mag) < 0)
                {
                    MessageBox.Show("Remember that magnitud can't be 0");
                    return false;
                }
                else if (double.Parse(angleRoll) > 360 || double.Parse(angleRoll) < 0)
                {
                    MessageBox.Show("Remember that the roll angle can't be negative or 360°");
                    return false;
                }
                else if (double.Parse(anglePitch) > 90)
                {
                    MessageBox.Show("Remember that the pitch angle haves to be less than 90°");
                    return false;
                }


                return true;
            }
            return false;
   
        }//Validates negativity and such
        public bool checkPolarAngles(string mag, string angleRoll)
        {
            if (double.Parse(mag) < 0)
            {
                MessageBox.Show("Remember that magnitud can't be 0°");
                return false;
            }
            else if (double.Parse(angleRoll) > 360 || double.Parse(angleRoll) < 0)
            {
                MessageBox.Show("Remember that the roll angle can't be negative or 360°");
            }
            
            return true;
        }// Validates negativity and such 


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cb3DPolar_CheckedChanged(object sender, EventArgs e)
        {
            if(cb3DPolar.Checked == true)
            {
                TbPolarZ.ReadOnly = false;

            }
            else
            {
                TbPolarZ.ReadOnly = true;
            }
        }

        private void cb3DCart_CheckedChanged(object sender, EventArgs e)
        {
            if (cb3DCart.Checked == true)
            {
                TbCartZ.ReadOnly = false;
            }
            else TbCartZ.ReadOnly = true;
        }
    }
}
