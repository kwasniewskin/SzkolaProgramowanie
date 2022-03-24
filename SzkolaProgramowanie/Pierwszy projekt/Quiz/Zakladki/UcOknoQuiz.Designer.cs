
namespace Quiz.Zakladki
{
    partial class UcOknoQuiz
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
            this.components = new System.ComponentModel.Container();
            this.buttonLosujPytania = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerZegar = new System.Windows.Forms.Timer(this.components);
            this.labelOdliczanie = new System.Windows.Forms.Label();
            this.labelIloscPytan = new System.Windows.Forms.Label();
            this.labelCzasNaJednoPytanie = new System.Windows.Forms.Label();
            this.buttonNastepnePytanie = new System.Windows.Forms.Button();
            this.textBoxtrescPytania = new System.Windows.Forms.TextBox();
            this.labelTrescPytania = new System.Windows.Forms.Label();
            this.panelPytanie = new System.Windows.Forms.Panel();
            this.buttonPoprzedniePytanie = new System.Windows.Forms.Button();
            this.flowLayoutPanelOdpowiedzi = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelKoniguracja = new System.Windows.Forms.Panel();
            this.numericUpDownCzasNaPytanie = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIloscPytan = new System.Windows.Forms.NumericUpDown();
            this.buttonStop = new System.Windows.Forms.Button();
            this.panelPytanie.SuspendLayout();
            this.flowLayoutPanelOdpowiedzi.SuspendLayout();
            this.panelKoniguracja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCzasNaPytanie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIloscPytan)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLosujPytania
            // 
            this.buttonLosujPytania.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLosujPytania.Location = new System.Drawing.Point(3, 6);
            this.buttonLosujPytania.Name = "buttonLosujPytania";
            this.buttonLosujPytania.Size = new System.Drawing.Size(302, 114);
            this.buttonLosujPytania.TabIndex = 0;
            this.buttonLosujPytania.Text = "Losuj pytania";
            this.buttonLosujPytania.UseVisualStyleBackColor = true;
            this.buttonLosujPytania.Click += new System.EventHandler(this.buttonLosujPytania_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(468, 17);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(181, 114);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerZegar
            // 
            this.timerZegar.Interval = 1000;
            this.timerZegar.Tick += new System.EventHandler(this.timerZegar_Tick);
            // 
            // labelOdliczanie
            // 
            this.labelOdliczanie.AutoSize = true;
            this.labelOdliczanie.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOdliczanie.Location = new System.Drawing.Point(521, 143);
            this.labelOdliczanie.Name = "labelOdliczanie";
            this.labelOdliczanie.Size = new System.Drawing.Size(284, 89);
            this.labelOdliczanie.TabIndex = 2;
            this.labelOdliczanie.Text = "00:00:00";
            // 
            // labelIloscPytan
            // 
            this.labelIloscPytan.AutoSize = true;
            this.labelIloscPytan.Location = new System.Drawing.Point(3, 136);
            this.labelIloscPytan.Name = "labelIloscPytan";
            this.labelIloscPytan.Size = new System.Drawing.Size(67, 15);
            this.labelIloscPytan.TabIndex = 4;
            this.labelIloscPytan.Text = "Ilość pytań:";
            // 
            // labelCzasNaJednoPytanie
            // 
            this.labelCzasNaJednoPytanie.AutoSize = true;
            this.labelCzasNaJednoPytanie.Location = new System.Drawing.Point(87, 136);
            this.labelCzasNaJednoPytanie.Name = "labelCzasNaJednoPytanie";
            this.labelCzasNaJednoPytanie.Size = new System.Drawing.Size(178, 30);
            this.labelCzasNaJednoPytanie.TabIndex = 5;
            this.labelCzasNaJednoPytanie.Text = "Czas odpowiedzi \r\nna jedno pytanie (w sekundach):";
            // 
            // buttonNastepnePytanie
            // 
            this.buttonNastepnePytanie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNastepnePytanie.Location = new System.Drawing.Point(763, 28);
            this.buttonNastepnePytanie.Name = "buttonNastepnePytanie";
            this.buttonNastepnePytanie.Size = new System.Drawing.Size(111, 93);
            this.buttonNastepnePytanie.TabIndex = 7;
            this.buttonNastepnePytanie.Text = "Następne pytanie";
            this.buttonNastepnePytanie.UseVisualStyleBackColor = true;
            this.buttonNastepnePytanie.Click += new System.EventHandler(this.buttonNastepnePytanie_Click);
            // 
            // textBoxtrescPytania
            // 
            this.textBoxtrescPytania.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxtrescPytania.Location = new System.Drawing.Point(6, 28);
            this.textBoxtrescPytania.Multiline = true;
            this.textBoxtrescPytania.Name = "textBoxtrescPytania";
            this.textBoxtrescPytania.ReadOnly = true;
            this.textBoxtrescPytania.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxtrescPytania.Size = new System.Drawing.Size(751, 110);
            this.textBoxtrescPytania.TabIndex = 8;
            // 
            // labelTrescPytania
            // 
            this.labelTrescPytania.AutoSize = true;
            this.labelTrescPytania.Location = new System.Drawing.Point(6, 10);
            this.labelTrescPytania.Name = "labelTrescPytania";
            this.labelTrescPytania.Size = new System.Drawing.Size(78, 15);
            this.labelTrescPytania.TabIndex = 9;
            this.labelTrescPytania.Text = "Treść pytania:";
            // 
            // panelPytanie
            // 
            this.panelPytanie.Controls.Add(this.buttonPoprzedniePytanie);
            this.panelPytanie.Controls.Add(this.flowLayoutPanelOdpowiedzi);
            this.panelPytanie.Controls.Add(this.labelTrescPytania);
            this.panelPytanie.Controls.Add(this.buttonNastepnePytanie);
            this.panelPytanie.Controls.Add(this.textBoxtrescPytania);
            this.panelPytanie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPytanie.Location = new System.Drawing.Point(0, 284);
            this.panelPytanie.Name = "panelPytanie";
            this.panelPytanie.Size = new System.Drawing.Size(899, 301);
            this.panelPytanie.TabIndex = 10;
            this.panelPytanie.Visible = false;
            // 
            // buttonPoprzedniePytanie
            // 
            this.buttonPoprzedniePytanie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPoprzedniePytanie.Location = new System.Drawing.Point(763, 171);
            this.buttonPoprzedniePytanie.Name = "buttonPoprzedniePytanie";
            this.buttonPoprzedniePytanie.Size = new System.Drawing.Size(111, 110);
            this.buttonPoprzedniePytanie.TabIndex = 13;
            this.buttonPoprzedniePytanie.Text = "Poprzednie pytanie";
            this.buttonPoprzedniePytanie.UseVisualStyleBackColor = true;
            this.buttonPoprzedniePytanie.Click += new System.EventHandler(this.buttonPoprzedniePytanie_Click);
            // 
            // flowLayoutPanelOdpowiedzi
            // 
            this.flowLayoutPanelOdpowiedzi.AutoScroll = true;
            this.flowLayoutPanelOdpowiedzi.Controls.Add(this.checkBox1);
            this.flowLayoutPanelOdpowiedzi.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelOdpowiedzi.Location = new System.Drawing.Point(9, 144);
            this.flowLayoutPanelOdpowiedzi.Name = "flowLayoutPanelOdpowiedzi";
            this.flowLayoutPanelOdpowiedzi.Size = new System.Drawing.Size(748, 137);
            this.flowLayoutPanelOdpowiedzi.TabIndex = 12;
            this.flowLayoutPanelOdpowiedzi.WrapContents = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panelKoniguracja
            // 
            this.panelKoniguracja.Controls.Add(this.numericUpDownCzasNaPytanie);
            this.panelKoniguracja.Controls.Add(this.numericUpDownIloscPytan);
            this.panelKoniguracja.Controls.Add(this.buttonLosujPytania);
            this.panelKoniguracja.Controls.Add(this.labelIloscPytan);
            this.panelKoniguracja.Controls.Add(this.labelCzasNaJednoPytanie);
            this.panelKoniguracja.Location = new System.Drawing.Point(6, 3);
            this.panelKoniguracja.Name = "panelKoniguracja";
            this.panelKoniguracja.Size = new System.Drawing.Size(322, 229);
            this.panelKoniguracja.TabIndex = 11;
            // 
            // numericUpDownCzasNaPytanie
            // 
            this.numericUpDownCzasNaPytanie.Location = new System.Drawing.Point(87, 169);
            this.numericUpDownCzasNaPytanie.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownCzasNaPytanie.Name = "numericUpDownCzasNaPytanie";
            this.numericUpDownCzasNaPytanie.Size = new System.Drawing.Size(56, 23);
            this.numericUpDownCzasNaPytanie.TabIndex = 8;
            this.numericUpDownCzasNaPytanie.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // numericUpDownIloscPytan
            // 
            this.numericUpDownIloscPytan.Location = new System.Drawing.Point(3, 154);
            this.numericUpDownIloscPytan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIloscPytan.Name = "numericUpDownIloscPytan";
            this.numericUpDownIloscPytan.Size = new System.Drawing.Size(56, 23);
            this.numericUpDownIloscPytan.TabIndex = 7;
            this.numericUpDownIloscPytan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStop.Location = new System.Drawing.Point(673, 17);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(181, 114);
            this.buttonStop.TabIndex = 12;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // UcOknoQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.panelKoniguracja);
            this.Controls.Add(this.panelPytanie);
            this.Controls.Add(this.labelOdliczanie);
            this.Controls.Add(this.buttonStart);
            this.Name = "UcOknoQuiz";
            this.Size = new System.Drawing.Size(899, 585);
            this.Load += new System.EventHandler(this.UcOknoQuiz_Load);
            this.panelPytanie.ResumeLayout(false);
            this.panelPytanie.PerformLayout();
            this.flowLayoutPanelOdpowiedzi.ResumeLayout(false);
            this.flowLayoutPanelOdpowiedzi.PerformLayout();
            this.panelKoniguracja.ResumeLayout(false);
            this.panelKoniguracja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCzasNaPytanie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIloscPytan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLosujPytania;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerZegar;
        private System.Windows.Forms.Label labelOdliczanie;
        private System.Windows.Forms.Label labelIloscPytan;
        private System.Windows.Forms.Label labelCzasNaJednoPytanie;
        private System.Windows.Forms.Button buttonNastepnePytanie;
        private System.Windows.Forms.TextBox textBoxtrescPytania;
        private System.Windows.Forms.Label labelTrescPytania;
        private System.Windows.Forms.Panel panelPytanie;
        private System.Windows.Forms.Panel panelKoniguracja;
        private System.Windows.Forms.NumericUpDown numericUpDownCzasNaPytanie;
        private System.Windows.Forms.NumericUpDown numericUpDownIloscPytan;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOdpowiedzi;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonPoprzedniePytanie;
    }
}
