using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBulmaProgrami
{
    public class Kelimeler
    {
        public string Kelime { get; set; }
        public int KelimeTekrari { get; set; }
        public int KelimeSirasi { get; set; }
        public int KelimeninCumlesi { get; set; }

        public Kelimeler(string Kelime, int KelimeSirasi, int KelimeninBulunduguCumle)
        {
            this.Kelime = Kelime;
            this.KelimeSirasi = KelimeSirasi;
            this.KelimeninCumlesi = KelimeninBulunduguCumle+1;
        }
        public Kelimeler()
        {
            
        }
    }
}
