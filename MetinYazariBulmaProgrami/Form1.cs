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
        //Metehan Yanık -- İzmir Bakırçay Üniversitesi -- Bilgisayar Mühendisliği
        public Form1()
        {
            InitializeComponent();
        }

        Stack CumleStack = new Stack();
        Stack KelimeStack = new Stack();
        HeapTree Heap = new HeapTree();
        public string Metin;
         
        
        //Programımızın analiz etmesini istediğimiz .txt uzantılı dosyamızı yüklememizi sağlayacak kod bloğu
        //Sebebini çözemediğim bir sebepten ötürü 2 kere dosya seçmenizi istiyor, ileride düzelteceğim.
        private void metinYukleBtn_Click(object sender, EventArgs e)
        {          
            OpenFileDialog metinTxt = new OpenFileDialog();
            metinTxt.Filter = "txt files (*.txt)|*.txt";
            metinTxt.FilterIndex = 1;
            metinTxt.Title = ".txt Uzantılı Dosyası Seçiniz !";
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
        
        //Bu kısımda programımızın bir çok değişkenini barındırıyoruz ve oluşturuyoruz. Bunları ekranımızda gerekli yerlere yansıtıyoruz ve bilgilere ulaşabiliyoruz.
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
                    KelimeInfo = "\n " + "# " + kelime.Kelime + " Kelimesi " + (i + 1) + ". Cümlede ve " + "Cümledeki Sırası --> " + KelimeSirasi + "\n";
                    lwKelimeInfo.Items.Add(KelimeInfo);
                    KelimeSirasi++;
                }
                CumleNo++;
                CumleInfoTxt.Text += (i + 1) + ". Cümlede Bulunan Kelime Sayısı --> " + KelimeSayisi + "\n";
            }
            ToplamCumle = CumleDizisi.Length + 1;

            CumleInfoTxt.Text += "Metinde Toplam " + ToplamCumle + " Cümle ve " + MetindekiKelimeSayisi + " Kelime Bulunmaktadır.";
            
        }

        //Ağaca aktarma işlemimizi gerçekleştiriyoruz. Kelimelerimizi ağaç düğümlerimize aktarıp, düğümlerimizi de ağaca aktarıyoruz.
        private void agacaAktarBtn_Click(object sender, EventArgs e)
        {
            while (KelimeStack.IsEmpty() == false)
            {
                NodeHeap Nheap = new NodeHeap(KelimeStack.Pop());
                Heap.Insert(Nheap);  
            }
            MessageBox.Show("Ağaca Aktarım Başarılı");
        }

        //Bu kısımda butona basıldıktan sonra kelimelerden oluşan dizimizi oluşturup uzunluğu kadar hash tablosu açıyoruz ve hash tablomuza ağacımızda ki düğümlerimizi atıyoruz.
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
            MessageBox.Show("Hash Tablosu Başarıyla Oluşturuldu");
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