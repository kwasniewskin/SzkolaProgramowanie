
namespace Notatnik
{
    partial class OknoNotatnik
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripMenuGlowne = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.otworzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopjujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.znajdxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.znajdźNastępnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataIGodzinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zawijanieWierszyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powiększenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powiększToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomniejszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelPowiekszenie = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxNotatnik = new System.Windows.Forms.TextBox();
            this.contextMenuStripNotanik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wytnijToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabelZegar = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerZegar = new System.Windows.Forms.Timer(this.components);
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.menuStripMenuGlowne.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripNotanik.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMenuGlowne
            // 
            this.menuStripMenuGlowne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStripMenuGlowne.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenuGlowne.Name = "menuStripMenuGlowne";
            this.menuStripMenuGlowne.Size = new System.Drawing.Size(800, 24);
            this.menuStripMenuGlowne.TabIndex = 0;
            this.menuStripMenuGlowne.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.toolStripMenuItem1,
            this.otworzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // otworzToolStripMenuItem
            // 
            this.otworzToolStripMenuItem.Name = "otworzToolStripMenuItem";
            this.otworzToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.otworzToolStripMenuItem.Text = "Otwórz";
            this.otworzToolStripMenuItem.Click += new System.EventHandler(this.otworzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cofnijToolStripMenuItem,
            this.toolStripMenuItem3,
            this.wytnijToolStripMenuItem,
            this.kopjujToolStripMenuItem,
            this.wklejToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.toolStripMenuItem4,
            this.znajdxToolStripMenuItem,
            this.znajdźNastępnyToolStripMenuItem,
            this.toolStripMenuItem5,
            this.zaznaczWszystkoToolStripMenuItem,
            this.dataIGodzinaToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "&Edycja";
            // 
            // cofnijToolStripMenuItem
            // 
            this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cofnijToolStripMenuItem.Text = "Cofnij";
            this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(163, 6);
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.wytnijToolStripMenuItem.Text = "Wytnij";
            this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
            // 
            // kopjujToolStripMenuItem
            // 
            this.kopjujToolStripMenuItem.Name = "kopjujToolStripMenuItem";
            this.kopjujToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.kopjujToolStripMenuItem.Text = "Kopiuj";
            this.kopjujToolStripMenuItem.Click += new System.EventHandler(this.kopjujToolStripMenuItem_Click);
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.wklejToolStripMenuItem.Text = "Wklej";
            this.wklejToolStripMenuItem.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(163, 6);
            // 
            // znajdxToolStripMenuItem
            // 
            this.znajdxToolStripMenuItem.Name = "znajdxToolStripMenuItem";
            this.znajdxToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.znajdxToolStripMenuItem.Text = "Znajdź";
            this.znajdxToolStripMenuItem.Click += new System.EventHandler(this.znajdxToolStripMenuItem_Click);
            // 
            // znajdźNastępnyToolStripMenuItem
            // 
            this.znajdźNastępnyToolStripMenuItem.Name = "znajdźNastępnyToolStripMenuItem";
            this.znajdźNastępnyToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.znajdźNastępnyToolStripMenuItem.Text = "Znajdź następny";
            this.znajdźNastępnyToolStripMenuItem.Click += new System.EventHandler(this.znajdźNastępnyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(163, 6);
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_Click);
            // 
            // dataIGodzinaToolStripMenuItem
            // 
            this.dataIGodzinaToolStripMenuItem.Name = "dataIGodzinaToolStripMenuItem";
            this.dataIGodzinaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.dataIGodzinaToolStripMenuItem.Text = "Data i godzina";
            this.dataIGodzinaToolStripMenuItem.Click += new System.EventHandler(this.dataIGodzinaToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zawijanieWierszyToolStripMenuItem,
            this.czcionkaToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "For&mat";
            // 
            // zawijanieWierszyToolStripMenuItem
            // 
            this.zawijanieWierszyToolStripMenuItem.Name = "zawijanieWierszyToolStripMenuItem";
            this.zawijanieWierszyToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zawijanieWierszyToolStripMenuItem.Text = "Zawijanie wierszy";
            this.zawijanieWierszyToolStripMenuItem.Click += new System.EventHandler(this.zawijanieWierszyToolStripMenuItem_Click);
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.czcionkaToolStripMenuItem.Text = "Czcionka";
            this.czcionkaToolStripMenuItem.Click += new System.EventHandler(this.czcionkaToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powiększenieToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "&Widok";
            // 
            // powiększenieToolStripMenuItem
            // 
            this.powiększenieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powiększToolStripMenuItem,
            this.pomniejszToolStripMenuItem});
            this.powiększenieToolStripMenuItem.Name = "powiększenieToolStripMenuItem";
            this.powiększenieToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.powiększenieToolStripMenuItem.Text = "Powiększenie";
            // 
            // powiększToolStripMenuItem
            // 
            this.powiększToolStripMenuItem.Name = "powiększToolStripMenuItem";
            this.powiększToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.powiększToolStripMenuItem.Text = "Powiększ";
            this.powiększToolStripMenuItem.Click += new System.EventHandler(this.powiekszPomniejszToolStripMenuItem_Click);
            // 
            // pomniejszToolStripMenuItem
            // 
            this.pomniejszToolStripMenuItem.Name = "pomniejszToolStripMenuItem";
            this.pomniejszToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.pomniejszToolStripMenuItem.Text = "Pomniejesz";
            this.pomniejszToolStripMenuItem.Click += new System.EventHandler(this.powiekszPomniejszToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomo&c";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelPowiekszenie,
            this.toolStripStatusLabelZegar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelPowiekszenie
            // 
            this.toolStripStatusLabelPowiekszenie.Name = "toolStripStatusLabelPowiekszenie";
            this.toolStripStatusLabelPowiekszenie.Size = new System.Drawing.Size(111, 17);
            this.toolStripStatusLabelPowiekszenie.Text = "Powiększenie: 100%";
            // 
            // textBoxNotatnik
            // 
            this.textBoxNotatnik.AllowDrop = true;
            this.textBoxNotatnik.ContextMenuStrip = this.contextMenuStripNotanik;
            this.textBoxNotatnik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNotatnik.Location = new System.Drawing.Point(0, 24);
            this.textBoxNotatnik.Multiline = true;
            this.textBoxNotatnik.Name = "textBoxNotatnik";
            this.textBoxNotatnik.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxNotatnik.Size = new System.Drawing.Size(800, 404);
            this.textBoxNotatnik.TabIndex = 2;
            this.textBoxNotatnik.WordWrap = false;
            this.textBoxNotatnik.FontChanged += new System.EventHandler(this.textBoxNotatnik_FontChanged);
            this.textBoxNotatnik.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxNotatnik_DragDrop);
            this.textBoxNotatnik.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxNotatnik_DragEnter);
            this.textBoxNotatnik.DragOver += new System.Windows.Forms.DragEventHandler(this.textBoxNotatnik_DragOver);
            this.textBoxNotatnik.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNotatnik_KeyDown);
            this.textBoxNotatnik.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxNotatnik_KeyUp);
            // 
            // contextMenuStripNotanik
            // 
            this.contextMenuStripNotanik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wytnijToolStripMenuItem1,
            this.kopiujToolStripMenuItem,
            this.wklejToolStripMenuItem1,
            this.usuńToolStripMenuItem1});
            this.contextMenuStripNotanik.Name = "contextMenuStripNotanik";
            this.contextMenuStripNotanik.Size = new System.Drawing.Size(109, 92);
            // 
            // wytnijToolStripMenuItem1
            // 
            this.wytnijToolStripMenuItem1.Name = "wytnijToolStripMenuItem1";
            this.wytnijToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.wytnijToolStripMenuItem1.Text = "Wytnij";
            this.wytnijToolStripMenuItem1.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.kopiujToolStripMenuItem.Text = "Kopiuj";
            this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.kopjujToolStripMenuItem_Click);
            // 
            // wklejToolStripMenuItem1
            // 
            this.wklejToolStripMenuItem1.Name = "wklejToolStripMenuItem1";
            this.wklejToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.wklejToolStripMenuItem1.Text = "Wklej";
            this.wklejToolStripMenuItem1.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem1
            // 
            this.usuńToolStripMenuItem1.Name = "usuńToolStripMenuItem1";
            this.usuńToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.usuńToolStripMenuItem1.Text = "Usuń";
            this.usuńToolStripMenuItem1.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // toolStripStatusLabelZegar
            // 
            this.toolStripStatusLabelZegar.Name = "toolStripStatusLabelZegar";
            this.toolStripStatusLabelZegar.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabelZegar.Text = "Zegar";
            // 
            // timerZegar
            // 
            this.timerZegar.Interval = 500;
            this.timerZegar.Tick += new System.EventHandler(this.timerZegar_Tick);
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(561, 427);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStop.TabIndex = 3;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // OknoNotatnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.textBoxNotatnik);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripMenuGlowne);
            this.MainMenuStrip = this.menuStripMenuGlowne;
            this.Name = "OknoNotatnik";
            this.Text = "Form1";
            this.menuStripMenuGlowne.ResumeLayout(false);
            this.menuStripMenuGlowne.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripNotanik.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMenuGlowne;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem otworzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBoxNotatnik;
        private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopjujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem znajdxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem znajdźNastępnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataIGodzinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powiększenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powiększToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomniejszToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPowiekszenie;
        private System.Windows.Forms.ToolStripMenuItem zawijanieWierszyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotanik;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelZegar;
        private System.Windows.Forms.Timer timerZegar;
        private System.Windows.Forms.Button buttonStartStop;
    }
}

