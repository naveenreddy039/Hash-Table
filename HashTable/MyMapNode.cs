using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class MyMapNode<k, v>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<k, v>>[] items;
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<k, v>>[size];
        }
        protected int GetArrayPosition(k key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public v Get(k key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<k, v>> linkedList = GetLinkedList(position);
            foreach (KeyValue<k, v> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(v);
        }
        public void Add(k key, v value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<k, v>> linkedList = GetLinkedList(position);
            KeyValue<k, v> item = new KeyValue<k, v>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }
        public void Remove(k key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<k, v>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<k, v> foundItem = default(KeyValue<k, v>);
            foreach (KeyValue<k, v> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }

            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }

        protected LinkedList<KeyValue<k, v>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<k, v>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<k, v>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
    }
    public struct KeyValue<k, v>
    {
        public k Key { get; set; }
        public v Value { get; set; }
    }
}
