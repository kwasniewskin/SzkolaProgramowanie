using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class OknoNotatnik : Form
    {
        private string sciezkaPliku = "";
        private int krok = 5;

        private bool czyWcisnietyCTRL = false;

        private float rozmiarStandardowyCzcionki;

        private string szukanyTekst = "";

        public OknoNotatnik(string[] args)
        {
            InitializeComponent();

            powiększToolStripMenuItem.Tag = krok;
            pomniejszToolStripMenuItem.Tag = -krok;

            textBoxNotatnik.MouseWheel += textBoxNotatnik_MouseWheel;

            rozmiarStandardowyCzcionki = textBoxNotatnik.Font.Size;

            if (args != null && args.Length > 0 && File.Exists(args[0]))
            {
                OtworzPlik(args[0]);
            }

            
        }

        #region Zdarzenia menu Plik

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!textBoxNotatnik.Modified || ZapiszPlikPytanie() != DialogResult.Cancel)
            {
                CzyscNotatnik();
                return;
            }
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZapiszPlikJako();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZapiszPlikPytanie(false);
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxNotatnik.Modified && ZapiszPlikPytanie() == DialogResult.Cancel)
            {
                return;
            }
            Close();
        }

        private void otworzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxNotatnik.Modified && ZapiszPlikPytanie() == DialogResult.Cancel)
                return;

            OtworzPlik();
        }


        #endregion

        #region Zdarzenia menu Edycja

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.Undo();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.Cut();
        }

        private void kopjujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.Copy();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.Paste();
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.SelectedText = "";
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.SelectAll();
        }

        private void dataIGodzinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.Paste(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
        }

        private void znajdxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OknoSzukania oknoSzukania = new OknoSzukania();
            oknoSzukania.SzukanyTekst = szukanyTekst;
            if (oknoSzukania.ShowDialog() == DialogResult.OK)
            {
                szukanyTekst = oknoSzukania.SzukanyTekst;
                //Szukaj(textBoxNotatnik.SelectionStart);
                Szukaj(0);
            }
        }

        private void znajdźNastępnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Szukaj(textBoxNotatnik.SelectionStart + 1);
        }

        #endregion

        #region Zdarzenia menu Format

        private void zawijanieWierszyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zawijanieWierszyToolStripMenuItem.Checked = !zawijanieWierszyToolStripMenuItem.Checked;
            textBoxNotatnik.WordWrap = zawijanieWierszyToolStripMenuItem.Checked;
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = textBoxNotatnik.Font;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxNotatnik.Font = fontDialog.Font;
            }
        }

        #endregion

        #region Zdarzenia menu Widok

        private void powiekszPomniejszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            if (toolStripMenuItem != null)
            {
                int krokZmiany;
                if (int.TryParse(toolStripMenuItem.Tag.ToString(), out krokZmiany))
                    ZmienRozmiarCzcionki(krokZmiany);
            }

        }

        private void textBoxNotatnik_MouseWheel(object sender, MouseEventArgs e)
        {
            if (!czyWcisnietyCTRL)
                return;

            if (e.Delta > 0)
                ZmienRozmiarCzcionki(krok);
            else
                ZmienRozmiarCzcionki(-krok);

        }

        private void textBoxNotatnik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                czyWcisnietyCTRL = true;

        }

        private void textBoxNotatnik_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                czyWcisnietyCTRL = false;
        }

        private void textBoxNotatnik_FontChanged(object sender, EventArgs e)
        {
            float powiekszenie = textBoxNotatnik.Font.Size / rozmiarStandardowyCzcionki * 100;
            toolStripStatusLabelPowiekszenie.Text = "Powiększenie: " + powiekszenie + "%";
        }


        /*
        private void powiększToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int krokZmiany;
            if (int.TryParse(powiększToolStripMenuItem.Tag.ToString(), out krokZmiany))
                ZmienRozmiarCzcionki(krokZmiany);
        }

        private void pomniejszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int krokZmiany;
            if (int.TryParse(pomniejszToolStripMenuItem.Tag.ToString(), out krokZmiany))
                ZmienRozmiarCzcionki(krokZmiany);
        }
        */
        #endregion

        #region Metody zapisu/odczytu pliku

        private void UstawPasekGornyOkna()
        {
            Text = "Notatnik";
            if (sciezkaPliku != "")
                Text += " - " + Path.GetFileName(sciezkaPliku);
        }

        private DialogResult ZapiszPlik()
        {
            File.WriteAllText(sciezkaPliku, textBoxNotatnik.Text);
            textBoxNotatnik.Modified = false;
            UstawPasekGornyOkna();

            return DialogResult.Yes;
        }

        private DialogResult ZapiszPlikJako()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sciezkaPliku = saveFileDialog.FileName;
                ZapiszPlik();
                return DialogResult.Yes;
            }
            return DialogResult.No;
        }

        private DialogResult ZapiszPlikPytanie(bool czyPokazacPytanie = true)
        {
            DialogResult jakZamknietoOkno = DialogResult.Yes;
            if (czyPokazacPytanie)
                jakZamknietoOkno = MessageBox.Show("Plik nie zapisany.\nCzy zapisać?", "Uwaga!!!", MessageBoxButtons.YesNoCancel);

            if (jakZamknietoOkno == DialogResult.Yes)
            {
                if (sciezkaPliku != "")
                    return ZapiszPlik();

                return ZapiszPlikJako();
            }
            return jakZamknietoOkno;
        }

        private void OtworzPlik(string sciezka = "")
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki|*.*";
            if (sciezka != "" || openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sciezkaPliku = sciezka == "" ? openFileDialog.FileName : sciezka;
                textBoxNotatnik.Text = File.ReadAllText(sciezkaPliku);
                textBoxNotatnik.Modified = false;
                UstawPasekGornyOkna();
            }
        }

        private void CzyscNotatnik()
        {
            textBoxNotatnik.Text = "";
            textBoxNotatnik.Modified = false;
            sciezkaPliku = "";
            UstawPasekGornyOkna();
        }


        #endregion

        #region Metody menu widok

        private void ZmienRozmiarCzcionki(int krok)
        {
            FontFamily fontFamily = textBoxNotatnik.Font.FontFamily;
            float size = textBoxNotatnik.Font.Size + krok;
            FontStyle fontStyle = textBoxNotatnik.Font.Style;
            GraphicsUnit graphicsUnit = textBoxNotatnik.Font.Unit;
            byte gdiCharSet = textBoxNotatnik.Font.GdiCharSet;

            if (size <= 0)
                return;
            Font font = new Font(fontFamily, size, fontStyle, graphicsUnit, gdiCharSet);
            textBoxNotatnik.Font = font;
        }

        private void Szukaj(int start)
        {
            if (start > textBoxNotatnik.Text.Length)
            {
                MessageBox.Show("Szukanie poza zakresem");
                return;
            }

            int pozycja = textBoxNotatnik.Text.IndexOf(szukanyTekst, start, StringComparison.CurrentCultureIgnoreCase);
            if (pozycja !=-1)
            {
                textBoxNotatnik.SelectionStart = pozycja;
                textBoxNotatnik.SelectionLength = szukanyTekst.Length;
            }
            else
            {
                MessageBox.Show("Brak szukanej frazy");
            }

        }

        #endregion

        #region Zdarzenia Drag&Drop

        private void textBoxNotatnik_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void textBoxNotatnik_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] pliki = e.Data.GetData(DataFormats.FileDrop) as string[];
                if (pliki != null && pliki.Length > 0)
                {
                    if (File.Exists(pliki[0]))
                    {
                        if (ZapiszPlikPytanie(textBoxNotatnik.Modified) == DialogResult.Yes)
                        {
                            OtworzPlik(pliki[0]);
                        }
                    }
                }
            }
            else if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string tekst = e.Data.GetData(DataFormats.Text) as string;
                if (tekst!=null)
                {
                    textBoxNotatnik.Paste(tekst);
                }
            }
        }

        private void textBoxNotatnik_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                Point pozycja = textBoxNotatnik.PointToClient(Cursor.Position);
                int index = textBoxNotatnik.GetCharIndexFromPosition(pozycja);
                textBoxNotatnik.SelectionStart = index;
                textBoxNotatnik.SelectionLength = 0;
                //textBoxNotatnik.Refresh();
                textBoxNotatnik.Focus();
            }
        }



        #endregion

        private void timerZegar_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelZegar.Text = "Godzina: " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (timerZegar.Enabled)
            {
                buttonStartStop.Text = "Start";
                timerZegar.Enabled = false;
            }
            else
            {
                buttonStartStop.Text = "Stop";
                timerZegar.Enabled = true;
            }
        }
    }
}
