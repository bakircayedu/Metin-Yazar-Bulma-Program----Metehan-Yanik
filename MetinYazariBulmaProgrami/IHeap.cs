using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBulmaProgrami
{
    public interface IHeap
    {
        void Insert(NodeHeap nodeHeap);
        void AgaciSirala(NodeHeap nodeHeap);
        void PozisyonAyarla();
    }
}
