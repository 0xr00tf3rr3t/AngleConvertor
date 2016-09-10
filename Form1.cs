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
    {
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
    }
}
