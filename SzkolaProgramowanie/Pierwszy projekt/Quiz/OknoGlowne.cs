using Baza_danych.Repository;
using System.Windows.Forms;

namespace Quiz
{
    public partial class OknoGlowne : Form
    {
        IRepository Repository;

        public OknoGlowne()
        {
            InitializeComponent();
            Repository = new SqlRepository();

            ucListaPytan.Repository = Repository;
            ucListaPytan.RefreshData();

            ucOknoQuiz.Repository = Repository;
        }
    }
}
