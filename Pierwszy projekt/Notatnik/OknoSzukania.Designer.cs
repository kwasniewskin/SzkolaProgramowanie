
namespace Notatnik
{
    partial class OknoSzukania
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
            this.buttonSzukaj = new System.Windows.Forms.Button();
            this.textBoxSzukanyTekst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSzukaj
            // 
            this.buttonSzukaj.Location = new System.Drawing.Point(12, 80);
            this.buttonSzukaj.Name = "buttonSzukaj";
            this.buttonSzukaj.Size = new System.Drawing.Size(463, 23);
            this.buttonSzukaj.TabIndex = 0;
            this.buttonSzukaj.Text = "Szukaj";
            this.buttonSzukaj.UseVisualStyleBackColor = true;
            this.buttonSzukaj.Click += new System.EventHandler(this.buttonSzukaj_Click);
            // 
            // textBoxSzukanyTekst
            // 
            this.textBoxSzukanyTekst.Location = new System.Drawing.Point(12, 29);
            this.textBoxSzukanyTekst.Name = "textBoxSzukanyTekst";
            this.textBoxSzukanyTekst.Size = new System.Drawing.Size(463, 20);
            this.textBoxSzukanyTekst.TabIndex = 1;
            this.textBoxSzukanyTekst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSzukanyTekst_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Szukany tekst";
            // 
            // OknoSzukania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 117);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSzukanyTekst);
            this.Controls.Add(this.buttonSzukaj);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OknoSzukania";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Okno szukania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSzukaj;
        private System.Windows.Forms.TextBox textBoxSzukanyTekst;
        private System.Windows.Forms.Label label1;
    }
}