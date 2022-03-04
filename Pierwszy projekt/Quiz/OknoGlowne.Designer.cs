
namespace Quiz
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
            this.tabControlQuiz = new System.Windows.Forms.TabControl();
            this.tabPageListaPytan = new System.Windows.Forms.TabPage();
            this.ucListaPytan = new Quiz.Zakladki.UcListaPytan();
            this.tabPageQuiz = new System.Windows.Forms.TabPage();
            this.ucOknoQuiz = new Quiz.Zakladki.UcOknoQuiz();
            this.tabControlQuiz.SuspendLayout();
            this.tabPageListaPytan.SuspendLayout();
            this.tabPageQuiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlQuiz
            // 
            this.tabControlQuiz.Controls.Add(this.tabPageListaPytan);
            this.tabControlQuiz.Controls.Add(this.tabPageQuiz);
            this.tabControlQuiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlQuiz.Location = new System.Drawing.Point(0, 0);
            this.tabControlQuiz.Name = "tabControlQuiz";
            this.tabControlQuiz.SelectedIndex = 0;
            this.tabControlQuiz.Size = new System.Drawing.Size(975, 590);
            this.tabControlQuiz.TabIndex = 0;
            // 
            // tabPageListaPytan
            // 
            this.tabPageListaPytan.Controls.Add(this.ucListaPytan);
            this.tabPageListaPytan.Location = new System.Drawing.Point(4, 24);
            this.tabPageListaPytan.Name = "tabPageListaPytan";
            this.tabPageListaPytan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListaPytan.Size = new System.Drawing.Size(967, 562);
            this.tabPageListaPytan.TabIndex = 0;
            this.tabPageListaPytan.Text = "Lista pytań";
            this.tabPageListaPytan.UseVisualStyleBackColor = true;
            // 
            // ucListaPytan
            // 
            this.ucListaPytan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucListaPytan.Location = new System.Drawing.Point(3, 3);
            this.ucListaPytan.Name = "ucListaPytan";
            this.ucListaPytan.Repository = null;
            this.ucListaPytan.Size = new System.Drawing.Size(961, 556);
            this.ucListaPytan.TabIndex = 0;
            // 
            // tabPageQuiz
            // 
            this.tabPageQuiz.Controls.Add(this.ucOknoQuiz);
            this.tabPageQuiz.Location = new System.Drawing.Point(4, 24);
            this.tabPageQuiz.Name = "tabPageQuiz";
            this.tabPageQuiz.Size = new System.Drawing.Size(967, 562);
            this.tabPageQuiz.TabIndex = 2;
            this.tabPageQuiz.Text = "Quiz";
            this.tabPageQuiz.UseVisualStyleBackColor = true;
            // 
            // ucOknoQuiz
            // 
            this.ucOknoQuiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOknoQuiz.Location = new System.Drawing.Point(0, 0);
            this.ucOknoQuiz.Name = "ucOknoQuiz";
            this.ucOknoQuiz.Size = new System.Drawing.Size(967, 562);
            this.ucOknoQuiz.TabIndex = 0;
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 590);
            this.Controls.Add(this.tabControlQuiz);
            this.Name = "OknoGlowne";
            this.Text = "Quiz";
            this.tabControlQuiz.ResumeLayout(false);
            this.tabPageListaPytan.ResumeLayout(false);
            this.tabPageQuiz.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlQuiz;
        private System.Windows.Forms.TabPage tabPageListaPytan;
        private Zakladki.UcListaPytan ucListaPytan;
        private System.Windows.Forms.TabPage tabPageQuiz;
        private Zakladki.UcOknoQuiz ucOknoQuiz;
    }
}

