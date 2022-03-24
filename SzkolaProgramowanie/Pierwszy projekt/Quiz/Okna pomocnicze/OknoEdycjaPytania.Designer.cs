
namespace Quiz.Okna_pomocnicze
{
    partial class OknoEdycjaPytania
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
            this.ucWyswietlPytanie = new Quiz.Okna_pomocnicze.UcWyswietlPytanie();
            this.panelPrzyciski = new System.Windows.Forms.Panel();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonDodajOdpowiedz = new System.Windows.Forms.Button();
            this.buttonUsunOdpowiedzi = new System.Windows.Forms.Button();
            this.panelPrzyciski.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucWyswietlPytanie
            // 
            this.ucWyswietlPytanie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucWyswietlPytanie.Location = new System.Drawing.Point(0, 0);
            this.ucWyswietlPytanie.Name = "ucWyswietlPytanie";
            this.ucWyswietlPytanie.Size = new System.Drawing.Size(800, 450);
            this.ucWyswietlPytanie.TabIndex = 0;
            // 
            // panelPrzyciski
            // 
            this.panelPrzyciski.Controls.Add(this.buttonUsunOdpowiedzi);
            this.panelPrzyciski.Controls.Add(this.buttonDodajOdpowiedz);
            this.panelPrzyciski.Controls.Add(this.buttonAnuluj);
            this.panelPrzyciski.Controls.Add(this.buttonZapisz);
            this.panelPrzyciski.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPrzyciski.Location = new System.Drawing.Point(0, 368);
            this.panelPrzyciski.Name = "panelPrzyciski";
            this.panelPrzyciski.Size = new System.Drawing.Size(800, 82);
            this.panelPrzyciski.TabIndex = 1;
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(12, 28);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(75, 23);
            this.buttonZapisz.TabIndex = 0;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(102, 28);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuluj.TabIndex = 1;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // buttonDodajOdpowiedz
            // 
            this.buttonDodajOdpowiedz.Location = new System.Drawing.Point(532, 10);
            this.buttonDodajOdpowiedz.Name = "buttonDodajOdpowiedz";
            this.buttonDodajOdpowiedz.Size = new System.Drawing.Size(75, 60);
            this.buttonDodajOdpowiedz.TabIndex = 2;
            this.buttonDodajOdpowiedz.Text = "Dodaj odpowiedź";
            this.buttonDodajOdpowiedz.UseVisualStyleBackColor = true;
            this.buttonDodajOdpowiedz.Click += new System.EventHandler(this.buttonDodajOdpowiedz_Click);
            // 
            // buttonUsunOdpowiedzi
            // 
            this.buttonUsunOdpowiedzi.Location = new System.Drawing.Point(626, 10);
            this.buttonUsunOdpowiedzi.Name = "buttonUsunOdpowiedzi";
            this.buttonUsunOdpowiedzi.Size = new System.Drawing.Size(79, 60);
            this.buttonUsunOdpowiedzi.TabIndex = 3;
            this.buttonUsunOdpowiedzi.Text = "Usuń odpowiedzi";
            this.buttonUsunOdpowiedzi.UseVisualStyleBackColor = true;
            this.buttonUsunOdpowiedzi.Click += new System.EventHandler(this.buttonUsunOdpowiedzi_Click);
            // 
            // OknoEdycjaPytania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPrzyciski);
            this.Controls.Add(this.ucWyswietlPytanie);
            this.Name = "OknoEdycjaPytania";
            this.Text = "OknoEdycjaPytania";
            this.panelPrzyciski.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UcWyswietlPytanie ucWyswietlPytanie;
        private System.Windows.Forms.Panel panelPrzyciski;
        private System.Windows.Forms.Button buttonUsunOdpowiedzi;
        private System.Windows.Forms.Button buttonDodajOdpowiedz;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Button buttonZapisz;
    }
}