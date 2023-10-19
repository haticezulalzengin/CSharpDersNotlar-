using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyp_hafta_2
{
    internal class Personel
    {
        public Personel(string gAd, string gAdres, int gYas,int gMesai, string gUnvan)
        {
            this.Ad = gAd;
            this.Adres = gAdres;
            this.Yas = gYas;
            this.Mesai = gMesai;
            this.Unvan = gUnvan;
            //merhaba GitHub
        }
        public Personel(string gAd)
        {
        
        }
        
        int mesai;
        public int Mesai
        { get { return mesai; } 
       }   

        string ad;

        public string Ad { get => ad; set => ad = value; }
       

        string adres;
        public string Adres { get => adres; set => adres = value; }
       

        int yas;
        
        public int Yas { get => yas; set => yas = value; }
        string unvan;
        public string Unvan { get => unvan; set => unvan = value; }

        public int ucretHesapla()
        { 
            return this.Mesai*100;
        }
        public void ucretHesapla(int ekUcret)
        {
            int odenecek = this.mesai * 100 + ekUcret;
            MessageBox.Show(odenecek.ToString());

        }
        

    }
}
