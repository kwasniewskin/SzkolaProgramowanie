
namespace AplikacjaUczniowie
{
    partial class OknoGlowne
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxFiltry = new System.Windows.Forms.GroupBox();
            this.buttonSzukaj = new System.Windows.Forms.Button();
            this.numericUpDownRok = new System.Windows.Forms.NumericUpDown();
            this.labelRok = new System.Windows.Forms.Label();
            this.comboBoxKlasa = new System.Windows.Forms.ComboBox();
            this.labelKlasa = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.groupBoxOperacje = new System.Windows.Forms.GroupBox();
            this.buttonDodajKlase = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.groupBoxListaUczniow = new System.Windows.Forms.GroupBox();
            this.dataGridViewListaUczniow = new System.Windows.Forms.DataGridView();
            this.ColumnImie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKlasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRokUrodzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxFiltry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRok)).BeginInit();
            this.groupBoxOperacje.SuspendLayout();
            this.groupBoxListaUczniow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaUczniow)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiltry
            // 
            this.groupBoxFiltry.Controls.Add(this.buttonSzukaj);
            this.groupBoxFiltry.Controls.Add(this.numericUpDownRok);
            this.groupBoxFiltry.Controls.Add(this.labelRok);
            this.groupBoxFiltry.Controls.Add(this.comboBoxKlasa);
            this.groupBoxFiltry.Controls.Add(this.labelKlasa);
            this.groupBoxFiltry.Controls.Add(this.labelNazwisko);
            this.groupBoxFiltry.Controls.Add(this.labelImie);
            this.groupBoxFiltry.Controls.Add(this.textBoxNazwisko);
            this.groupBoxFiltry.Controls.Add(this.textBoxImie);
            this.groupBoxFiltry.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFiltry.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFiltry.Name = "groupBoxFiltry";
            this.groupBoxFiltry.Size = new System.Drawing.Size(800, 85);
            this.groupBoxFiltry.TabIndex = 0;
            this.groupBoxFiltry.TabStop = false;
            this.groupBoxFiltry.Text = "Filtry";
            // 
            // buttonSzukaj
            // 
            this.buttonSzukaj.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSzukaj.Location = new System.Drawing.Point(667, 19);
            this.buttonSzukaj.Name = "buttonSzukaj";
            this.buttonSzukaj.Size = new System.Drawing.Size(130, 63);
            this.buttonSzukaj.TabIndex = 8;
            this.buttonSzukaj.Text = "Szukaj";
            this.buttonSzukaj.UseVisualStyleBackColor = true;
            this.buttonSzukaj.Click += new System.EventHandler(this.buttonSzukaj_Click);
            // 
            // numericUpDownRok
            // 
            this.numericUpDownRok.Location = new System.Drawing.Point(417, 41);
            this.numericUpDownRok.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownRok.Name = "numericUpDownRok";
            this.numericUpDownRok.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownRok.TabIndex = 7;
            // 
            // labelRok
            // 
            this.labelRok.AutoSize = true;
            this.labelRok.Location = new System.Drawing.Point(417, 19);
            this.labelRok.Name = "labelRok";
            this.labelRok.Size = new System.Drawing.Size(30, 15);
            this.labelRok.TabIndex = 6;
            this.labelRok.Text = "Rok:";
            // 
            // comboBoxKlasa
            // 
            this.comboBoxKlasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKlasa.FormattingEnabled = true;
            this.comboBoxKlasa.Location = new System.Drawing.Point(282, 41);
            this.comboBoxKlasa.Name = "comboBoxKlasa";
            this.comboBoxKlasa.Size = new System.Drawing.Size(129, 23);
            this.comboBoxKlasa.TabIndex = 5;
            // 
            // labelKlasa
            // 
            this.labelKlasa.AutoSize = true;
            this.labelKlasa.Location = new System.Drawing.Point(282, 19);
            this.labelKlasa.Name = "labelKlasa";
            this.labelKlasa.Size = new System.Drawing.Size(37, 15);
            this.labelKlasa.TabIndex = 4;
            this.labelKlasa.Text = "Klasa:";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(143, 19);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(60, 15);
            this.labelNazwisko.TabIndex = 3;
            this.labelNazwisko.Text = "Nazwisko:";
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(12, 19);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(33, 15);
            this.labelImie.TabIndex = 2;
            this.labelImie.Text = "Imię:";
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(143, 41);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(133, 23);
            this.textBoxNazwisko.TabIndex = 1;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(12, 41);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(125, 23);
            this.textBoxImie.TabIndex = 0;
            // 
            // groupBoxOperacje
            // 
            this.groupBoxOperacje.Controls.Add(this.buttonDodajKlase);
            this.groupBoxOperacje.Controls.Add(this.buttonUsun);
            this.groupBoxOperacje.Controls.Add(this.buttonEdytuj);
            this.groupBoxOperacje.Controls.Add(this.buttonDodaj);
            this.groupBoxOperacje.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxOperacje.Location = new System.Drawing.Point(600, 85);
            this.groupBoxOperacje.Name = "groupBoxOperacje";
            this.groupBoxOperacje.Size = new System.Drawing.Size(200, 365);
            this.groupBoxOperacje.TabIndex = 1;
            this.groupBoxOperacje.TabStop = false;
            this.groupBoxOperacje.Text = "Operacje";
            // 
            // buttonDodajKlase
            // 
            this.buttonDodajKlase.Location = new System.Drawing.Point(3, 251);
            this.buttonDodajKlase.Name = "buttonDodajKlase";
            this.buttonDodajKlase.Size = new System.Drawing.Size(194, 61);
            this.buttonDodajKlase.TabIndex = 3;
            this.buttonDodajKlase.Text = "Dodaj klase";
            this.buttonDodajKlase.UseVisualStyleBackColor = true;
            this.buttonDodajKlase.Click += new System.EventHandler(this.buttonDodajKlase_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUsun.Location = new System.Drawing.Point(3, 141);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(194, 61);
            this.buttonUsun.TabIndex = 2;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEdytuj.Location = new System.Drawing.Point(3, 80);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(194, 61);
            this.buttonEdytuj.TabIndex = 1;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDodaj.Location = new System.Drawing.Point(3, 19);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(194, 61);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // groupBoxListaUczniow
            // 
            this.groupBoxListaUczniow.Controls.Add(this.dataGridViewListaUczniow);
            this.groupBoxListaUczniow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxListaUczniow.Location = new System.Drawing.Point(0, 85);
            this.groupBoxListaUczniow.Name = "groupBoxListaUczniow";
            this.groupBoxListaUczniow.Size = new System.Drawing.Size(600, 365);
            this.groupBoxListaUczniow.TabIndex = 2;
            this.groupBoxListaUczniow.TabStop = false;
            this.groupBoxListaUczniow.Text = "Lista uczniow";
            // 
            // dataGridViewListaUczniow
            // 
            this.dataGridViewListaUczniow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaUczniow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImie,
            this.ColumnNazwisko,
            this.ColumnKlasa,
            this.ColumnRokUrodzenia});
            this.dataGridViewListaUczniow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListaUczniow.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewListaUczniow.Name = "dataGridViewListaUczniow";
            this.dataGridViewListaUczniow.ReadOnly = true;
            this.dataGridViewListaUczniow.RowTemplate.Height = 25;
            this.dataGridViewListaUczniow.Size = new System.Drawing.Size(594, 343);
            this.dataGridViewListaUczniow.TabIndex = 0;
            // 
            // ColumnImie
            // 
            this.ColumnImie.DataPropertyName = "Imie";
            this.ColumnImie.HeaderText = "Imię";
            this.ColumnImie.Name = "ColumnImie";
            this.ColumnImie.ReadOnly = true;
            // 
            // ColumnNazwisko
            // 
            this.ColumnNazwisko.DataPropertyName = "Nazwisko";
            this.ColumnNazwisko.HeaderText = "Nazwisko";
            this.ColumnNazwisko.Name = "ColumnNazwisko";
            this.ColumnNazwisko.ReadOnly = true;
            // 
            // ColumnKlasa
            // 
            this.ColumnKlasa.DataPropertyName = "Klasa";
            this.ColumnKlasa.HeaderText = "Klasa";
            this.ColumnKlasa.Name = "ColumnKlasa";
            this.ColumnKlasa.ReadOnly = true;
            // 
            // ColumnRokUrodzenia
            // 
            this.ColumnRokUrodzenia.DataPropertyName = "RokUrodzenia";
            this.ColumnRokUrodzenia.HeaderText = "Rok Urodzenia";
            this.ColumnRokUrodzenia.Name = "ColumnRokUrodzenia";
            this.ColumnRokUrodzenia.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxListaUczniow);
            this.Controls.Add(this.groupBoxOperacje);
            this.Controls.Add(this.groupBoxFiltry);
            this.Name = "OknoGlowne";
            this.Text = "Uczniowie";
            this.groupBoxFiltry.ResumeLayout(false);
            this.groupBoxFiltry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRok)).EndInit();
            this.groupBoxOperacje.ResumeLayout(false);
            this.groupBoxListaUczniow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaUczniow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltry;
        private System.Windows.Forms.GroupBox groupBoxOperacje;
        private System.Windows.Forms.GroupBox groupBoxListaUczniow;
        private System.Windows.Forms.DataGridView dataGridViewListaUczniow;
        private System.Windows.Forms.Label labelKlasa;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Button buttonSzukaj;
        private System.Windows.Forms.NumericUpDown numericUpDownRok;
        private System.Windows.Forms.Label labelRok;
        private System.Windows.Forms.ComboBox comboBoxKlasa;
        private System.Windows.Forms.Button buttonDodajKlase;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKlasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRokUrodzenia;
    }
}

