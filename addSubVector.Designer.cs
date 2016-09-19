namespace Calculator
{
    public partial class addSubVector
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
          
            this.txtAx = new System.Windows.Forms.TextBox();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.txtAz = new System.Windows.Forms.TextBox();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.txtBy = new System.Windows.Forms.TextBox();
            this.txtBz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRX = new System.Windows.Forms.Label();
            this.lblRY = new System.Windows.Forms.Label();
            this.lblRZ = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMagRes = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblThetaRes = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAlphaRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAx
            // 
            this.txtAx.Location = new System.Drawing.Point(64, 27);
            this.txtAx.Name = "txtAx";
            this.txtAx.Size = new System.Drawing.Size(46, 20);
            this.txtAx.TabIndex = 0;
            // 
            // txtAy
            // 
            this.txtAy.Location = new System.Drawing.Point(133, 28);
            this.txtAy.Name = "txtAy";
            this.txtAy.Size = new System.Drawing.Size(46, 20);
            this.txtAy.TabIndex = 1;
            // 
            // txtAz
            // 
            this.txtAz.Location = new System.Drawing.Point(203, 28);
            this.txtAz.Name = "txtAz";
            this.txtAz.Size = new System.Drawing.Size(46, 20);
            this.txtAz.TabIndex = 2;
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(64, 67);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(46, 20);
            this.txtBx.TabIndex = 3;
            // 
            // txtBy
            // 
            this.txtBy.Location = new System.Drawing.Point(133, 67);
            this.txtBy.Name = "txtBy";
            this.txtBy.Size = new System.Drawing.Size(46, 20);
            this.txtBy.TabIndex = 4;
            // 
            // txtBz
            // 
            this.txtBz.Location = new System.Drawing.Point(203, 67);
            this.txtBz.Name = "txtBz";
            this.txtBz.Size = new System.Drawing.Size(46, 20);
            this.txtBz.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "A =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "B =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "R =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(182, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "+";
            // 
            // lblRX
            // 
            this.lblRX.AutoSize = true;
            this.lblRX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRX.Location = new System.Drawing.Point(61, 112);
            this.lblRX.Name = "lblRX";
            this.lblRX.Size = new System.Drawing.Size(24, 16);
            this.lblRX.TabIndex = 13;
            this.lblRX.Text = "Rx";
            // 
            // lblRY
            // 
            this.lblRY.AutoSize = true;
            this.lblRY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRY.Location = new System.Drawing.Point(130, 112);
            this.lblRY.Name = "lblRY";
            this.lblRY.Size = new System.Drawing.Size(25, 16);
            this.lblRY.TabIndex = 14;
            this.lblRY.Text = "Ry";
            // 
            // lblRZ
            // 
            this.lblRZ.AutoSize = true;
            this.lblRZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRZ.Location = new System.Drawing.Point(200, 112);
            this.lblRZ.Name = "lblRZ";
            this.lblRZ.Size = new System.Drawing.Size(24, 16);
            this.lblRZ.TabIndex = 15;
            this.lblRZ.Text = "Rz";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(64, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(174, 141);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 23);
            this.btnSubtract.TabIndex = 17;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "r =";
            // 
            // lblMagRes
            // 
            this.lblMagRes.AutoSize = true;
            this.lblMagRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagRes.Location = new System.Drawing.Point(50, 177);
            this.lblMagRes.Name = "lblMagRes";
            this.lblMagRes.Size = new System.Drawing.Size(46, 16);
            this.lblMagRes.TabIndex = 19;
            this.lblMagRes.Text = "Result";
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.Location = new System.Drawing.Point(22, 208);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(28, 16);
            this.lblDirection.TabIndex = 20;
            this.lblDirection.Text = "Θ =";
            // 
            // lblThetaRes
            // 
            this.lblThetaRes.AutoSize = true;
            this.lblThetaRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThetaRes.Location = new System.Drawing.Point(50, 208);
            this.lblThetaRes.Name = "lblThetaRes";
            this.lblThetaRes.Size = new System.Drawing.Size(46, 16);
            this.lblThetaRes.TabIndex = 21;
            this.lblThetaRes.Text = "Result";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "α =";
            // 
            // lblAlphaRes
            // 
            this.lblAlphaRes.AutoSize = true;
            this.lblAlphaRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlphaRes.Location = new System.Drawing.Point(50, 235);
            this.lblAlphaRes.Name = "lblAlphaRes";
            this.lblAlphaRes.Size = new System.Drawing.Size(46, 16);
            this.lblAlphaRes.TabIndex = 23;
            this.lblAlphaRes.Text = "Result";
            // 
            // addSubVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 277);
            this.Controls.Add(this.lblAlphaRes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblThetaRes);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.lblMagRes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblRZ);
            this.Controls.Add(this.lblRY);
            this.Controls.Add(this.lblRX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBz);
            this.Controls.Add(this.txtBy);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.txtAz);
            this.Controls.Add(this.txtAy);
            this.Controls.Add(this.txtAx);
            this.BackColor = System.Drawing.SystemColors.HotTrack;
      
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addSubVector";
            this.ResumeLayout(false);
        
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addSubVector";
            this.Text = "Addition/Subtraction";
            this.Load += new System.EventHandler(this.addSubVector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAx;
        private System.Windows.Forms.TextBox txtAy;
        private System.Windows.Forms.TextBox txtAz;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.TextBox txtBy;
        private System.Windows.Forms.TextBox txtBz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRX;
        private System.Windows.Forms.Label lblRY;
        private System.Windows.Forms.Label lblRZ;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMagRes;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblThetaRes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAlphaRes;
    }
}