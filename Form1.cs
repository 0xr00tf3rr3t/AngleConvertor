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
    { Calculations calculations = new Calculations();
        double[] newCordinatesCart = new double[2];
        double[] newCordinatesPolars = new double[2];
        public Form1()
        {
            InitializeComponent();
        }

        private void RbPolares_CheckedChanged(object sender, EventArgs e) //Sets textbox on the other to false and to his true
        {
            if (RbPolares.Checked == true)
            {
                RbCartecianas.Checked = false;
                TbCartX.Visible = false;
                TbCartY.Visible = false;
                TbPolarX.Visible = true;
                TbPolarY.Visible = true;
                
                LblPolarX.Visible = false;
                LblPolarY.Visible = false;
                LblCartX.Visible = true;
                LblCartY.Visible = true;
            }
        }

        private void RbCartecianas_CheckedChanged(object sender, EventArgs e)
        {
            if (RbCartecianas.Checked == true)
            {
                RbPolares.Checked = false;
                TbPolarX.Visible = false;
                TbPolarY.Visible = false;
                TbCartX.Visible = true;
                TbCartY.Visible = true;
                LblPolarX.Visible = true;
                LblPolarY.Visible = true;
                LblCartX.Visible = false;
                LblCartY.Visible = false;

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
            {
                if (checkForNumber(TbCartX.Text.ToString()) == true && checkForNumber(TbCartY.Text.ToString()) == true)
                {
                    newCordinatesPolars= calculations.cartToPolars(double.Parse(TbCartX.Text), double.Parse(TbCartY.Text));
                    LblPolarX.Text = newCordinatesPolars[0].ToString();
                    LblPolarY.Text = newCordinatesPolars[1].ToString()+"°";

                }
                else MessageBox.Show("Only Numbers are accepted!", "Error Found!");
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
       
    }
}
