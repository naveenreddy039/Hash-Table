using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(56);
            binaryTree.Add(30);
            binaryTree.Add(70);
            //binaryTree.Add(3);
            //binaryTree.Add(2);

            binaryTree.TraversePreorder(binaryTree.Root);
        }
    }
}
