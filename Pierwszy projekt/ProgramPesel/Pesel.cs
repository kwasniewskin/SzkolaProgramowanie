using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramPesel
{
    class Pesel
    {
        private string numerPesel;

        public string Plec {

            get
            {
                return numerPesel[9].ToString();
            }
        }

        public string PlecOpis {
            get
            {
                int plec = int.Parse(numerPesel[9].ToString());
                if (plec % 2 == 0)
                    return "Kobieta";
                else
                    return "Mezczyzna";
            }
        }

        public int DzienUrodzenia
        {
            get
            {
                return ObliczDzien();
            }
        }

        public int MiesiacUrodzenia
        {

            get
            {
                return ObliczMiesiacUrodzenia();
            }
        }

        public string MiesiacUrodzeniaOpis
        {

            get
            {
                switch (ObliczMiesiacUrodzenia())
                {
                    case 1:
                        return "Styczen";
                        break;
                    case 2:
                        return "Luty";
                        break;
                    case 3:
                        return "Marzec";
                        break;
                    case 4:
                        return "Kwiecien";
                        break;
                    case 5:
                        return "Maj";
                        break;
                    case 6:
                        return "Czerwiec";
                        break;
                    case 7:
                        return "Lipiec";
                        break;
                    case 8:
                        return "Sierpien";
                        break;
                    case 9:
                        return "Wrzesien";
                        break;
                    case 10:
                        return "Pazdziernik";
                        break;
                    case 11:
                        return "Listopad";
                        break;
                    case 12:
                        return "Grudzien";
                        break;
                    default:
                        return "";
                        break;
                }
            }
        }

        public int RokUrodzenia {

            get
            {
                int rok = ObliczRok(); 
                
                if()
                {
                    return 2000 + rok;
                }
                else
                {
                    return 1900 + rok;
                }
            }
        }

        public Pesel(string numerPesel)
        {
            this.numerPesel = numerPesel;
            Walidacja();

        }

        #region Walidacja
        private void Walidacja()
        {
            WalidacjaPoprawnoscDlugosci();
            WalidacjaPoprawnoscZnakow();
            WalidacjaPoprawnoscMiesiaca();
            WalidacjaPoprawnoscDnia();
            WalidacjaPoprawnoscCyfryKontrolnej();
        }

        private void WalidacjaPoprawnoscDlugosci()
        {
            if (numerPesel.Length != 11)
                throw new Exception("Zła długość numeru pesel!");
        }

        private void WalidacjaPoprawnoscZnakow()
        {
            for (int i = 0; i < 11; i++)
            {
                if (!IsNumber(numerPesel[i]))
                    throw new Exception("Pesel zawiera niepoprawne znaki");
            }
        }

        private void WalidacjaPoprawnoscMiesiaca()
        {
            int miesiac = ObliczMiesiacUrodzenia();
            if (miesiac > 12 || miesiac < 1)
                throw new Exception("Podany miesiąc jest nieprawidłowy");
        }

        private void WalidacjaPoprawnoscDnia()
        {
            int dzien = ObliczDzien();
            int miesiac = ObliczMiesiacUrodzenia();
            int rok = ObliczRok();
            int[] miesiace30 = {4, 6, 9, 11};

            if (dzien < 1 || dzien > 31)
                throw new Exception("Podany dzien jest nieprawidlowy (poza zakresem 1:31)");

            for (int i=0; i<4; i++)
                if (miesiac == miesiace30[i] && dzien > 30)
                    throw new Exception("Podany dzien jest nieprawidlowy(w danym miesiacu dzien powinien miec 30 dni)");

            if((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
            {
                if (miesiac == 2 && dzien != 29)
                    throw new Exception("Podany dzien jest nieprawidlowy (luty w roku przestepnym powinien miec 29dni)");
            }
            else
            {
                if (miesiac == 2 && dzien != 28)
                    throw new Exception("Podany dzien jest nieprawidlowy (luty w roku nieprzestepnym powinien miec 28dni)");
            }
        }

        private void WalidacjaPoprawnoscCyfryKontrolnej()
        {
            int sumaCyfr = 0;

            int[] waga = { 1, 3, 7, 9 };

            int j = 0;
            for (int i = 0; i < 11; i++)
            {
                if (j > 3)
                    j = 0;

                if (i == 10)
                    j = 0;

                sumaCyfr += int.Parse(numerPesel[i].ToString()) * waga[j];
                j++;
            }

            if (sumaCyfr % 10 != 0)
                throw new Exception("Zla liczba kontrolna");
        }

        #endregion

        #region MetodyPomocnicze

        private bool IsNumber(char x)
        {
            if (x >= '0' && x <= '9')
                return true;
            else
                return false;
        }

        private int ObliczRok()
        {
            return int.Parse(numerPesel.Substring(0, 2));
        }

        private int ObliczMiesiacUrodzenia()
        {
            int miesiac = int.Parse(numerPesel.Substring(2, 2));
            miesiac %= 20;
            return miesiac;
        }

        private int ObliczDzien()
        {
            return int.Parse(numerPesel.Substring(4, 2));
        }

        #endregion
    }
}
