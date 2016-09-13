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
    public partial class Form1 : Form
    { Calculations calculations=new Calculations() ;
        double[] newCordinatesCart = new double[3];
        double[] newCordinatesPolars = new double[3];
        public Form1()
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

            if (RbPolares.Checked== true)
            {
                if (checkForNumber(TbPolarX.Text.ToString()) == true && checkForNumber(TbPolarY.Text.ToString()) == true)
                {
                    newCordinatesCart = calculations.polarToCart(double.Parse(TbPolarX.Text), double.Parse(TbPolarY.Text));
                    LblCartX.Text = newCordinatesCart[0].ToString();
                    LblCartY.Text = newCordinatesCart[1].ToString();
                }
                else MessageBox.Show("Only Numbers are accepted!", "Error Found!");
            }
            else if (RbCartecianas.Checked == true)
            {  if (cb3DCart.Checked!=true)
                {
                    if (checkForNumber(TbCartX.Text.ToString()) == true && checkForNumber(TbCartY.Text.ToString()) == true)
                    {
                        newCordinatesPolars = calculations.cartToPolars(double.Parse(TbCartX.Text), double.Parse(TbCartY.Text));
                        LblPolarX.Text = newCordinatesPolars[0].ToString();
                        LblPolarY.Text = newCordinatesPolars[1].ToString() + "°";
                        LblPolarZ.Text = "0";
                    }
                    else MessageBox.Show("Only Numbers are accepted!", "Error Found!");
                }
                else
                {
                    if (checkForNumber(TbCartX.Text.ToString()) == true && checkForNumber(TbCartY.Text.ToString()) == true&&checkForNumber(TbCartZ.Text.ToString()))
                    {
                        newCordinatesPolars = calculations.cartToPolars(double.Parse(TbCartX.Text), double.Parse(TbCartY.Text), double.Parse(TbCartZ.Text));
                        LblPolarX.Text = newCordinatesPolars[0].ToString();
                        LblPolarY.Text = newCordinatesPolars[1].ToString() + "°";
                        LblPolarZ.Text = newCordinatesPolars[2].ToString();
                    }
                    else MessageBox.Show("Only Numbers are accepted!", "Error Found!");
                }
               
            }
        }
        
        public bool checkForNumber(string input)
        {
            foreach (char c in input)
                {
                if (c < '0' || c > '9')
                    if (c!='.')
                    {if (c!='-')
                        return false;
                    }
            
            }

            return true;
        }
       

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cb3DPolar_CheckedChanged(object sender, EventArgs e)
        {
            if (cb3DPolar.Checked == true)
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
