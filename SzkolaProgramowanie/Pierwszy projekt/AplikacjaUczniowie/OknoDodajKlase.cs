using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AplikacjaUczniowie
{
    public partial class OknoDodajKlase : Form
    {
        public string NazwaKlasy 
        {
            get 
            {
                return textBoxNazwaKlasy.Text;
            }
            set
            {
                textBoxNazwaKlasy.Text = value;
            } 
        }

        public OknoDodajKlase()
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

        private void textBoxNazwaKlasy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonDodaj.PerformClick();
            }
        }
    }
}
