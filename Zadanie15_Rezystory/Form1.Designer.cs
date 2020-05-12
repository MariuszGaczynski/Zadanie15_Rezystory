namespace Zadanie15_Rezystory
{
    partial class MainForm
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
            this.comboFirstBand = new System.Windows.Forms.ComboBox();
            this.pnlFirstBand = new System.Windows.Forms.Panel();
            this.pnlSecondBand = new System.Windows.Forms.Panel();
            this.pnlThirdBand = new System.Windows.Forms.Panel();
            this.pnlFourthBand = new System.Windows.Forms.Panel();
            this.lblResistanceValue = new System.Windows.Forms.Label();
            this.comboSecondBand = new System.Windows.Forms.ComboBox();
            this.comboThirdBand = new System.Windows.Forms.ComboBox();
            this.comboFourthBand = new System.Windows.Forms.ComboBox();
            this.lblFirstBand = new System.Windows.Forms.Label();
            this.lblSecondBand = new System.Windows.Forms.Label();
            this.lblThirdBand = new System.Windows.Forms.Label();
            this.lblFourthBand = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboFirstBand
            // 
            this.comboFirstBand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboFirstBand.FormattingEnabled = true;
            this.comboFirstBand.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.comboFirstBand.Location = new System.Drawing.Point(12, 15);
            this.comboFirstBand.Name = "comboFirstBand";
            this.comboFirstBand.Size = new System.Drawing.Size(146, 28);
            this.comboFirstBand.TabIndex = 0;
            this.comboFirstBand.SelectedIndexChanged += new System.EventHandler(this.comboFirstBand_SelectedIndexChanged);
            // 
            // pnlFirstBand
            // 
            this.pnlFirstBand.BackColor = System.Drawing.Color.White;
            this.pnlFirstBand.Location = new System.Drawing.Point(12, 265);
            this.pnlFirstBand.Name = "pnlFirstBand";
            this.pnlFirstBand.Size = new System.Drawing.Size(40, 229);
            this.pnlFirstBand.TabIndex = 1;
            // 
            // pnlSecondBand
            // 
            this.pnlSecondBand.BackColor = System.Drawing.Color.White;
            this.pnlSecondBand.Location = new System.Drawing.Point(74, 265);
            this.pnlSecondBand.Name = "pnlSecondBand";
            this.pnlSecondBand.Size = new System.Drawing.Size(40, 229);
            this.pnlSecondBand.TabIndex = 2;
            // 
            // pnlThirdBand
            // 
            this.pnlThirdBand.BackColor = System.Drawing.Color.White;
            this.pnlThirdBand.Location = new System.Drawing.Point(171, 265);
            this.pnlThirdBand.Name = "pnlThirdBand";
            this.pnlThirdBand.Size = new System.Drawing.Size(40, 229);
            this.pnlThirdBand.TabIndex = 3;
            // 
            // pnlFourthBand
            // 
            this.pnlFourthBand.BackColor = System.Drawing.Color.White;
            this.pnlFourthBand.Location = new System.Drawing.Point(298, 265);
            this.pnlFourthBand.Name = "pnlFourthBand";
            this.pnlFourthBand.Size = new System.Drawing.Size(40, 229);
            this.pnlFourthBand.TabIndex = 4;
            // 
            // lblResistanceValue
            // 
            this.lblResistanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResistanceValue.Location = new System.Drawing.Point(12, 199);
            this.lblResistanceValue.Name = "lblResistanceValue";
            this.lblResistanceValue.Size = new System.Drawing.Size(326, 51);
            this.lblResistanceValue.TabIndex = 5;
            this.lblResistanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboSecondBand
            // 
            this.comboSecondBand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboSecondBand.FormattingEnabled = true;
            this.comboSecondBand.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.comboSecondBand.Location = new System.Drawing.Point(12, 49);
            this.comboSecondBand.Name = "comboSecondBand";
            this.comboSecondBand.Size = new System.Drawing.Size(146, 28);
            this.comboSecondBand.TabIndex = 6;
            this.comboSecondBand.SelectedIndexChanged += new System.EventHandler(this.comboSecondBand_SelectedIndexChanged);
            // 
            // comboThirdBand
            // 
            this.comboThirdBand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboThirdBand.FormattingEnabled = true;
            this.comboThirdBand.Items.AddRange(new object[] {
            "Pink",
            "Silver",
            "Gold",
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.comboThirdBand.Location = new System.Drawing.Point(12, 83);
            this.comboThirdBand.Name = "comboThirdBand";
            this.comboThirdBand.Size = new System.Drawing.Size(146, 28);
            this.comboThirdBand.TabIndex = 7;
            this.comboThirdBand.SelectedIndexChanged += new System.EventHandler(this.comboThirdBand_SelectedIndexChanged);
            // 
            // comboFourthBand
            // 
            this.comboFourthBand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboFourthBand.FormattingEnabled = true;
            this.comboFourthBand.Items.AddRange(new object[] {
            "None",
            "Silver",
            "Gold",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray"});
            this.comboFourthBand.Location = new System.Drawing.Point(12, 117);
            this.comboFourthBand.Name = "comboFourthBand";
            this.comboFourthBand.Size = new System.Drawing.Size(146, 28);
            this.comboFourthBand.TabIndex = 8;
            this.comboFourthBand.SelectedIndexChanged += new System.EventHandler(this.comboFourthBand_SelectedIndexChanged);
            // 
            // lblFirstBand
            // 
            this.lblFirstBand.AutoSize = true;
            this.lblFirstBand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstBand.Location = new System.Drawing.Point(180, 23);
            this.lblFirstBand.Name = "lblFirstBand";
            this.lblFirstBand.Size = new System.Drawing.Size(123, 20);
            this.lblFirstBand.TabIndex = 9;
            this.lblFirstBand.Text = "First Band Color";
            // 
            // lblSecondBand
            // 
            this.lblSecondBand.AutoSize = true;
            this.lblSecondBand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSecondBand.Location = new System.Drawing.Point(180, 57);
            this.lblSecondBand.Name = "lblSecondBand";
            this.lblSecondBand.Size = new System.Drawing.Size(147, 20);
            this.lblSecondBand.TabIndex = 10;
            this.lblSecondBand.Text = "Second Band Color";
            // 
            // lblThirdBand
            // 
            this.lblThirdBand.AutoSize = true;
            this.lblThirdBand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblThirdBand.Location = new System.Drawing.Point(180, 91);
            this.lblThirdBand.Name = "lblThirdBand";
            this.lblThirdBand.Size = new System.Drawing.Size(127, 20);
            this.lblThirdBand.TabIndex = 11;
            this.lblThirdBand.Text = "Third Band Color";
            // 
            // lblFourthBand
            // 
            this.lblFourthBand.AutoSize = true;
            this.lblFourthBand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFourthBand.Location = new System.Drawing.Point(180, 125);
            this.lblFourthBand.Name = "lblFourthBand";
            this.lblFourthBand.Size = new System.Drawing.Size(139, 20);
            this.lblFourthBand.TabIndex = 12;
            this.lblFourthBand.Text = "Fourth Band Color";
            // 
            // btnProceed
            // 
            this.btnProceed.Enabled = false;
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProceed.Location = new System.Drawing.Point(12, 160);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(326, 36);
            this.btnProceed.TabIndex = 14;
            this.btnProceed.Text = "Value of electrical resistivity of given resistor is:";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(12, 506);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(326, 23);
            this.btnRestart.TabIndex = 16;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(351, 539);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.lblFourthBand);
            this.Controls.Add(this.lblThirdBand);
            this.Controls.Add(this.lblSecondBand);
            this.Controls.Add(this.lblFirstBand);
            this.Controls.Add(this.comboFourthBand);
            this.Controls.Add(this.comboThirdBand);
            this.Controls.Add(this.comboSecondBand);
            this.Controls.Add(this.lblResistanceValue);
            this.Controls.Add(this.pnlFourthBand);
            this.Controls.Add(this.pnlThirdBand);
            this.Controls.Add(this.pnlSecondBand);
            this.Controls.Add(this.pnlFirstBand);
            this.Controls.Add(this.comboFirstBand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resistivity Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFirstBand;
        private System.Windows.Forms.Panel pnlFirstBand;
        private System.Windows.Forms.Panel pnlSecondBand;
        private System.Windows.Forms.Panel pnlThirdBand;
        private System.Windows.Forms.Panel pnlFourthBand;
        private System.Windows.Forms.Label lblResistanceValue;
        private System.Windows.Forms.ComboBox comboSecondBand;
        private System.Windows.Forms.ComboBox comboThirdBand;
        private System.Windows.Forms.ComboBox comboFourthBand;
        private System.Windows.Forms.Label lblFirstBand;
        private System.Windows.Forms.Label lblSecondBand;
        private System.Windows.Forms.Label lblThirdBand;
        private System.Windows.Forms.Label lblFourthBand;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnRestart;
    }
}

