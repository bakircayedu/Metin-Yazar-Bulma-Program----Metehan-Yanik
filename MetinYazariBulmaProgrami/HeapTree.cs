using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBulmaProgrami
{
    public class HeapTree : IHeap
    {
        public NodeHeap Root;
        public NodeHeap Leaf;
        public Queue<NodeHeap> queue = new Queue<NodeHeap>();
        public HeapTree(NodeHeap kelime)
        {
            Root = kelime;
            Leaf = kelime;
        }

        public HeapTree()
        {

        }

        public void Insert(NodeHeap kelime)
        {
            if (Root == null)
            {
                Root = kelime;
                Root.Parent = null;
                Leaf = Root;
                PozisyonAyarla();
            }
            else if (Leaf.Left == null)
            {
                Leaf.Left = kelime;
                kelime.Parent = Leaf;
                PozisyonAyarla();
                AgaciSirala(kelime);
                return;
            }
            else
            {
                Leaf.Right = kelime;
                kelime.Parent = Leaf;
                PozisyonAyarla();
                AgaciSirala(kelime);
            }
        }
        
        public void PozisyonAyarla()
        {
            
            
            queue.Enqueue(Root);
            queue.Enqueue(Leaf);
        }

        public void AgaciSirala(NodeHeap kelime)
        {
            while (kelime.Parent != null)
            {
                if (string.Compare(kelime.Parent.Data, kelime.Data) == 1)
                {
                    string tempLeaf = kelime.Data;
                    kelime.Data = kelime.Parent.Data;
                    kelime.Parent.Data = tempLeaf;
                    kelime = kelime.Parent;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
