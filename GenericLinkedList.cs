using System;
using System.Collections;

namespace LinkedListProject
{
//testing git ammened changes
//branch testing
//lets test pull
    class GenericLinkedList<T> : CollectionBase
    {
        private class Element<T>
        {
            public T elementValue;
            public Element<T> next;

            public Element(T data, Element<T> next)
            {
                this.elementValue = data;
                this.next = next;
            }
        }

        private Element<T> head { get; set; }
        private int size;
        public int Count { get { return size; } }
        public bool Empty { get { return this.size == 0; } }

        /// <summary>
        /// Method Add inserts new node into linked list on a specific position
        /// </summary>
        public T Add(int index, T o)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            if (index > size)
            {
                index = size;
            }

            Element<T> current = this.head;

            if (this.Empty || index == 0)
            {
                this.head = new Element<T>(o, this.head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.next;
                }
                current.next = new Element<T>(o, current.next);
            }
            size++;
            return o;
        }

        /// <summary>
        /// Method AddAtTail adds new node at the tail of the linked list
        /// </summary>
        public T AddAtTail(T o)
        {
            return this.Add(size, o);
        }

        /// <summary>
        /// Method PrintLinkedList prints all the elements of the defined linked list
        /// </summary>
        public void PrintLinkedList()
        {
            Console.WriteLine("LINKED LIST CONTENT IS:");
            Console.WriteLine();

            Element<T> temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.elementValue);
                temp = temp.next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Method Remove removes element with specified index in linked list
        /// </summary>
        public object Remove(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }
            if (index > size)
            {
                index = size - 1;
            }
            if (this.Empty)
            {
                return null;
            }

            Element<T> current = head;
            object result = null;

            if (index == 0)
            {
                result = current.elementValue;
                head = current.next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.next;
                }

                result = current.next.elementValue;

                current.next = current.next.next;
            }
            size--;
            return result;
        }

        /// <summary>
        /// Method GetElementByValue finds element in linked list with specified value
        /// </summary>
        public bool Contains(T value)
        {
            Element<T> temp = head;
            bool elementFound = false;
            while (!(elementFound = temp.elementValue.Equals(value)) && temp.next != null)
            {
                temp = temp.next;
            }
            return elementFound;
        }

        /// <summary>
        /// Method Get finds element in linked list on specified position and returns it's value if element exists
        /// </summary>
        public object Get(int index)
        {
            //if (index < 0)
            //{
            //    throw new ArgumentOutOfRangeException("Index: " + index);
            //}
            if (this.Empty)
            {
                return null;
            }
                
            if (index >= this.size)
                index = this.size - 1;

            Element<T> current = head;

            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }
            return current.elementValue;
        }

        /// <summary>
        /// Method Clear removes all elements from linked list
        /// </summary>
        public void Clear()
        {
            this.head = null;
        }

        /// <summary>
        /// Method IndexOf finds element with specified value and return it's index
        /// </summary>
        public int IndexOf(T o)
        {
            Element<T> current = this.head;

            for (int i = 0; i < this.size; i++)
            {
                if (current.elementValue.Equals(o))
                {
                    return i;
                }
                current = current.next;
            }
            return -1;
        }

        //Researching possibilites
        public void SpecialAdd(T o)
        {
            InnerList.Add(o);
        }
    }
}
