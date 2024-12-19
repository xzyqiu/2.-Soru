namespace WindowsFormsApplication13
{
    partial class Form1
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
            this.labelSonuc = new System.Windows.Forms.Label();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.checkBoxPantolon = new System.Windows.Forms.CheckBox();
            this.checkBoxGomlek = new System.Windows.Forms.CheckBox();
            this.checkBoxKazak = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Location = new System.Drawing.Point(12, 121);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(35, 13);
            this.labelSonuc.TabIndex = 9;
            this.labelSonuc.Text = "label1";
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Location = new System.Drawing.Point(12, 81);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(75, 23);
            this.buttonHesapla.TabIndex = 8;
            this.buttonHesapla.Text = "Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // checkBoxPantolon
            // 
            this.checkBoxPantolon.AutoSize = true;
            this.checkBoxPantolon.Location = new System.Drawing.Point(12, 58);
            this.checkBoxPantolon.Name = "checkBoxPantolon";
            this.checkBoxPantolon.Size = new System.Drawing.Size(105, 17);
            this.checkBoxPantolon.TabIndex = 7;
            this.checkBoxPantolon.Text = "Pantolon 900 TL";
            this.checkBoxPantolon.UseVisualStyleBackColor = true;
            // 
            // checkBoxGomlek
            // 
            this.checkBoxGomlek.AutoSize = true;
            this.checkBoxGomlek.Location = new System.Drawing.Point(12, 35);
            this.checkBoxGomlek.Name = "checkBoxGomlek";
            this.checkBoxGomlek.Size = new System.Drawing.Size(99, 17);
            this.checkBoxGomlek.TabIndex = 6;
            this.checkBoxGomlek.Text = "Gömlek 650 TL";
            this.checkBoxGomlek.UseVisualStyleBackColor = true;
            // 
            // checkBoxKazak
            // 
            this.checkBoxKazak.AutoSize = true;
            this.checkBoxKazak.Location = new System.Drawing.Point(12, 12);
            this.checkBoxKazak.Name = "checkBoxKazak";
            this.checkBoxKazak.Size = new System.Drawing.Size(93, 17);
            this.checkBoxKazak.TabIndex = 5;
            this.checkBoxKazak.Text = "Kazak 750 TL";
            this.checkBoxKazak.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.checkBoxPantolon);
            this.Controls.Add(this.checkBoxGomlek);
            this.Controls.Add(this.checkBoxKazak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSonuc;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.CheckBox checkBoxPantolon;
        private System.Windows.Forms.CheckBox checkBoxGomlek;
        private System.Windows.Forms.CheckBox checkBoxKazak;
    }
}

