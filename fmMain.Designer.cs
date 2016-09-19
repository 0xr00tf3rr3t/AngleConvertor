namespace Calculator
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.btnConvertion = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvertion
            // 
            this.btnConvertion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConvertion.Location = new System.Drawing.Point(46, 223);
            this.btnConvertion.Name = "btnConvertion";
            this.btnConvertion.Size = new System.Drawing.Size(172, 54);
            this.btnConvertion.TabIndex = 0;
            this.btnConvertion.Text = "Cambiar cordenadas";
            this.btnConvertion.UseVisualStyleBackColor = false;
            this.btnConvertion.Click += new System.EventHandler(this.btnConvertion_Click);
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSum.Location = new System.Drawing.Point(358, 223);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(197, 54);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "Suma o Resta de Vectores";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Calculator.Properties.Resources.physics;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 289);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnConvertion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmMain";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConvertion;
        private System.Windows.Forms.Button btnSum;
    }
}