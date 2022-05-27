using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBulmaProgrami
{
    public class Node
    {
        public Node Next;
        public string Data;
        
        public Node(string data)
        {
            Data = data;
            Next = null;
        }
    }
}
