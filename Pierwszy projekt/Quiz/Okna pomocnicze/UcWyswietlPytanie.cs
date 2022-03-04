using Baza_danych.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Quiz.Okna_pomocnicze
{
    public partial class UcWyswietlPytanie : UserControl
    {
        public PytanieOdpowiedziQuiz WyswieltPytanie 
        { 
            set
            {
                panelTrescPytania.Controls.Clear();

                flowLayoutPanelOdpowiedzi.Controls.Clear();
                if (value != null)
                {
                    panelTrescPytania.Controls.Add(value.PytanieQuiz.TextBoxPytanie);

                    flowLayoutPanelOdpowiedzi.Controls.Clear();
                    foreach (OdpowiedzQuiz odpowiedz in value.OdpowiedziLista)
                    {
                        flowLayoutPanelOdpowiedzi.Controls.Add(odpowiedz.CheckBoxOdpowiedzi);
                    }
                }
            }

        }

        public UcWyswietlPytanie()
        {
            InitializeComponent();
        }


    }

    public class PytanieOdpowiedziQuiz
    {
        public PytanieQuiz PytanieQuiz { get; set; }
        public List<OdpowiedzQuiz> OdpowiedziLista { get; set; }
    }

    public class PytanieQuiz
    {
        public PytanieReadDto PytanieReadDto { get; set; }
        public TextBox TextBoxPytanie { get; set; }
    }

    public class OdpowiedzQuiz
    {
        public OdpowiedzReadDto OdpowiedzReadDto { get; set; }
        public CheckBox CheckBoxOdpowiedzi { get; set; }
    }
}
