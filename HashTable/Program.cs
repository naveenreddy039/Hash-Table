using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "Or");
            hash.Add("3", "not");
            hash.Add("4", "To");
            hash.Add("5", "be");

            string hash5 = hash.Get("5");
            Console.WriteLine("The 5th index is:" + hash5);
            string hash0 = hash.Get("0");
            Console.WriteLine("The 0th index is:" + hash0);
            string hash2 = hash.Get("2");
            Console.WriteLine("The 2nd index is:" + hash2);
        }
    }
}
