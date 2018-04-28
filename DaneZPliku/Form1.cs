using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaneZPliku;

namespace DaneZPlikuOkienko
{
    public partial class DaneZPliku : Form
    {
        private string[][] systemTestowy;
        private string[][] systemTreningowy;

        public DaneZPliku()
        {
            InitializeComponent();
        }

        private void btnWybierzSystemTestowy_Click(object sender, EventArgs e)
        {
            DialogResult wynikWyboruPliku = ofd.ShowDialog(); // wybieramy plik
            if (wynikWyboruPliku != DialogResult.OK)
                return;

            tbSciezkaDoSystemuTestowego.Text = ofd.FileName;
            string trescPliku = System.IO.File.ReadAllText(ofd.FileName); // wczytujemy treść pliku do zmiennej
            string[] wiersze = trescPliku.Trim().Split(new char[] { '\n' }); // treść pliku dzielimy wg znaku końca linii, dzięki czemu otrzymamy każdy wiersz w oddzielnej komórce tablicy
            systemTestowy = new string[wiersze.Length][];   // Tworzymy zmienną, która będzie przechowywała wczytane dane. Tablica będzie miała tyle wierszy ile wierszy było z wczytanego poliku

            for (int i = 0; i < wiersze.Length; i++)
            {
                string wiersz = wiersze[i].Trim();     // przypisuję i-ty element tablicy do zmiennej wiersz
                string[] cyfry = wiersz.Split(new char[] { ' ' });   // dzielimy wiersz po znaku spacji, dzięki czemu otrzymamy tablicę cyfry, w której każda oddzielna komórka to czyfra z wiersza
                systemTestowy[i] = new string[cyfry.Length];    // Do tablicy w której będą dane finalne dokładamy wiersz w postaci tablicy integerów tak długą jak długa jest tablica cyfry, czyli tyle ile było cyfr w jednym wierszu
                for (int j = 0; j < cyfry.Length; j++)
                {
                    string cyfra = cyfry[j].Trim(); // przypisuję j-tą cyfrę do zmiennej cyfra
                    systemTestowy[i][j] = cyfra;  
                }
            }

            tbSystemTestowy.Text = TablicaDoString(systemTestowy);
        }

        private void btnWybierzSystemTreningowy_Click(object sender, EventArgs e)
        {
            DialogResult wynikWyboruPliku = ofd.ShowDialog(); // wybieramy plik
            if (wynikWyboruPliku != DialogResult.OK)
                return;

            tbSciezkaDoSystemuTreningowego.Text = ofd.FileName;
            string trescPliku = System.IO.File.ReadAllText(ofd.FileName); // wczytujemy treść pliku do zmiennej
            string[] wiersze = trescPliku.Trim().Split(new char[] { '\n' }); // treść pliku dzielimy wg znaku końca linii, dzięki czemu otrzymamy każdy wiersz w oddzielnej komórce tablicy
            systemTreningowy = new string[wiersze.Length][];   // Tworzymy zmienną, która będzie przechowywała wczytane dane. Tablica będzie miała tyle wierszy ile wierszy było z wczytanego poliku

            for (int i = 0; i < wiersze.Length; i++)
            {
                string wiersz = wiersze[i].Trim();     // przypisuję i-ty element tablicy do zmiennej wiersz
                string[] cyfry = wiersz.Split(new char[] { ' ' });   // dzielimy wiersz po znaku spacji, dzięki czemu otrzymamy tablicę cyfry, w której każda oddzielna komórka to czyfra z wiersza
                systemTreningowy[i] = new string[cyfry.Length];    // Do tablicy w której będą dane finalne dokładamy wiersz w postaci tablicy integerów tak długą jak długa jest tablica cyfry, czyli tyle ile było cyfr w jednym wierszu
                for (int j = 0; j < cyfry.Length; j++)
                {
                    string cyfra = cyfry[j].Trim(); // przypisuję j-tą cyfrę do zmiennej cyfra
                    systemTreningowy[i][j] = cyfra;
                }
            }

            tbSystemTreningowy.Text = TablicaDoString(systemTreningowy);
        }

        public string TablicaDoString<T>(T[][] tab)
        {
            string wynik = "";
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    wynik += tab[i][j].ToString() + " ";
                }
                wynik = wynik.Trim() + Environment.NewLine;
            }

