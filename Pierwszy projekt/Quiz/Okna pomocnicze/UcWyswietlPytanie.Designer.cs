
namespace Quiz.Okna_pomocnicze
{
    partial class UcWyswietlPytanie
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
            this.flowLayoutPanelOdpowiedzi = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelTrescPytania = new System.Windows.Forms.Label();
            this.panelLabelTrescPytania = new System.Windows.Forms.Panel();
            this.panelTrescPytania = new System.Windows.Forms.Panel();
            this.textBoxTymczasowy = new System.Windows.Forms.TextBox();
            this.labelOdpowiedzi = new System.Windows.Forms.Label();
            this.flowLayoutPanelOdpowiedzi.SuspendLayout();
            this.panelLabelTrescPytania.SuspendLayout();
            this.panelTrescPytania.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelOdpowiedzi
            // 
            this.flowLayoutPanelOdpowiedzi.AutoScroll = true;
            this.flowLayoutPanelOdpowiedzi.Controls.Add(this.checkBox1);
            this.flowLayoutPanelOdpowiedzi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelOdpowiedzi.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelOdpowiedzi.Location = new System.Drawing.Point(0, 114);
            this.flowLayoutPanelOdpowiedzi.Name = "flowLayoutPanelOdpowiedzi";
            this.flowLayoutPanelOdpowiedzi.Size = new System.Drawing.Size(477, 148);
            this.flowLayoutPanelOdpowiedzi.TabIndex = 15;
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
            this.checkBox1.ThreeState = true;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelTrescPytania
            // 
            this.labelTrescPytania.AutoSize = true;
            this.labelTrescPytania.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTrescPytania.Location = new System.Drawing.Point(0, 0);
            this.labelTrescPytania.Name = "labelTrescPytania";
            this.labelTrescPytania.Size = new System.Drawing.Size(78, 15);
            this.labelTrescPytania.TabIndex = 14;
            this.labelTrescPytania.Text = "Treść pytania:";
            // 
            // panelLabelTrescPytania
            // 
            this.panelLabelTrescPytania.Controls.Add(this.panelTrescPytania);
            this.panelLabelTrescPytania.Controls.Add(this.labelOdpowiedzi);
            this.panelLabelTrescPytania.Controls.Add(this.labelTrescPytania);
            this.panelLabelTrescPytania.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLabelTrescPytania.Location = new System.Drawing.Point(0, 0);
            this.panelLabelTrescPytania.Name = "panelLabelTrescPytania";
            this.panelLabelTrescPytania.Size = new System.Drawing.Size(477, 114);
            this.panelLabelTrescPytania.TabIndex = 16;
            // 
            // panelTrescPytania
            // 
            this.panelTrescPytania.Controls.Add(this.textBoxTymczasowy);
            this.panelTrescPytania.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrescPytania.Location = new System.Drawing.Point(0, 15);
            this.panelTrescPytania.Name = "panelTrescPytania";
            this.panelTrescPytania.Size = new System.Drawing.Size(477, 84);
            this.panelTrescPytania.TabIndex = 16;
            // 
            // textBoxTymczasowy
            // 
            this.textBoxTymczasowy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTymczasowy.Location = new System.Drawing.Point(0, 0);
            this.textBoxTymczasowy.Multiline = true;
            this.textBoxTymczasowy.Name = "textBoxTymczasowy";
            this.textBoxTymczasowy.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTymczasowy.Size = new System.Drawing.Size(477, 84);
            this.textBoxTymczasowy.TabIndex = 0;
            // 
            // labelOdpowiedzi
            // 
            this.labelOdpowiedzi.AutoSize = true;
            this.labelOdpowiedzi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelOdpowiedzi.Location = new System.Drawing.Point(0, 99);
            this.labelOdpowiedzi.Name = "labelOdpowiedzi";
            this.labelOdpowiedzi.Size = new System.Drawing.Size(73, 15);
            this.labelOdpowiedzi.TabIndex = 15;
            this.labelOdpowiedzi.Text = "Odpowiedzi:";
            // 
            // UcWyswietlPytanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelOdpowiedzi);
            this.Controls.Add(this.panelLabelTrescPytania);
            this.Name = "UcWyswietlPytanie";
            this.Size = new System.Drawing.Size(477, 262);
            this.flowLayoutPanelOdpowiedzi.ResumeLayout(false);
            this.flowLayoutPanelOdpowiedzi.PerformLayout();
            this.panelLabelTrescPytania.ResumeLayout(false);
            this.panelLabelTrescPytania.PerformLayout();
            this.panelTrescPytania.ResumeLayout(false);
            this.panelTrescPytania.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOdpowiedzi;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelTrescPytania;
        private System.Windows.Forms.Panel panelLabelTrescPytania;
        private System.Windows.Forms.Label labelOdpowiedzi;
        private System.Windows.Forms.Panel panelTrescPytania;
        private System.Windows.Forms.TextBox textBoxTymczasowy;
    }
}
