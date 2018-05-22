using BL.Spisok;
using System;
using System.Collections.Generic;

namespace BL
{
/* В списке А хранится информация о людях,(фамилия, имя , отчество, професиия).
 * Имеется список Б, содержащий перечень профессий.
   Удалить из списка А тех людей, чья профессия не указана в списке Б.*/
    public class WorkWSpis
    {
        NodeCharacter Head { get; set; }
        NodeCharacter Tail { get; set; }
        public int count { get; private set; }

        
        public void AddToFIO(string fio, string prof)
        {
            NodeCharacter n = new NodeCharacter(fio, prof);
            if (Head == null)
                Head = n;
            else
                Tail.Next = n;
            Tail = n;

            count++;
        }
        public string[] Printer()
        {
            string[] st = new string[0];
            int L = 0;
            NodeCharacter n = Head;
            if (n != null)
                do
                {
                    Array.Resize(ref st, ++L);
                    st[L - 1] = n.FIO.ToString() + ' ' + n.Prof.ToString();
                    n = n.Next;
                }
                while (n != null);
            return st;
        }
        public void Remove(NodeCharacter current, NodeCharacter previous)
        {
            if (previous != null)
            {
                previous.Next = current.Next;
                if (current.Next == null)
                    Tail = previous;
            }
            else
            {
                Head = Head.Next;

                if (Head == null)
                    Tail = null;
            }
        }
        public void Find(List<string> Prof)
        {
            NodeCharacter current = Head;
            NodeCharacter previous = null;
            while (current != null)
            {
                if (!Prof.Contains(current.Prof))
                {
                    Remove(current, previous);
                }
                previous = current;
                current = current.Next;
            }
        }
    }
}
