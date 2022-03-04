
namespace AplikacjaPesel
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelPlec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Odczytaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(12, 27);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(180, 23);
            this.textBoxPesel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesel:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(19, 88);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(34, 15);
            this.labelData.TabIndex = 3;
            this.labelData.Text = "Data:";
            // 
            // labelPlec
            // 
            this.labelPlec.AutoSize = true;
            this.labelPlec.Location = new System.Drawing.Point(24, 125);
            this.labelPlec.Name = "labelPlec";
            this.labelPlec.Size = new System.Drawing.Size(32, 15);
            this.labelPlec.TabIndex = 4;
            this.labelPlec.Text = "Płeć:";
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPlec);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPesel);
            this.Controls.Add(this.button1);
            this.Name = "OknoGlowne";
            this.Text = "Pesel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelPlec;
    }
}

