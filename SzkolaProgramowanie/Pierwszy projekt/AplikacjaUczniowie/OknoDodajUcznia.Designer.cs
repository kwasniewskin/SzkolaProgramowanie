
namespace AplikacjaUczniowie
{
    partial class OknoDodajUcznia
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
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelKlasa = new System.Windows.Forms.Label();
            this.labelRokUrodzenia = new System.Windows.Forms.Label();
            this.numericUpDownRokUrodzenia = new System.Windows.Forms.NumericUpDown();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.comboBoxKlasa = new System.Windows.Forms.ComboBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRokUrodzenia)).BeginInit();
            this.SuspendLayout();
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(12, 9);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(33, 15);
            this.labelImie.TabIndex = 0;
            this.labelImie.Text = "Imię:";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(132, 9);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(60, 15);
            this.labelNazwisko.TabIndex = 1;
            this.labelNazwisko.Text = "Nazwisko:";
            // 
            // labelKlasa
            // 
            this.labelKlasa.AutoSize = true;
            this.labelKlasa.Location = new System.Drawing.Point(253, 9);
            this.labelKlasa.Name = "labelKlasa";
            this.labelKlasa.Size = new System.Drawing.Size(37, 15);
            this.labelKlasa.TabIndex = 2;
            this.labelKlasa.Text = "Klasa:";
            // 
            // labelRokUrodzenia
            // 
            this.labelRokUrodzenia.AutoSize = true;
            this.labelRokUrodzenia.Location = new System.Drawing.Point(393, 9);
            this.labelRokUrodzenia.Name = "labelRokUrodzenia";
            this.labelRokUrodzenia.Size = new System.Drawing.Size(82, 15);
            this.labelRokUrodzenia.TabIndex = 3;
            this.labelRokUrodzenia.Text = "Rok urodzenia";
            // 
            // numericUpDownRokUrodzenia
            // 
            this.numericUpDownRokUrodzenia.Location = new System.Drawing.Point(393, 28);
            this.numericUpDownRokUrodzenia.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRokUrodzenia.Name = "numericUpDownRokUrodzenia";
            this.numericUpDownRokUrodzenia.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownRokUrodzenia.TabIndex = 4;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(12, 27);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 23);
            this.textBoxImie.TabIndex = 5;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(132, 27);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 23);
            this.textBoxNazwisko.TabIndex = 6;
            // 
            // comboBoxKlasa
            // 
            this.comboBoxKlasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKlasa.FormattingEnabled = true;
            this.comboBoxKlasa.Location = new System.Drawing.Point(253, 27);
            this.comboBoxKlasa.Name = "comboBoxKlasa";
            this.comboBoxKlasa.Size = new System.Drawing.Size(121, 23);
            this.comboBoxKlasa.TabIndex = 7;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDodaj.Location = new System.Drawing.Point(87, 75);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 8;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnuluj.Location = new System.Drawing.Point(347, 75);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuluj.TabIndex = 9;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // OknoDodajUcznia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 116);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.comboBoxKlasa);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.numericUpDownRokUrodzenia);
            this.Controls.Add(this.labelRokUrodzenia);
            this.Controls.Add(this.labelKlasa);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.Name = "OknoDodajUcznia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Szczegóły ucznia";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRokUrodzenia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelKlasa;
        private System.Windows.Forms.Label labelRokUrodzenia;
        private System.Windows.Forms.NumericUpDown numericUpDownRokUrodzenia;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.ComboBox comboBoxKlasa;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonAnuluj;
    }
}