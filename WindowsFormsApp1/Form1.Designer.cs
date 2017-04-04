namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.cislo1 = new System.Windows.Forms.NumericUpDown();
            this.cislo2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.vysledekLabel = new System.Windows.Forms.Label();
            this.operaceComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cislo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cislo2)).BeginInit();
            this.SuspendLayout();
            // 
            // cislo1
            // 
            this.cislo1.DecimalPlaces = 2;
            this.cislo1.Location = new System.Drawing.Point(26, 80);
            this.cislo1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cislo1.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.cislo1.Name = "cislo1";
            this.cislo1.Size = new System.Drawing.Size(48, 20);
            this.cislo1.TabIndex = 0;
            // 
            // cislo2
            // 
            this.cislo2.DecimalPlaces = 2;
            this.cislo2.Location = new System.Drawing.Point(118, 81);
            this.cislo2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cislo2.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.cislo2.Name = "cislo2";
            this.cislo2.Size = new System.Drawing.Size(54, 20);
            this.cislo2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(178, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // vysledekLabel
            // 
            this.vysledekLabel.AutoSize = true;
            this.vysledekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.vysledekLabel.Location = new System.Drawing.Point(200, 81);
            this.vysledekLabel.Name = "vysledekLabel";
            this.vysledekLabel.Size = new System.Drawing.Size(16, 17);
            this.vysledekLabel.TabIndex = 3;
            this.vysledekLabel.Text = "0";
            // 
            // operaceComboBox
            // 
            this.operaceComboBox.FormattingEnabled = true;
            this.operaceComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operaceComboBox.Location = new System.Drawing.Point(80, 80);
            this.operaceComboBox.Name = "operaceComboBox";
            this.operaceComboBox.Size = new System.Drawing.Size(32, 21);
            this.operaceComboBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Vypočítej";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operaceComboBox);
            this.Controls.Add(this.vysledekLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cislo2);
            this.Controls.Add(this.cislo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cislo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cislo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown cislo1;
        private System.Windows.Forms.NumericUpDown cislo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vysledekLabel;
        private System.Windows.Forms.ComboBox operaceComboBox;
        private System.Windows.Forms.Button button1;
    }
}

