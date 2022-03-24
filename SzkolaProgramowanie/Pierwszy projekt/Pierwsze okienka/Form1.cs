using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pierwsze_okienka
{
    public partial class formOknoGlowne : Form
    {
        int maxX;
        int maxY;
        Random rand = new Random();

        public formOknoGlowne()
        {
            InitializeComponent();
            UstalObszarUcieczki();
        }

        private void UstalObszarUcieczki()
        {
            maxX = this.Size.Width - buttonKliknijMnie.Size.Width;
            maxY = this.Size.Height - buttonKliknijMnie.Size.Height;
        }

        private void buttonKliknijMnie_MouseEnter(object sender, EventArgs e)
        {
            Point punkt = new Point();
            punkt.X = rand.Next(0, maxX);
            punkt.Y = rand.Next(0, maxY);

            buttonKliknijMnie.Location = punkt;
        }

        private void buttonKliknijMnie_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gratulacje!!!");
        }

        private void formOknoGlowne_Resize(object sender, EventArgs e)
        {
            UstalObszarUcieczki();
        }
    }
}