            return wynik;
        }


        public double StringToDouble(string liczba)
        {
            double wynik; liczba = liczba.Trim();
            if (!double.TryParse(liczba.Replace(',', '.'), out wynik) && !double.TryParse(liczba.Replace('.', ','), out wynik))
                throw new Exception("Nie udało się skonwertować liczby do double");

            return wynik;
        }


        public int StringToInt(string liczba)
        {
            int wynik;
            if (!int.TryParse(liczba.Trim(), out wynik))
                throw new Exception("Nie udało się skonwertować liczby do int");

            return wynik;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Tablica z wczytanymi danymi dostępna poniżej
            // this.systemTestowy;

            // Tablica z typami atrybutów
            // this.systemTreningowy;
            
            /****************** Miejsce na rozwiązanie *********************************/

            int numer=0;
            Metryki m= new Metryki();
            string dec;
          
            Dictionary<ObiektDecyzyjny, string> klasyf = new Dictionary<ObiektDecyzyjny, string>();

            Metryka m1;
            switch (comboBox1.Text)
            {
                case "Czebyszewa":
                    {
                        m1 = m.czebaszewa;
                        wynik.Clear();
                    }
                    break;
                case "Euklidesa":
                    {
                        m1 = m.eklidesowa;
                        wynik.Clear();
                    }
                    break;
                case "Manhattan":
                    {
                        m1 = m.manhattan;
                        wynik.Clear();
                    }
                    break;
                case "Canberra":
                    {
                        m1 = m.canberra;
                        wynik.Clear();
                    }
                    break;
                case "Pearsona":
                    {
                        m1 = m.pearsona;
                        wynik.Clear();
                    }
                    break;
                default:
                    m1 = m.eklidesowa;
                    break;
            }
            
          
            int num;
            num=Convert.ToUInt16(numericUpDown1.Value);
            foreach (var ob in systemTestowy)
            {

                ObiektDecyzyjny obiekt = new ObiektDecyzyjny();
                obiekt = utwurzObiekt(ob, numer);
                dec=klasyfikuj(obiekt.deskryptory, systemTreningowy, num,m1);
                klasyf.Add(obiekt, dec);
                wyswietlKlasyfikacje(numer, dec, ob);
                numer++;
            }

            wyswietl(klasyf);
           
            
            
            /****************** Koniec miejsca na rozwiązanie ********************************/
        }

        public ObiektDecyzyjny utwurzObiekt(string[] obiekt,int numer)
        {
            ObiektDecyzyjny ob = new ObiektDecyzyjny();
            ob.decyzja = obiekt.Last();
            ob.numer = numer;
            double[] pom=new double[obiekt.Length-1];
            for (int i = 0; i < obiekt.Length-1; i++)
            {
                pom[i] = Convert.ToDouble(obiekt[i]);
            }
            ob.deskryptory = pom;
            return ob;
        }
        
        public decimal maxK(string[][] systemTreningowy)
        {
            decimal max = 0;
            max= fCzestosc(fKolumna(systemTreningowy, systemTreningowy[0].Length - 1)).First().Value;
            return max;
        }

        

        public string[] fKolumna(string[][] tab, int nrKolumny)
        {
            string[] kolumna = new string[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                kolumna[i] = tab[i][nrKolumny];
            }
            return kolumna;
        }
        public string[] fUnkialnosc(string[] tab)
        {
            List<string> lista = new List<string>();
            lista.Add(tab[0]);
            for (int i = 0; i < tab.Length; i++)
            {
                if (!lista.Contains(tab[i]))
                    lista.Add(tab[i]);
            }
            return lista.ToArray();
        }

        public double fMin(Dictionary<ObiektDecyzyjny,double> d,string dec,int k)
        {
            double wynik=0.0;
            double min = 999.9;
            int numer = 0;
            List<int> Lmin = new List<int>();
            for (int i = 0; i < k; i++)
            {
                              
                foreach (var ob in d)
                {    
                    
                    if (ob.Key.decyzja == dec)
                    {
                        
                        if (min > ob.Value)
                        {
                            
                             if(!Lmin.Contains(ob.Key.numer))
                             {
                                  min = ob.Value;
                                  numer = ob.Key.numer;
                             }
                                                                          
                        }
                    }
                  
                }
                Lmin.Add(numer);
                wynik += min;
                min = 999;
            }
           
            return wynik;
        }

        public string klasyfikuj(double[] ob,string[][] trn,int k,Metryka m)
        {
            Dictionary<ObiektDecyzyjny,double> d = new Dictionary<ObiektDecyzyjny,double>();
            double min;
            Dictionary<string,double> Lmin = new Dictionary<string,double>();
                       
            ObiektDecyzyjny obiekt= new ObiektDecyzyjny();
            for (int i = 0; i < trn.Length; i++)
            {
                obiekt = utwurzObiekt(trn[i], i);
                d.Add(obiekt, m(ob, obiekt.deskryptory));
                
            }
            
            foreach (var dec in fUnkialnosc(fKolumna(trn,trn[0].Length-1)))
            { 
                min=fMin(d, dec,k);
                Lmin.Add(dec,min);
            }
            for (int i = 1; i < Lmin.Count; i++)
            {
                if (Lmin.ElementAt(i - 1).Value < Lmin.ElementAt(i).Value)
                    return Lmin.ElementAt(i - 1).Key;
                else if (Lmin.ElementAt(i - 1).Value > Lmin.ElementAt(i).Value)
                    return Lmin.ElementAt(i).Key;
            }
                            
            return null;
        }

        void wyswietlKlasyfikacje(int nrob,string dec,string[] ob)
        {
            int nr = nrob + 1;
            if (dec==null)
                wynik.Text += "Obiekt x" + nr + " jest nieuchwytny"+"\r\n";
            else if (ob.Last() == dec)
                wynik.Text += "Obiekt x" + nr + " otzrymuje decyzje " + dec + " jest poprawnie sklasyfikowany" + "\r\n";
            else
                wynik.Text += "Obiekt x" + nr + " otzrymuje decyzje " + dec + " jest  błędnie sklasyfikowany" + "\r\n";

        }

        private void wynik_TextChanged(object sender, EventArgs e)
        {

        }


        public double accuracy(Dictionary<ObiektDecyzyjny,string> klasyfikacja,string dec)
        {
            double poprawne = 0.0;
            double ilosc=0.0;
            double accuracy = 0.0;
            foreach (var k in klasyfikacja)
            {
               if(k.Key.decyzja==dec)
               {
                   if (k.Value == dec)
                   {
                       poprawne++;
                       ilosc++;
                   }
                   else if(k.Value==null)
                   {
                       poprawne++;
                       ilosc++;
                   }
                   else
                       ilosc++;
               }
            }
            accuracy = poprawne / ilosc;
            return accuracy;
        }
        public double coverage(Dictionary<ObiektDecyzyjny,string> klasyfikacja,string dec)
        {
            double ilosc = 0.0;
            double pokryte = 0.0;
            double coverage = 0.0;
            foreach (var k in klasyfikacja)
            {
                if(k.Key.decyzja==dec)
                {
                    if (k.Value != null)
                    {
                        pokryte++;
                        ilosc++;
                    }
                    else
                        ilosc++;                     
                }
            }
            coverage = pokryte / ilosc;
            return coverage;
        }
     

        public Dictionary<T, int> fCzestosc<T>(T[] tab)
        {
            Dictionary<T, int> czestosc = new Dictionary<T, int>();
            czestosc.Add(tab[0], 1);
            for (int i = 1; i < tab.Length; i++)
            {
                if (czestosc.ContainsKey(tab[i]))
                    czestosc[tab[i]]++;
                else
                    czestosc.Add(tab[i], 1);
            }
            return czestosc;
        }

        public string[][] fmacierz(Dictionary<ObiektDecyzyjny, string> klasyfikacja,List<string> lista)
        {
            string[][] macierz = new string[fUnkialnosc(fKolumna(systemTestowy, systemTestowy[0].Length - 1)).Length][];
            int j=0;
            List<string> pSort = new List<string>();
            foreach (var decyzje in fUnkialnosc(fKolumna(systemTestowy, systemTestowy[0].Length - 1)))
            {
                pSort.Add(decyzje);
            }
            pSort.Sort();
            foreach (var decyzje in pSort)
            {
                int i = 0;

                string[] pom = new string[fUnkialnosc(fKolumna(systemTestowy, systemTestowy[0].Length - 1)).Length];
                int licznik = 0;
                int licznikR = 0;
                foreach (var klasyf in klasyfikacja)
                {


                    if (decyzje == klasyf.Key.decyzja)
                        if (klasyf.Value == lista.ElementAt(0))
                        {
                            licznik++;

                        }
                        else if (klasyf.Value == lista.ElementAt(1))
                        {
                            licznikR++;

                        }
                }
                pom[i] = Convert.ToString(licznik);
                i++;
                pom[i] = Convert.ToString(licznikR);
                macierz[j] = pom;
                j++;
            }
            return macierz;
            
        }

        public double ftpr(string[] tab, Dictionary<ObiektDecyzyjny, string> klasyfikacja,string dec)
        {
            double suma = 0.0;
            double tpr = 0.0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma += Convert.ToUInt32(tab[i]);
            }
            int licznik = 0;
            int licznikR = 0;
            foreach (var klasyf in klasyfikacja)
            {


                if (dec == klasyf.Key.decyzja)
                    if (klasyf.Value == dec)
                    {
                        licznik++;

                    }
                    
            }
            if (licznik == 0 || suma == 0)
                return 0;
            tpr = licznik / suma;

            return tpr;
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DaneZPliku_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Euklidesa");
            comboBox1.Items.Add("Canberra");
            comboBox1.Items.Add("Czebyszewa");
            comboBox1.Items.Add("Manhattan");
            comboBox1.Items.Add("Pearsona");
            decimal max;
            if (systemTestowy != null || systemTreningowy != null)
            {
                max = maxK(systemTreningowy) + 1;
                numericUpDown1.Maximum = max;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbSystemTreningowy_TextChanged(object sender, EventArgs e)
        {
            decimal max;
            max = maxK(systemTreningowy);
            numericUpDown1.Maximum = max;
        }

        public void wyswietl(Dictionary<ObiektDecyzyjny, string> klasyf)
        {
            wynik.Text += "\r\n";
            int licznikR = 0;
            int licznik = 0;

            double accuracy_wynik = 0;
            double coverage_wynik = 0;
            List<string> pSort = new List<string>();
            List<string> decyzjeKren = new List<string>();
            wynik.Text += "                ";
            foreach (var decyzje in fUnkialnosc(fKolumna(systemTreningowy, systemTreningowy[0].Length - 1)))
            {

                wynik.Text += decyzje + "   ";
                decyzjeKren.Add(decyzje);
            }

            wynik.Text += "No.of obj." + " " + "Accuracy" + " " + "Coverage" + "\r\n";

            foreach (var decyzje in fUnkialnosc(fKolumna(systemTestowy, systemTestowy[0].Length - 1)))
            {
                pSort.Add(decyzje);
            }
            pSort.Sort();
            int i = 0;
            int pierwsze = 0;
            foreach (var decyzje in pSort)
            {
                int ilosc = 0;
                licznik = 0;
                licznikR = 0;
                wynik.Text += decyzje + "              ";
                foreach (var decyzjeKlas in klasyf)
                {
                    //int ilosc = 0;
                    if (decyzje == decyzjeKlas.Key.decyzja)
                        if (decyzjeKlas.Value == decyzjeKren.ElementAt(0))
                        {
                            licznik++;
                            ilosc++;
                        }
                        else if (decyzjeKlas.Value == decyzjeKren.ElementAt(1))
                        {
                            licznikR++;
                            ilosc++;
                        }




                }
                wynik.Text += licznik + "   " + licznikR;

                foreach (var noOfObj in fCzestosc(fKolumna(systemTestowy, systemTestowy[0].Length - 1)))
                {
                    if (noOfObj.Key == decyzje)
                        wynik.Text += "        " + noOfObj.Value;

                }
                accuracy_wynik = accuracy(klasyf, decyzje);
                coverage_wynik = coverage(klasyf, decyzje);
                wynik.Text += "             " + accuracy_wynik + " ";
                wynik.Text += "             " + coverage_wynik + "\r\n";


                wynik.Text += "\r\n";

            }
            wynik.Text += "TPR" + "        " + Math.Round(ftpr(fKolumna(fmacierz(klasyf, decyzjeKren), i), klasyf, pSort[i]), 2) + "  " + Math.Round(ftpr(fKolumna(fmacierz(klasyf, decyzjeKren), i + 1), klasyf, pSort[i + 1]), 2);


        }
        
    }
}
