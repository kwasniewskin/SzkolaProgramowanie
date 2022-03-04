using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaPesel
{
    public partial class OknoGlowne : Form
    {
        public OknoGlowne()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numer = textBoxPesel.Text;

            if (numer.Length != 11)
            {
                MessageBox.Show("Błąd - nieprawidłowa ilość znaków w numerze PESEL");
                return;
            }

            int.TryParse(numer[9].ToString(), out int plec);
            if (plec % 2 == 0)
                labelPlec.Text = "Plec: Kobieta";
            else
                labelPlec.Text = "Plec: Mężczyzna";

            string data = numer[4].ToString() + numer[5].ToString();

            int.TryParse(numer[2].ToString()+ numer[3].ToString(), out int miesiac);
            int.TryParse(numer[0].ToString() + numer[1].ToString(), out int rok);
            if (miesiac >= 1 && miesiac <= 12)
            {
                miesiac -= 0;
                rok += 1900;
            }
            if (miesiac >= 21 && miesiac <=32)
            {
                miesiac -= 20;
                rok += 2000;
            }
            data += "." + miesiac.ToString("00") + "."+rok.ToString();
            labelData.Text = "Data urodzin: " + data;
        }
    }
}
