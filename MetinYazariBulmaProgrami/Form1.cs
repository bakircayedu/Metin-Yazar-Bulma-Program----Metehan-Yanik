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
namespace MetinYazariBulmaProgrami
{
    public partial class Form1 : Form
    {
        //Metehan Yan�k -- �zmir Bak�r�ay �niversitesi -- Bilgisayar M�hendisli�i
        public Form1()
        {
            InitializeComponent();
        }

        Stack CumleStack = new Stack();
        Stack KelimeStack = new Stack();
        HeapTree Heap = new HeapTree();
        public string Metin;
         
        
        //Program�m�z�n analiz etmesini istedi�imiz .txt uzant�l� dosyam�z� y�klememizi sa�layacak kod blo�u
        //Sebebini ��zemedi�im bir sebepten �t�r� 2 kere dosya se�menizi istiyor, ileride d�zeltece�im.
        private void metinYukleBtn_Click(object sender, EventArgs e)
        {          
            OpenFileDialog metinTxt = new OpenFileDialog();
            metinTxt.Filter = "txt files (*.txt)|*.txt";
            metinTxt.FilterIndex = 1;
            metinTxt.Title = ".txt Uzant�l� Dosyas� Se�iniz !";
            metinTxt.ShowDialog();

            if (metinTxt.ShowDialog() == DialogResult.OK)
            {
                string fileName = metinTxt.FileName;
                string filePath = Path.GetFullPath(fileName);
                filePathText.Text = fileName;


                var metinDosyasi = metinTxt.OpenFile();
                StreamReader streamReader = new StreamReader(metinDosyasi);
                string cumle;
                cumle = streamReader.ReadToEnd();
                MetinTxtBox.Text = cumle;
                Metin = cumle;
                
            }
        }
        
        //Bu k�s�mda program�m�z�n bir �ok de�i�kenini bar�nd�r�yoruz ve olu�turuyoruz. Bunlar� ekran�m�zda gerekli yerlere yans�t�yoruz ve bilgilere ula�abiliyoruz.
        private void stackOkuBtn_Click(object sender, EventArgs e)
        {
           string[] CumleDizisi = MetinTxtBox.Text.Split('\n');
           string[] KelimeDizisi = new string[CumleDizisi.Length];
           int ToplamCumle = 0;
           int KelimeSayisi = 0;
           int CumleNo = 0;
           int MetindekiKelimeSayisi = 0;
           string KelimeInfo = "";
           
           CumleInfoTxt.ResetText();
           
            for (int i = 0; i < CumleDizisi.Length; i++)
            {
                CumleDizisi[i].ToLower();
                CumleStack.Push(CumleDizisi[i]);
                KelimeSayisi = CumleDizisi[i].Split(' ').Length;
                KelimeDizisi = CumleDizisi[i].Split(' ');
                MetindekiKelimeSayisi += KelimeSayisi;
                int KelimeSirasi = 1;
                foreach (string item in KelimeDizisi)
                {
                    Kelimeler kelime = new Kelimeler(item, KelimeSirasi, i);
                    KelimeStack.Push(kelime.Kelime);
                    KelimeInfo = "\n " + "# " + kelime.Kelime + " Kelimesi " + (i + 1) + ". C�mlede ve " + "C�mledeki S�ras� --> " + KelimeSirasi + "\n";
                    lwKelimeInfo.Items.Add(KelimeInfo);
                    KelimeSirasi++;
                }
                CumleNo++;
                CumleInfoTxt.Text += (i + 1) + ". C�mlede Bulunan Kelime Say�s� --> " + KelimeSayisi + "\n";
            }
            ToplamCumle = CumleDizisi.Length + 1;

            CumleInfoTxt.Text += "Metinde Toplam " + ToplamCumle + " C�mle ve " + MetindekiKelimeSayisi + " Kelime Bulunmaktad�r.";
            
        }

        //A�aca aktarma i�lemimizi ger�ekle�tiriyoruz. Kelimelerimizi a�a� d���mlerimize aktar�p, d���mlerimizi de a�aca aktar�yoruz.
        private void agacaAktarBtn_Click(object sender, EventArgs e)
        {
            while (KelimeStack.IsEmpty() == false)
            {
                NodeHeap Nheap = new NodeHeap(KelimeStack.Pop());
                Heap.Insert(Nheap);  
            }
            MessageBox.Show("A�aca Aktar�m Ba�ar�l�");
        }

        //Bu k�s�mda butona bas�ld�ktan sonra kelimelerden olu�an dizimizi olu�turup uzunlu�u kadar hash tablosu a��yoruz ve hash tablomuza a�ac�m�zda ki d���mlerimizi at�yoruz.
        private void hashTableBtn_Click(object sender, EventArgs e)
        {
            string[] HashKelimeler = Metin.Split(' ');
            HashMap hashMap = new HashMap(HashKelimeler.Length);
            int i = 0;        
            foreach (string item in HashKelimeler)
            {
                hashMap.Add(HashKelimeler[i], Heap.queue.Dequeue());      
                i++;
            }
            MessageBox.Show("Hash Tablosu Ba�ar�yla Olu�turuldu");
        }

        private void tumKelimeleriGoruntuleBtn_Click(object sender, EventArgs e)
        {
            string[] TumKelimeler = Metin.Split(' ');
            int k = 0;
            foreach (string item in TumKelimeler)
            {
                tumKelimelerTxt.Text += TumKelimeler[k] + " " + "\n";
                k++;
            }
        }
    }
}