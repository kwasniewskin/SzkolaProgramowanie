
namespace Pierwsze_okienka
{
    partial class formOknoGlowne
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
            this.buttonKliknijMnie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKliknijMnie
            // 
            this.buttonKliknijMnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKliknijMnie.Location = new System.Drawing.Point(230, 107);
            this.buttonKliknijMnie.Name = "buttonKliknijMnie";
            this.buttonKliknijMnie.Size = new System.Drawing.Size(159, 66);
            this.buttonKliknijMnie.TabIndex = 0;
            this.buttonKliknijMnie.TabStop = false;
            this.buttonKliknijMnie.Text = "Kliknij mnie";
            this.buttonKliknijMnie.UseVisualStyleBackColor = true;
            this.buttonKliknijMnie.Click += new System.EventHandler(this.buttonKliknijMnie_Click);
            this.buttonKliknijMnie.MouseEnter += new System.EventHandler(this.buttonKliknijMnie_MouseEnter);
            // 
            // formOknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 456);
            this.Controls.Add(this.buttonKliknijMnie);
            this.MinimumSize = new System.Drawing.Size(800, 495);
            this.Name = "formOknoGlowne";
            this.Text = "Pierwszy program WinForms";
            this.Resize += new System.EventHandler(this.formOknoGlowne_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKliknijMnie;
    }
}

