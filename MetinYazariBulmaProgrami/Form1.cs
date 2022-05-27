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
        //Metehan Yanýk -- Ýzmir Bakýrçay Üniversitesi -- Bilgisayar Mühendisliði
        public Form1()
        {
            InitializeComponent();
        }

        Stack CumleStack = new Stack();
        Stack KelimeStack = new Stack();
        HeapTree Heap = new HeapTree();
        public string Metin;
         
        
        //Programýmýzýn analiz etmesini istediðimiz .txt uzantýlý dosyamýzý yüklememizi saðlayacak kod bloðu
        //Sebebini çözemediðim bir sebepten ötürü 2 kere dosya seçmenizi istiyor, ileride düzelteceðim.
        private void metinYukleBtn_Click(object sender, EventArgs e)
        {          
            OpenFileDialog metinTxt = new OpenFileDialog();
            metinTxt.Filter = "txt files (*.txt)|*.txt";
            metinTxt.FilterIndex = 1;
            metinTxt.Title = ".txt Uzantýlý Dosyasý Seçiniz !";
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
        
        //Bu kýsýmda programýmýzýn bir çok deðiþkenini barýndýrýyoruz ve oluþturuyoruz. Bunlarý ekranýmýzda gerekli yerlere yansýtýyoruz ve bilgilere ulaþabiliyoruz.
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
                    KelimeInfo = "\n " + "# " + kelime.Kelime + " Kelimesi " + (i + 1) + ". Cümlede ve " + "Cümledeki Sýrasý --> " + KelimeSirasi + "\n";
                    lwKelimeInfo.Items.Add(KelimeInfo);
                    KelimeSirasi++;
                }
                CumleNo++;
                CumleInfoTxt.Text += (i + 1) + ". Cümlede Bulunan Kelime Sayýsý --> " + KelimeSayisi + "\n";
            }
            ToplamCumle = CumleDizisi.Length + 1;

            CumleInfoTxt.Text += "Metinde Toplam " + ToplamCumle + " Cümle ve " + MetindekiKelimeSayisi + " Kelime Bulunmaktadýr.";
            
        }

        //Aðaca aktarma iþlemimizi gerçekleþtiriyoruz. Kelimelerimizi aðaç düðümlerimize aktarýp, düðümlerimizi de aðaca aktarýyoruz.
        private void agacaAktarBtn_Click(object sender, EventArgs e)
        {
            while (KelimeStack.IsEmpty() == false)
            {
                NodeHeap Nheap = new NodeHeap(KelimeStack.Pop());
                Heap.Insert(Nheap);  
            }
            MessageBox.Show("Aðaca Aktarým Baþarýlý");
        }

        //Bu kýsýmda butona basýldýktan sonra kelimelerden oluþan dizimizi oluþturup uzunluðu kadar hash tablosu açýyoruz ve hash tablomuza aðacýmýzda ki düðümlerimizi atýyoruz.
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
            MessageBox.Show("Hash Tablosu Baþarýyla Oluþturuldu");
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