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
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void btnConvertion_Click(object sender, EventArgs e)
        {
           FmCalculation calc = new FmCalculation();
            calc.Show();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addSubVector addvector = new addSubVector();
            addvector.Show();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
