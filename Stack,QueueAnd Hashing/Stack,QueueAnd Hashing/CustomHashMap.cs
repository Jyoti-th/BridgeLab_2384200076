using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_QueueAnd_Hashing
{
    class CustomHashMap
    {
        
        class Node
        {
            public int Key;
            public int Value;
            public Node Next;

            public Node(int key, int value)
            {
                Key = key;
                Value = value;
                Next = null;
            }
        }

        private Node[] buckets;
        private int size;

        public CustomHashMap(int capacity)
        {
            size = capacity;
            buckets = new Node[size];
        }

        private int Hash(int key)
        {
            return key % size; // Hash function
        }

        public void Put(int key, int value)
        {
            int index = Hash(key);
            Node head = buckets[index];

            // If key already exists, update it
            Node current = head;
            while (current != null)
            {
                if (current.Key == key)
                {
                    current.Value = value;
                    return;
                }
                current = current.Next;
            }

            // Insert at the beginning of the linked list
            Node newNode = new Node(key, value);
            newNode.Next = head;
            buckets[index] = newNode;
        }

        public int Get(int key)
        {
            int index = Hash(key);
            Node current = buckets[index];

            while (current != null)
            {
                if (current.Key == key)
                    return current.Value;
                current = current.Next;
            }
            return -1; // Key not found
        }

        public void Remove(int key)
        {
            int index = Hash(key);
            Node current = buckets[index];
            Node prev = null;

            while (current != null)
            {
                if (current.Key == key)
                {
                    if (prev == null)
                        buckets[index] = current.Next;
                    else
                        prev.Next = current.Next;
                    return;
                }
                prev = current;
                current = current.Next;
            }
        }

       
    
}
}
