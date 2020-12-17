using System.Collections;
using System.Collections.Generic;

namespace TrainDoublyLL.DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public Node<T> head { get; private set; } //голова списка
        public int size { get; private set; } //размер списка
        public Node<T> tail { get; private set; } //хвост списка


        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
                tail = node;
            }

            size++;
        }

        public void Remove(T data)
        {
            var current = head;
            while (current != null)
            {
                if (current.Data.Equals(data)) break;

                current = current.Next;
            }

            if (current != null)
            {
                if (current.Next != null)
                    current.Next.Previous = current.Previous;
                else
                    tail = current.Previous;
                if (current.Previous != null)
                    current.Previous.Next = current.Next;
                else
                    head = current.Next;
                size--;
            }
        }

        public IEnumerator<T> GetEnumeratorBack()
        {
            var current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
}