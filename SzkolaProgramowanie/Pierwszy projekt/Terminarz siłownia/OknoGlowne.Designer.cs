
namespace Terminarz_siłownia
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
            this.groupBoxOsoba = new System.Windows.Forms.GroupBox();
            this.comboBoxOsoby = new System.Windows.Forms.ComboBox();
            this.groupBoxDodanieCwiczenia = new System.Windows.Forms.GroupBox();
            this.labelKategoria = new System.Windows.Forms.Label();
            this.comboBoxKategoria = new System.Windows.Forms.ComboBox();
            this.buttonDodajCwiczenie = new System.Windows.Forms.Button();
            this.numericUpDownIloscPowtorzen = new System.Windows.Forms.NumericUpDown();
            this.labelIloscPowtorzen = new System.Windows.Forms.Label();
            this.dateTimePickerDataCwiczenia = new System.Windows.Forms.DateTimePicker();
            this.labelDataCwiczenia = new System.Windows.Forms.Label();
            this.groupBoxListaCwiczen = new System.Windows.Forms.GroupBox();
            this.dataGridViewListaCwiczen = new System.Windows.Forms.DataGridView();
            this.Kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IloscPowtorzen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzyZrealizowane = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBoxOsoba.SuspendLayout();
            this.groupBoxDodanieCwiczenia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIloscPowtorzen)).BeginInit();
            this.groupBoxListaCwiczen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCwiczen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOsoba
            // 
            this.groupBoxOsoba.Controls.Add(this.comboBoxOsoby);
            this.groupBoxOsoba.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxOsoba.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxOsoba.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOsoba.Name = "groupBoxOsoba";
            this.groupBoxOsoba.Size = new System.Drawing.Size(636, 87);
            this.groupBoxOsoba.TabIndex = 0;
            this.groupBoxOsoba.TabStop = false;
            this.groupBoxOsoba.Text = "Wybierz osobę:";
            // 
            // comboBoxOsoby
            // 
            this.comboBoxOsoby.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOsoby.FormattingEnabled = true;
            this.comboBoxOsoby.Location = new System.Drawing.Point(12, 38);
            this.comboBoxOsoby.Name = "comboBoxOsoby";
            this.comboBoxOsoby.Size = new System.Drawing.Size(340, 29);
            this.comboBoxOsoby.TabIndex = 0;
            // 
            // groupBoxDodanieCwiczenia
            // 
            this.groupBoxDodanieCwiczenia.Controls.Add(this.labelDataCwiczenia);
            this.groupBoxDodanieCwiczenia.Controls.Add(this.dateTimePickerDataCwiczenia);
            this.groupBoxDodanieCwiczenia.Controls.Add(this.labelIloscPowtorzen);
            this.groupBoxDodanieCwiczenia.Controls.Add(this.numericUpDownIloscPowtorzen);
            this.groupBoxDodanieCwiczenia.Controls.Add(this.buttonDodajCwiczenie);
            this.groupBoxDodanieCwiczenia.Controls.Add(this.labelKategoria);
            this.groupBoxDodanieCwiczenia.Controls.Add(this.comboBoxKategoria);
            this.groupBoxDodanieCwiczenia.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDodanieCwiczenia.Location = new System.Drawing.Point(0, 87);
            this.groupBoxDodanieCwiczenia.Name = "groupBoxDodanieCwiczenia";
            this.groupBoxDodanieCwiczenia.Size = new System.Drawing.Size(636, 201);
            this.groupBoxDodanieCwiczenia.TabIndex = 1;
            this.groupBoxDodanieCwiczenia.TabStop = false;
            this.groupBoxDodanieCwiczenia.Text = "Dodawanie ćwiczenia";
            // 
            // labelKategoria
            // 
            this.labelKategoria.AutoSize = true;
            this.labelKategoria.Location = new System.Drawing.Point(12, 19);
            this.labelKategoria.Name = "labelKategoria";
            this.labelKategoria.Size = new System.Drawing.Size(60, 15);
            this.labelKategoria.TabIndex = 1;
            this.labelKategoria.Text = "Kategoria:";
            // 
            // comboBoxKategoria
            // 
            this.comboBoxKategoria.FormattingEnabled = true;
            this.comboBoxKategoria.Location = new System.Drawing.Point(12, 37);
            this.comboBoxKategoria.Name = "comboBoxKategoria";
            this.comboBoxKategoria.Size = new System.Drawing.Size(121, 23);
            this.comboBoxKategoria.TabIndex = 0;
            // 
            // buttonDodajCwiczenie
            // 
            this.buttonDodajCwiczenie.Location = new System.Drawing.Point(508, 34);
            this.buttonDodajCwiczenie.Name = "buttonDodajCwiczenie";
            this.buttonDodajCwiczenie.Size = new System.Drawing.Size(93, 65);
            this.buttonDodajCwiczenie.TabIndex = 2;
            this.buttonDodajCwiczenie.Text = "Dodaj ćwiczenie";
            this.buttonDodajCwiczenie.UseVisualStyleBackColor = true;
            // 
            // numericUpDownIloscPowtorzen
            // 
            this.numericUpDownIloscPowtorzen.Location = new System.Drawing.Point(13, 100);
            this.numericUpDownIloscPowtorzen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIloscPowtorzen.Name = "numericUpDownIloscPowtorzen";
            this.numericUpDownIloscPowtorzen.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownIloscPowtorzen.TabIndex = 3;
            this.numericUpDownIloscPowtorzen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelIloscPowtorzen
            // 
            this.labelIloscPowtorzen.AutoSize = true;
            this.labelIloscPowtorzen.Location = new System.Drawing.Point(13, 82);
            this.labelIloscPowtorzen.Name = "labelIloscPowtorzen";
            this.labelIloscPowtorzen.Size = new System.Drawing.Size(93, 15);
            this.labelIloscPowtorzen.TabIndex = 4;
            this.labelIloscPowtorzen.Text = "Ilość powtórzeń:";
            // 
            // dateTimePickerDataCwiczenia
            // 
            this.dateTimePickerDataCwiczenia.CustomFormat = "";
            this.dateTimePickerDataCwiczenia.Location = new System.Drawing.Point(13, 159);
            this.dateTimePickerDataCwiczenia.Name = "dateTimePickerDataCwiczenia";
            this.dateTimePickerDataCwiczenia.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDataCwiczenia.TabIndex = 5;
            this.dateTimePickerDataCwiczenia.Value = new System.DateTime(2022, 3, 2, 0, 0, 0, 0);
            // 
            // labelDataCwiczenia
            // 
            this.labelDataCwiczenia.AutoSize = true;
            this.labelDataCwiczenia.Location = new System.Drawing.Point(17, 137);
            this.labelDataCwiczenia.Name = "labelDataCwiczenia";
            this.labelDataCwiczenia.Size = new System.Drawing.Size(88, 15);
            this.labelDataCwiczenia.TabIndex = 6;
            this.labelDataCwiczenia.Text = "Data ćwiczenia:";
            // 
            // groupBoxListaCwiczen
            // 
            this.groupBoxListaCwiczen.Controls.Add(this.dataGridViewListaCwiczen);
            this.groupBoxListaCwiczen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxListaCwiczen.Location = new System.Drawing.Point(0, 288);
            this.groupBoxListaCwiczen.Name = "groupBoxListaCwiczen";
            this.groupBoxListaCwiczen.Size = new System.Drawing.Size(636, 247);
            this.groupBoxListaCwiczen.TabIndex = 2;
            this.groupBoxListaCwiczen.TabStop = false;
            this.groupBoxListaCwiczen.Text = "Lista ćwiczeń:";
            // 
            // dataGridViewListaCwiczen
            // 
            this.dataGridViewListaCwiczen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaCwiczen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kategoria,
            this.IloscPowtorzen,
            this.Data,
            this.CzyZrealizowane});
            this.dataGridViewListaCwiczen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListaCwiczen.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewListaCwiczen.Name = "dataGridViewListaCwiczen";
            this.dataGridViewListaCwiczen.ReadOnly = true;
            this.dataGridViewListaCwiczen.RowTemplate.Height = 25;
            this.dataGridViewListaCwiczen.Size = new System.Drawing.Size(630, 225);
            this.dataGridViewListaCwiczen.TabIndex = 0;
            // 
            // Kategoria
            // 
            this.Kategoria.HeaderText = "Kategoria";
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.ReadOnly = true;
            // 
            // IloscPowtorzen
            // 
            this.IloscPowtorzen.HeaderText = "Ilość powtórzeń";
            this.IloscPowtorzen.Name = "IloscPowtorzen";
            this.IloscPowtorzen.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data ćwiczenia";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // CzyZrealizowane
            // 
            this.CzyZrealizowane.HeaderText = "Czy zrealizowane";
            this.CzyZrealizowane.Name = "CzyZrealizowane";
            this.CzyZrealizowane.ReadOnly = true;
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 535);
            this.Controls.Add(this.groupBoxListaCwiczen);
            this.Controls.Add(this.groupBoxDodanieCwiczenia);
            this.Controls.Add(this.groupBoxOsoba);
            this.Name = "OknoGlowne";
            this.Text = "Terminarz siłowni";
            this.groupBoxOsoba.ResumeLayout(false);
            this.groupBoxDodanieCwiczenia.ResumeLayout(false);
            this.groupBoxDodanieCwiczenia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIloscPowtorzen)).EndInit();
            this.groupBoxListaCwiczen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCwiczen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOsoba;
        private System.Windows.Forms.ComboBox comboBoxOsoby;
        private System.Windows.Forms.GroupBox groupBoxDodanieCwiczenia;
        private System.Windows.Forms.Label labelKategoria;
        private System.Windows.Forms.ComboBox comboBoxKategoria;
        private System.Windows.Forms.Label labelDataCwiczenia;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataCwiczenia;
        private System.Windows.Forms.Label labelIloscPowtorzen;
        private System.Windows.Forms.NumericUpDown numericUpDownIloscPowtorzen;
        private System.Windows.Forms.Button buttonDodajCwiczenie;
        private System.Windows.Forms.GroupBox groupBoxListaCwiczen;
        private System.Windows.Forms.DataGridView dataGridViewListaCwiczen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IloscPowtorzen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CzyZrealizowane;
    }
}

