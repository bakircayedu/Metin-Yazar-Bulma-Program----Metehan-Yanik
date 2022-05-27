using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBulmaProgrami
{
    public class HashLL
    {
        public string Key { get; set; }
        public NodeHeap Data;
        public HashLL Next;
        public HashLL(string key , NodeHeap Data)
        {
            this.Key = key;
            this.Data = Data;
            this.Next = null;
        }
    }
}
