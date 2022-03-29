
namespace Przelicznik
{
    partial class FormPrzelicznik
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
            this.groupBoxRodzaj = new System.Windows.Forms.GroupBox();
            this.comboBoxRodzaj = new System.Windows.Forms.ComboBox();
            this.groupBoxJednostkaZrodlowa = new System.Windows.Forms.GroupBox();
            this.comboBoxJednostkaZrodlowa = new System.Windows.Forms.ComboBox();
            this.groupBoxJednostkaDocelowa = new System.Windows.Forms.GroupBox();
            this.comboBoxJednostkaDocelowa = new System.Windows.Forms.ComboBox();
            this.groupBoxWartosc = new System.Windows.Forms.GroupBox();
            this.textBoxWartosc = new System.Windows.Forms.TextBox();
            this.buttonPrzelicz = new System.Windows.Forms.Button();
            this.groupBoxWynik = new System.Windows.Forms.GroupBox();
            this.labelWynik = new System.Windows.Forms.Label();
            this.groupBoxRodzaj.SuspendLayout();
            this.groupBoxJednostkaZrodlowa.SuspendLayout();
            this.groupBoxJednostkaDocelowa.SuspendLayout();
            this.groupBoxWartosc.SuspendLayout();
            this.groupBoxWynik.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRodzaj
            // 
            this.groupBoxRodzaj.Controls.Add(this.comboBoxRodzaj);
            this.groupBoxRodzaj.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxRodzaj.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRodzaj.Name = "groupBoxRodzaj";
            this.groupBoxRodzaj.Size = new System.Drawing.Size(800, 59);
            this.groupBoxRodzaj.TabIndex = 0;
            this.groupBoxRodzaj.TabStop = false;
            this.groupBoxRodzaj.Text = "Rodzaj:";
            // 
            // comboBoxRodzaj
            // 
            this.comboBoxRodzaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxRodzaj.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxRodzaj.Location = new System.Drawing.Point(3, 19);
            this.comboBoxRodzaj.Name = "comboBoxRodzaj";
            this.comboBoxRodzaj.Size = new System.Drawing.Size(794, 23);
            this.comboBoxRodzaj.TabIndex = 0;
            // 
            // groupBoxJednostkaZrodlowa
            // 
            this.groupBoxJednostkaZrodlowa.Controls.Add(this.comboBoxJednostkaZrodlowa);
            this.groupBoxJednostkaZrodlowa.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxJednostkaZrodlowa.Location = new System.Drawing.Point(0, 59);
            this.groupBoxJednostkaZrodlowa.Name = "groupBoxJednostkaZrodlowa";
            this.groupBoxJednostkaZrodlowa.Size = new System.Drawing.Size(800, 62);
            this.groupBoxJednostkaZrodlowa.TabIndex = 1;
            this.groupBoxJednostkaZrodlowa.TabStop = false;
            this.groupBoxJednostkaZrodlowa.Text = "Jednostka źródłowa:";
            // 
            // comboBoxJednostkaZrodlowa
            // 
            this.comboBoxJednostkaZrodlowa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxJednostkaZrodlowa.FormattingEnabled = true;
            this.comboBoxJednostkaZrodlowa.Location = new System.Drawing.Point(3, 19);
            this.comboBoxJednostkaZrodlowa.Name = "comboBoxJednostkaZrodlowa";
            this.comboBoxJednostkaZrodlowa.Size = new System.Drawing.Size(794, 23);
            this.comboBoxJednostkaZrodlowa.TabIndex = 0;
            // 
            // groupBoxJednostkaDocelowa
            // 
            this.groupBoxJednostkaDocelowa.Controls.Add(this.comboBoxJednostkaDocelowa);
            this.groupBoxJednostkaDocelowa.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxJednostkaDocelowa.Location = new System.Drawing.Point(0, 121);
            this.groupBoxJednostkaDocelowa.Name = "groupBoxJednostkaDocelowa";
            this.groupBoxJednostkaDocelowa.Size = new System.Drawing.Size(800, 61);
            this.groupBoxJednostkaDocelowa.TabIndex = 2;
            this.groupBoxJednostkaDocelowa.TabStop = false;
            this.groupBoxJednostkaDocelowa.Text = "Jednostka docelowa:";
            // 
            // comboBoxJednostkaDocelowa
            // 
            this.comboBoxJednostkaDocelowa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxJednostkaDocelowa.FormattingEnabled = true;
            this.comboBoxJednostkaDocelowa.Location = new System.Drawing.Point(3, 19);
            this.comboBoxJednostkaDocelowa.Name = "comboBoxJednostkaDocelowa";
            this.comboBoxJednostkaDocelowa.Size = new System.Drawing.Size(794, 23);
            this.comboBoxJednostkaDocelowa.TabIndex = 0;
            // 
            // groupBoxWartosc
            // 
            this.groupBoxWartosc.Controls.Add(this.textBoxWartosc);
            this.groupBoxWartosc.Controls.Add(this.buttonPrzelicz);
            this.groupBoxWartosc.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxWartosc.Location = new System.Drawing.Point(0, 182);
            this.groupBoxWartosc.Name = "groupBoxWartosc";
            this.groupBoxWartosc.Size = new System.Drawing.Size(800, 78);
            this.groupBoxWartosc.TabIndex = 3;
            this.groupBoxWartosc.TabStop = false;
            this.groupBoxWartosc.Text = "Wartość:";
            // 
            // textBoxWartosc
            // 
            this.textBoxWartosc.Location = new System.Drawing.Point(13, 34);
            this.textBoxWartosc.Name = "textBoxWartosc";
            this.textBoxWartosc.Size = new System.Drawing.Size(567, 23);
            this.textBoxWartosc.TabIndex = 1;
            // 
            // buttonPrzelicz
            // 
            this.buttonPrzelicz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrzelicz.Location = new System.Drawing.Point(586, 22);
            this.buttonPrzelicz.Name = "buttonPrzelicz";
            this.buttonPrzelicz.Size = new System.Drawing.Size(202, 50);
            this.buttonPrzelicz.TabIndex = 0;
            this.buttonPrzelicz.Text = "Przelicz";
            this.buttonPrzelicz.UseVisualStyleBackColor = true;
            // 
            // groupBoxWynik
            // 
            this.groupBoxWynik.Controls.Add(this.labelWynik);
            this.groupBoxWynik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWynik.Location = new System.Drawing.Point(0, 260);
            this.groupBoxWynik.Name = "groupBoxWynik";
            this.groupBoxWynik.Size = new System.Drawing.Size(800, 190);
            this.groupBoxWynik.TabIndex = 4;
            this.groupBoxWynik.TabStop = false;
            this.groupBoxWynik.Text = "Wynik:";
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWynik.Location = new System.Drawing.Point(200, 70);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(152, 54);
            this.labelWynik.TabIndex = 0;
            this.labelWynik.Text = "Wynik: ";
            // 
            // FormPrzelicznik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxWynik);
            this.Controls.Add(this.groupBoxWartosc);
            this.Controls.Add(this.groupBoxJednostkaDocelowa);
            this.Controls.Add(this.groupBoxJednostkaZrodlowa);
            this.Controls.Add(this.groupBoxRodzaj);
            this.Name = "FormPrzelicznik";
            this.Text = "Przelicznik";
            this.groupBoxRodzaj.ResumeLayout(false);
            this.groupBoxJednostkaZrodlowa.ResumeLayout(false);
            this.groupBoxJednostkaDocelowa.ResumeLayout(false);
            this.groupBoxWartosc.ResumeLayout(false);
            this.groupBoxWartosc.PerformLayout();
            this.groupBoxWynik.ResumeLayout(false);
            this.groupBoxWynik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRodzaj;
        private System.Windows.Forms.ComboBox comboBoxRodzaj;
        private System.Windows.Forms.GroupBox groupBoxJednostkaZrodlowa;
        private System.Windows.Forms.ComboBox comboBoxJednostkaZrodlowa;
        private System.Windows.Forms.GroupBox groupBoxJednostkaDocelowa;
        private System.Windows.Forms.ComboBox comboBoxJednostkaDocelowa;
        private System.Windows.Forms.GroupBox groupBoxWartosc;
        private System.Windows.Forms.Button buttonPrzelicz;
        private System.Windows.Forms.GroupBox groupBoxWynik;
        private System.Windows.Forms.TextBox textBoxWartosc;
        private System.Windows.Forms.Label labelWynik;
    }
}

