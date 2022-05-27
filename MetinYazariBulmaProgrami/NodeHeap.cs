using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBulmaProgrami
{
    public class NodeHeap
    {
        public string Data;
        public NodeHeap Left;
        public NodeHeap Right;
        public NodeHeap Parent;
        
        public NodeHeap(string data)
        {
            this.Data = data;
            Left = null;
            Right = null;
        }
    }
}
