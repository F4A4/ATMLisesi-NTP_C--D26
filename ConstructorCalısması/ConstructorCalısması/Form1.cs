using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConstructorCalısması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bisiklet2 bsklt2 = new Bisiklet2(8);

        private void Form1_Load(object sender, EventArgs e)
        {
            MyClass mc = new MyClass("CONSTRUCTOR ÖĞRENİYORUZ");
            Bisiklet bsklt = new Bisiklet();
            bsklt.VitesDegiştir(15);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    class MyClass
    {
        public MyClass(string metin)
        {
                
        }
        
    }
    class Bisiklet
    {
        int Hiz = 0;
        int Vites = 1;
        public void VitesDegiştir(int YeniDeger)
        {
            Vites = YeniDeger;
 
        }
        public void Hizlan(int Artış)
        {
            Hiz += Artış;
        }
        public void FrenYap(int Azalma)
        {
            Hiz-= Azalma;
        }
        public void CevapYaz()
        {
            MessageBox.Show(String.Format("Vites : {0}"+Vites));
            MessageBox.Show(String.Format("Hız : {0}"+Hiz));
        }
    }
    class Bisiklet2
    {
        int hiz = 0;
        int vites = 0;
        int vitesSayisi = 6;
        public Bisiklet2()
        {
            vites = 2;
        }
        public Bisiklet2(int deger)
        {
            vites = 2;
            vitesSayisi = deger;
        }
    }
}
