using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quiz.Okna_pomocnicze
{
    public partial class OknoNowejOdpowiedzi : Form
    {
        public string TrescOdpowiedzi
        {
            get
            {
                return textBoxOdpowiedz.Text;
            }
        }
        public bool CzyPoprawna 
        { 
            get
            {
                return checkBoxCzyPrawidlowa.Checked;
            }
        }

        public OknoNowejOdpowiedzi()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
