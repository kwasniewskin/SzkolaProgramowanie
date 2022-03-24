
namespace Quiz.Zakladki
{
    partial class UcListaPytan
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxListaPytan = new System.Windows.Forms.ComboBox();
            this.labelListaPytan = new System.Windows.Forms.Label();
            this.buttonUsunPytanie = new System.Windows.Forms.Button();
            this.buttonDodajPytanie = new System.Windows.Forms.Button();
            this.buttonEdytujPytanie = new System.Windows.Forms.Button();
            this.panelNaglowek = new System.Windows.Forms.Panel();
            this.ucWyswietlPytanie = new Quiz.Okna_pomocnicze.UcWyswietlPytanie();
            this.panelNaglowek.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxListaPytan
            // 
            this.comboBoxListaPytan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListaPytan.FormattingEnabled = true;
            this.comboBoxListaPytan.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxListaPytan.Location = new System.Drawing.Point(3, 18);
            this.comboBoxListaPytan.Name = "comboBoxListaPytan";
            this.comboBoxListaPytan.Size = new System.Drawing.Size(201, 23);
            this.comboBoxListaPytan.TabIndex = 0;
            this.comboBoxListaPytan.SelectedIndexChanged += new System.EventHandler(this.comboBoxListaPytan_SelectedIndexChanged);
            // 
            // labelListaPytan
            // 
            this.labelListaPytan.AutoSize = true;
            this.labelListaPytan.Location = new System.Drawing.Point(3, 0);
            this.labelListaPytan.Name = "labelListaPytan";
            this.labelListaPytan.Size = new System.Drawing.Size(67, 15);
            this.labelListaPytan.TabIndex = 1;
            this.labelListaPytan.Text = "Lista pytań:";
            // 
            // buttonUsunPytanie
            // 
            this.buttonUsunPytanie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUsunPytanie.Location = new System.Drawing.Point(329, 18);
            this.buttonUsunPytanie.Name = "buttonUsunPytanie";
            this.buttonUsunPytanie.Size = new System.Drawing.Size(89, 23);
            this.buttonUsunPytanie.TabIndex = 5;
            this.buttonUsunPytanie.Text = "Usuń pytanie";
            this.buttonUsunPytanie.UseVisualStyleBackColor = true;
            this.buttonUsunPytanie.Click += new System.EventHandler(this.buttonUsunPytanie_Click);
            // 
            // buttonDodajPytanie
            // 
            this.buttonDodajPytanie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodajPytanie.Location = new System.Drawing.Point(439, 18);
            this.buttonDodajPytanie.Name = "buttonDodajPytanie";
            this.buttonDodajPytanie.Size = new System.Drawing.Size(89, 23);
            this.buttonDodajPytanie.TabIndex = 8;
            this.buttonDodajPytanie.Text = "Dodaj pytanie";
            this.buttonDodajPytanie.UseVisualStyleBackColor = true;
            this.buttonDodajPytanie.Click += new System.EventHandler(this.buttonDodajPytanie_Click);
            // 
            // buttonEdytujPytanie
            // 
            this.buttonEdytujPytanie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdytujPytanie.Location = new System.Drawing.Point(549, 18);
            this.buttonEdytujPytanie.Name = "buttonEdytujPytanie";
            this.buttonEdytujPytanie.Size = new System.Drawing.Size(98, 23);
            this.buttonEdytujPytanie.TabIndex = 9;
            this.buttonEdytujPytanie.Text = "Edytuj pytanie";
            this.buttonEdytujPytanie.UseVisualStyleBackColor = true;
            this.buttonEdytujPytanie.Click += new System.EventHandler(this.buttonEdytujPytanie_Click);
            // 
            // panelNaglowek
            // 
            this.panelNaglowek.Controls.Add(this.labelListaPytan);
            this.panelNaglowek.Controls.Add(this.buttonEdytujPytanie);
            this.panelNaglowek.Controls.Add(this.comboBoxListaPytan);
            this.panelNaglowek.Controls.Add(this.buttonDodajPytanie);
            this.panelNaglowek.Controls.Add(this.buttonUsunPytanie);
            this.panelNaglowek.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNaglowek.Location = new System.Drawing.Point(0, 0);
            this.panelNaglowek.Name = "panelNaglowek";
            this.panelNaglowek.Size = new System.Drawing.Size(650, 56);
            this.panelNaglowek.TabIndex = 10;
            // 
            // ucWyswietlPytanie
            // 
            this.ucWyswietlPytanie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucWyswietlPytanie.Location = new System.Drawing.Point(0, 56);
            this.ucWyswietlPytanie.Name = "ucWyswietlPytanie";
            this.ucWyswietlPytanie.Size = new System.Drawing.Size(650, 422);
            this.ucWyswietlPytanie.TabIndex = 6;
            // 
            // UcListaPytan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucWyswietlPytanie);
            this.Controls.Add(this.panelNaglowek);
            this.Name = "UcListaPytan";
            this.Size = new System.Drawing.Size(650, 478);
            this.panelNaglowek.ResumeLayout(false);
            this.panelNaglowek.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxListaPytan;
        private System.Windows.Forms.Label labelListaPytan;
        private System.Windows.Forms.Button buttonUsunPytanie;
        private System.Windows.Forms.Button buttonDodajPytanie;
        private System.Windows.Forms.Button buttonEdytujPytanie;
        private System.Windows.Forms.Panel panelNaglowek;
        private Okna_pomocnicze.UcWyswietlPytanie ucWyswietlPytanie;
    }
}
