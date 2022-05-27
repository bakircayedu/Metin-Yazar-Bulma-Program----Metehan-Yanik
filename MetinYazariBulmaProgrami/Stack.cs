using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBulmaProgrami
{
    public class Stack : StackLLADT
    {
        public int count = 0;
        protected Node Head;

        public override bool IsEmpty()
        {
            return Head == null ? true : false;
        }


        public override string Peek()
        {
            if (Head != null)
            {
                return Head.Data;
            }
            else
            {
                throw new Exception("Stack Boş, Lütfen Stack'e Veri Girişi Yapınız!");
            }
        }

        public override string Pop()
        {
            if (Head == null)
            {
                throw new Exception("Stack Boş, Veri Çıkartılamaz.");
            }
            else
            {
                string tempData = Head.Data;
                Head = Head.Next;
                count--;
                return tempData;
            }
        }

        public override void Push(string item)
        {         
            Node newItem = new Node(item);
            if (item != "")
                {
                    if (Head == null)
                    {
                        newItem.Next = null;
                        Head = newItem;
                    }
                    else
                    {
                        newItem.Next = Head;
                        Head = newItem;
                    }
                    count++;
                }
        }

    }
}

