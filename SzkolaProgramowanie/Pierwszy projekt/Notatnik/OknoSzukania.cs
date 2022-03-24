using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class OknoSzukania : Form
    {
        public string SzukanyTekst
        {
            get
            {
                return textBoxSzukanyTekst.Text;
            }
            set
            {
                textBoxSzukanyTekst.Text = value;
            }
        }


        public OknoSzukania()
        {
            InitializeComponent();
        }

        private void buttonSzukaj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBoxSzukanyTekst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buttonSzukaj_Click(null, null);
                //buttonSzukaj_Click(buttonSzukaj, new EventArgs());
                buttonSzukaj.PerformClick();
            }
        }
    }
}
