
namespace AplikacjaUczniowie
{
    partial class OknoEdytuj
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
            this.labelZaktualizujDane = new System.Windows.Forms.Label();
            this.numericUpDownRok = new System.Windows.Forms.NumericUpDown();
            this.labelRok = new System.Windows.Forms.Label();
            this.comboBoxKlasa = new System.Windows.Forms.ComboBox();
            this.labelKlasa = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.buttonZaktualizuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRok)).BeginInit();
            this.SuspendLayout();
            // 
            // labelZaktualizujDane
            // 
            this.labelZaktualizujDane.AutoSize = true;
            this.labelZaktualizujDane.Location = new System.Drawing.Point(13, 13);
            this.labelZaktualizujDane.Name = "labelZaktualizujDane";
            this.labelZaktualizujDane.Size = new System.Drawing.Size(133, 15);
            this.labelZaktualizujDane.TabIndex = 0;
            this.labelZaktualizujDane.Text = "Zaktualizuj dane ucznia:";
            // 
            // numericUpDownRok
            // 
            this.numericUpDownRok.Location = new System.Drawing.Point(418, 62);
            this.numericUpDownRok.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownRok.Name = "numericUpDownRok";
            this.numericUpDownRok.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownRok.TabIndex = 15;
            // 
            // labelRok
            // 
            this.labelRok.AutoSize = true;
            this.labelRok.Location = new System.Drawing.Point(418, 40);
            this.labelRok.Name = "labelRok";
            this.labelRok.Size = new System.Drawing.Size(30, 15);
            this.labelRok.TabIndex = 14;
            this.labelRok.Text = "Rok:";
            // 
            // comboBoxKlasa
            // 
            this.comboBoxKlasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKlasa.FormattingEnabled = true;
            this.comboBoxKlasa.Location = new System.Drawing.Point(283, 62);
            this.comboBoxKlasa.Name = "comboBoxKlasa";
            this.comboBoxKlasa.Size = new System.Drawing.Size(129, 23);
            this.comboBoxKlasa.TabIndex = 13;
            // 
            // labelKlasa
            // 
            this.labelKlasa.AutoSize = true;
            this.labelKlasa.Location = new System.Drawing.Point(283, 40);
            this.labelKlasa.Name = "labelKlasa";
            this.labelKlasa.Size = new System.Drawing.Size(37, 15);
            this.labelKlasa.TabIndex = 12;
            this.labelKlasa.Text = "Klasa:";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(144, 40);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(60, 15);
            this.labelNazwisko.TabIndex = 11;
            this.labelNazwisko.Text = "Nazwisko:";
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(13, 40);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(33, 15);
            this.labelImie.TabIndex = 10;
            this.labelImie.Text = "Imię:";
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(144, 62);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(133, 23);
            this.textBoxNazwisko.TabIndex = 9;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(13, 62);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(125, 23);
            this.textBoxImie.TabIndex = 8;
            // 
            // buttonZaktualizuj
            // 
            this.buttonZaktualizuj.Location = new System.Drawing.Point(575, 40);
            this.buttonZaktualizuj.Name = "buttonZaktualizuj";
            this.buttonZaktualizuj.Size = new System.Drawing.Size(151, 45);
            this.buttonZaktualizuj.TabIndex = 16;
            this.buttonZaktualizuj.Text = "Zaktualizuj dane";
            this.buttonZaktualizuj.UseVisualStyleBackColor = true;
            this.buttonZaktualizuj.Click += new System.EventHandler(this.buttonZaktualizuj_Click);
            // 
            // OknoEdytuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 106);
            this.Controls.Add(this.buttonZaktualizuj);
            this.Controls.Add(this.numericUpDownRok);
            this.Controls.Add(this.labelRok);
            this.Controls.Add(this.comboBoxKlasa);
            this.Controls.Add(this.labelKlasa);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.labelZaktualizujDane);
            this.Name = "OknoEdytuj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edytuj dane ucznia";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZaktualizujDane;
        private System.Windows.Forms.NumericUpDown numericUpDownRok;
        private System.Windows.Forms.Label labelRok;
        private System.Windows.Forms.ComboBox comboBoxKlasa;
        private System.Windows.Forms.Label labelKlasa;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Button buttonZaktualizuj;
    }
}