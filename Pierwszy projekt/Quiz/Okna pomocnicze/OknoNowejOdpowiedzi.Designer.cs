
namespace Quiz.Okna_pomocnicze
{
    partial class OknoNowejOdpowiedzi
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
            this.labelTrescOdpowiedzi = new System.Windows.Forms.Label();
            this.checkBoxCzyPrawidlowa = new System.Windows.Forms.CheckBox();
            this.textBoxOdpowiedz = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTrescOdpowiedzi
            // 
            this.labelTrescOdpowiedzi.AutoSize = true;
            this.labelTrescOdpowiedzi.Location = new System.Drawing.Point(12, 9);
            this.labelTrescOdpowiedzi.Name = "labelTrescOdpowiedzi";
            this.labelTrescOdpowiedzi.Size = new System.Drawing.Size(100, 15);
            this.labelTrescOdpowiedzi.TabIndex = 0;
            this.labelTrescOdpowiedzi.Text = "Treść odpowiedzi:";
            // 
            // checkBoxCzyPrawidlowa
            // 
            this.checkBoxCzyPrawidlowa.AutoSize = true;
            this.checkBoxCzyPrawidlowa.Location = new System.Drawing.Point(12, 56);
            this.checkBoxCzyPrawidlowa.Name = "checkBoxCzyPrawidlowa";
            this.checkBoxCzyPrawidlowa.Size = new System.Drawing.Size(109, 19);
            this.checkBoxCzyPrawidlowa.TabIndex = 1;
            this.checkBoxCzyPrawidlowa.Text = "Czy prawidłowa";
            this.checkBoxCzyPrawidlowa.UseVisualStyleBackColor = true;
            // 
            // textBoxOdpowiedz
            // 
            this.textBoxOdpowiedz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOdpowiedz.Location = new System.Drawing.Point(12, 27);
            this.textBoxOdpowiedz.Multiline = true;
            this.textBoxOdpowiedz.Name = "textBoxOdpowiedz";
            this.textBoxOdpowiedz.Size = new System.Drawing.Size(263, 23);
            this.textBoxOdpowiedz.TabIndex = 2;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(46, 105);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 3;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(175, 105);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuluj.TabIndex = 4;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // OknoNowejOdpowiedzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 146);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxOdpowiedz);
            this.Controls.Add(this.checkBoxCzyPrawidlowa);
            this.Controls.Add(this.labelTrescOdpowiedzi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OknoNowejOdpowiedzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OknoNowejOdpowiedzi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTrescOdpowiedzi;
        private System.Windows.Forms.CheckBox checkBoxCzyPrawidlowa;
        private System.Windows.Forms.TextBox textBoxOdpowiedz;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonAnuluj;
    }
}