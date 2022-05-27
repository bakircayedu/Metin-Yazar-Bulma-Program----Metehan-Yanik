using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBulmaProgrami
{
    public abstract class StackLLADT
    {
        public abstract bool IsEmpty();
        public abstract void Push(string item);
        public abstract string Peek();
        public abstract string Pop();
                
    } 
}
