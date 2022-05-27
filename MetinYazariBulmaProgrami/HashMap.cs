using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBulmaProgrami
{
    public class HashMap
    {
        public HashLL[] Table;
        public int TableSize;

        public HashMap(int TableSize)
        {
            this.TableSize = TableSize;
            Table = new HashLL[TableSize];
            for (int i = 0; i < TableSize; i++)
            {
                Table[i] = null;
            }
        }

        public object Search(string Key)
        {
            int Hash = HashKey(Key) % this.TableSize;
            if (Table[Hash] != null)
            {
                HashLL HeapNode = this.Table[Hash];
                while (HeapNode.Next != null)
                {
                    if (HeapNode.Key == Key)
                    {
                        break;
                    }
                    HeapNode = HeapNode.Next;
                }
                return HeapNode.Data;
            }
            else
            {
                return null;
            }
        }

        public void Add(string Key , NodeHeap Data)
        {
            int Hash = HashKey(Key) % this.TableSize;
            if (Table[Hash] != null)
            {
                HashLL HeapNode = Table[Hash];
                while (HeapNode.Next != null)
                {
                    HeapNode = HeapNode.Next;
                }
                HeapNode.Next = new HashLL(Key, Data);
            }
            else
            {
                Table[Hash] = new HashLL(Key, Data);
            }
        }

        public int HashKey(string Key)
        {
            int hKey = 0;
            for (int i = 0; i < Key.Length; i++)
            {
                hKey += Key[i];
            }
            return hKey;
        }

    }
}
