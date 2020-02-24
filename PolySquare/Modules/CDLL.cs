using System;

namespace CDLL
{
    // Тип данных: Циклический двусвязный список
    class CDLL<T>
    {
        private CDLL<T> prev, next;     // Не NULL кроме удаленных!
        public T val;

        // Новый список - один элемент завязанный на себя
        public CDLL(T val)
        {
            this.val = val; next = prev = this;
        }

        public CDLL<T> Prev
        {
            get { return prev; }
        }

        public CDLL<T> Next
        {
            get { return next; }
        }

        // Удаление: сделать так чтобы элемент указывал вникуда
        public void Delete()
        {
            next.prev = prev; prev.next = next;
            next = prev = null;
        }

        public CDLL<T> Prepend(CDLL<T> elt)
        {
            elt.next = this; elt.prev = prev; prev.next = elt; prev = elt;
            return elt;
        }

        public CDLL<T> Append(CDLL<T> elt)
        {
            elt.prev = this; elt.next = next; next.prev = elt; next = elt;
            return elt;
        }

        public int Size()
        {
            int count = 0;
            CDLL<T> node = this;
            do
            {
                count++;
                try
                {
                    node = node.next;
                }
                catch
                {
                    return 0;
                }
            } while (node != this);
            return count;
        }

        public void PrintFwd()
        {
            CDLL<T> node = this;
            do
            {
                Console.WriteLine(node.val);
                node = node.next;
            } while (node != this);
            Console.WriteLine();
        }

        public void CopyInto(T[] vals, int i)
        {
            CDLL<T> node = this;
            do
            {
                try
                {
                    vals[i++] = node.val;
                    node = node.next;
                }
                catch
                {
                    return;
                }
            } while (node != this);
        }
    }
}
