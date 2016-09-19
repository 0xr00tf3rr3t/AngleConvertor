namespace Calculator
{
    partial class fmCalculation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCalculation));
            this.TbPolarX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbPolarY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GBCordPolares = new System.Windows.Forms.GroupBox();
            this.LblPolarZ = new System.Windows.Forms.Label();
            this.cb3DPolar = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbPolarZ = new System.Windows.Forms.TextBox();
            this.LblPolarY = new System.Windows.Forms.Label();
            this.LblPolarX = new System.Windows.Forms.Label();
            this.RbPolares = new System.Windows.Forms.RadioButton();
            this.GBCoodPolares = new System.Windows.Forms.GroupBox();
            this.LblCartZ = new System.Windows.Forms.Label();
            this.cb3DCart = new System.Windows.Forms.CheckBox();
            this.TbCartZ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblCartY = new System.Windows.Forms.Label();
            this.LblCartX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbCartX = new System.Windows.Forms.TextBox();
            this.TbCartY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RbCartecianas = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.GBCordPolares.SuspendLayout();
            this.GBCoodPolares.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbPolarX
            // 
            this.TbPolarX.Location = new System.Drawing.Point(31, 45);
            this.TbPolarX.Name = "TbPolarX";
            this.TbPolarX.Size = new System.Drawing.Size(47, 22);
            this.TbPolarX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "(";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = ",";
            // 
            // TbPolarY
            // 
            this.TbPolarY.Location = new System.Drawing.Point(108, 45);
            this.TbPolarY.Name = "TbPolarY";
            this.TbPolarY.Size = new System.Drawing.Size(47, 22);
            this.TbPolarY.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = ")";
            // 
            // GBCordPolares
            // 
            this.GBCordPolares.Controls.Add(this.LblPolarZ);
            this.GBCordPolares.Controls.Add(this.cb3DPolar);
            this.GBCordPolares.Controls.Add(this.label7);
            this.GBCordPolares.Controls.Add(this.label3);
            this.GBCordPolares.Controls.Add(this.TbPolarZ);
            this.GBCordPolares.Controls.Add(this.LblPolarY);
            this.GBCordPolares.Controls.Add(this.LblPolarX);
            this.GBCordPolares.Controls.Add(this.label1);
            this.GBCordPolares.Controls.Add(this.TbPolarX);
            this.GBCordPolares.Controls.Add(this.TbPolarY);
            this.GBCordPolares.Controls.Add(this.label2);
            this.GBCordPolares.Location = new System.Drawing.Point(51, 43);
            this.GBCordPolares.Name = "GBCordPolares";
            this.GBCordPolares.Size = new System.Drawing.Size(258, 94);
            this.GBCordPolares.TabIndex = 5;
            this.GBCordPolares.TabStop = false;
            this.GBCordPolares.Text = "Cordenadas Polares";
            // 
            // LblPolarZ
            // 
            this.LblPolarZ.AutoSize = true;
            this.LblPolarZ.Location = new System.Drawing.Point(180, 50);
            this.LblPolarZ.Name = "LblPolarZ";
            this.LblPolarZ.Size = new System.Drawing.Size(19, 17);
            this.LblPolarZ.TabIndex = 10;
            this.LblPolarZ.Text = "Φ";
            this.LblPolarZ.Visible = false;
            // 
            // cb3DPolar
            // 
            this.cb3DPolar.AutoSize = true;
            this.cb3DPolar.Checked = true;
            this.cb3DPolar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb3DPolar.Location = new System.Drawing.Point(197, 18);
            this.cb3DPolar.Name = "cb3DPolar";
            this.cb3DPolar.Size = new System.Drawing.Size(48, 21);
            this.cb3DPolar.TabIndex = 9;
            this.cb3DPolar.Text = "3D";
            this.cb3DPolar.UseVisualStyleBackColor = true;
            this.cb3DPolar.CheckedChanged += new System.EventHandler(this.cb3DPolar_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = ",";
            // 
            // TbPolarZ
            // 
            this.TbPolarZ.Location = new System.Drawing.Point(179, 45);
            this.TbPolarZ.Name = "TbPolarZ";
            this.TbPolarZ.Size = new System.Drawing.Size(47, 22);
            this.TbPolarZ.TabIndex = 7;
            // 
            // LblPolarY
            // 
            this.LblPolarY.AutoSize = true;
            this.LblPolarY.Location = new System.Drawing.Point(108, 50);
            this.LblPolarY.Name = "LblPolarY";
            this.LblPolarY.Size = new System.Drawing.Size(14, 17);
            this.LblPolarY.TabIndex = 6;
            this.LblPolarY.Text = "°";
            this.LblPolarY.Visible = false;
            // 
            // LblPolarX
            // 
            this.LblPolarX.AutoSize = true;
            this.LblPolarX.Location = new System.Drawing.Point(31, 50);
            this.LblPolarX.Name = "LblPolarX";
            this.LblPolarX.Size = new System.Drawing.Size(13, 17);
            this.LblPolarX.TabIndex = 5;
            this.LblPolarX.Text = "r";
            this.LblPolarX.Visible = false;
            // 
            // RbPolares
            // 
            this.RbPolares.AutoSize = true;
            this.RbPolares.Checked = true;
            this.RbPolares.Location = new System.Drawing.Point(28, 83);
            this.RbPolares.Name = "RbPolares";
            this.RbPolares.Size = new System.Drawing.Size(17, 16);
            this.RbPolares.TabIndex = 6;
            this.RbPolares.TabStop = true;
            this.RbPolares.UseCompatibleTextRendering = true;
            this.RbPolares.UseVisualStyleBackColor = true;
            this.RbPolares.CheckedChanged += new System.EventHandler(this.RbPolares_CheckedChanged);
            // 
            // GBCoodPolares
            // 
            this.GBCoodPolares.Controls.Add(this.LblCartZ);
            this.GBCoodPolares.Controls.Add(this.cb3DCart);
            this.GBCoodPolares.Controls.Add(this.TbCartZ);
            this.GBCoodPolares.Controls.Add(this.label8);
            this.GBCoodPolares.Controls.Add(this.LblCartY);
            this.GBCoodPolares.Controls.Add(this.LblCartX);
            this.GBCoodPolares.Controls.Add(this.label4);
            this.GBCoodPolares.Controls.Add(this.label5);
            this.GBCoodPolares.Controls.Add(this.TbCartX);
            this.GBCoodPolares.Controls.Add(this.TbCartY);
            this.GBCoodPolares.Controls.Add(this.label6);
            this.GBCoodPolares.Location = new System.Drawing.Point(51, 182);
            this.GBCoodPolares.Name = "GBCoodPolares";
            this.GBCoodPolares.Size = new System.Drawing.Size(258, 94);
            this.GBCoodPolares.TabIndex = 6;
            this.GBCoodPolares.TabStop = false;
            this.GBCoodPolares.Text = "Cordenadas Cartecianas ";
            // 
            // LblCartZ
            // 
            this.LblCartZ.AutoSize = true;
            this.LblCartZ.Location = new System.Drawing.Point(180, 50);
            this.LblCartZ.Name = "LblCartZ";
            this.LblCartZ.Size = new System.Drawing.Size(17, 17);
            this.LblCartZ.TabIndex = 12;
            this.LblCartZ.Text = "Z";
            // 
            // cb3DCart
            // 
            this.cb3DCart.AutoSize = true;
            this.cb3DCart.Checked = true;
            this.cb3DCart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb3DCart.Location = new System.Drawing.Point(197, 18);
            this.cb3DCart.Name = "cb3DCart";
            this.cb3DCart.Size = new System.Drawing.Size(48, 21);
            this.cb3DCart.TabIndex = 11;
            this.cb3DCart.Text = "3D";
            this.cb3DCart.UseVisualStyleBackColor = true;
            this.cb3DCart.CheckedChanged += new System.EventHandler(this.cb3DCart_CheckedChanged);
            // 
            // TbCartZ
            // 
            this.TbCartZ.Location = new System.Drawing.Point(179, 45);
            this.TbCartZ.Name = "TbCartZ";
            this.TbCartZ.Size = new System.Drawing.Size(47, 22);
            this.TbCartZ.TabIndex = 10;
            this.TbCartZ.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = ",";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // LblCartY
            // 
            this.LblCartY.AutoSize = true;
            this.LblCartY.Location = new System.Drawing.Point(108, 50);
            this.LblCartY.Name = "LblCartY";
            this.LblCartY.Size = new System.Drawing.Size(17, 17);
            this.LblCartY.TabIndex = 6;
            this.LblCartY.Text = "Y";
            // 
            // LblCartX
            // 
            this.LblCartX.AutoSize = true;
            this.LblCartX.Location = new System.Drawing.Point(31, 50);
            this.LblCartX.Name = "LblCartX";
            this.LblCartX.Size = new System.Drawing.Size(17, 17);
            this.LblCartX.TabIndex = 5;
            this.LblCartX.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "(";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = ")";
            // 
            // TbCartX
            // 
            this.TbCartX.Location = new System.Drawing.Point(31, 45);
            this.TbCartX.Name = "TbCartX";
            this.TbCartX.Size = new System.Drawing.Size(47, 22);
            this.TbCartX.TabIndex = 0;
            this.TbCartX.Visible = false;
            // 
            // TbCartY
            // 
            this.TbCartY.Location = new System.Drawing.Point(108, 45);
            this.TbCartY.Name = "TbCartY";
            this.TbCartY.Size = new System.Drawing.Size(47, 22);
            this.TbCartY.TabIndex = 3;
            this.TbCartY.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = ",";
            // 
            // RbCartecianas
            // 
            this.RbCartecianas.AutoSize = true;
            this.RbCartecianas.Location = new System.Drawing.Point(28, 227);
            this.RbCartecianas.Name = "RbCartecianas";
            this.RbCartecianas.Size = new System.Drawing.Size(17, 16);
            this.RbCartecianas.TabIndex = 7;
            this.RbCartecianas.UseVisualStyleBackColor = true;
            this.RbCartecianas.CheckedChanged += new System.EventHandler(this.RbCartecianas_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.Location = new System.Drawing.Point(105, 305);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 40);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // fmCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(355, 425);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.RbCartecianas);
            this.Controls.Add(this.GBCoodPolares);
            this.Controls.Add(this.RbPolares);
            this.Controls.Add(this.GBCordPolares);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCalculation";
            this.Text = "Convertidora de Cordenadas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBCordPolares.ResumeLayout(false);
            this.GBCordPolares.PerformLayout();
            this.GBCoodPolares.ResumeLayout(false);
            this.GBCoodPolares.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbPolarX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbPolarY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GBCordPolares;
        private System.Windows.Forms.RadioButton RbPolares;
        private System.Windows.Forms.GroupBox GBCoodPolares;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbCartX;
        private System.Windows.Forms.TextBox TbCartY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RbCartecianas;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label LblPolarY;
        private System.Windows.Forms.Label LblPolarX;
        private System.Windows.Forms.Label LblCartY;
        private System.Windows.Forms.Label LblCartX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbPolarZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb3DPolar;
        private System.Windows.Forms.TextBox TbCartZ;
        private System.Windows.Forms.Label LblCartZ;
        private System.Windows.Forms.CheckBox cb3DCart;
        private System.Windows.Forms.Label LblPolarZ;
    }
}

