using System;
using System.Collections.Generic;
namespace _12
{
    class TemaryTree<T>
    {
        private TemaryTree<T> root;
        private T val;
        private List<TemaryTree<T>> children;

        private TemaryTree(ref TemaryTree<T> root, T val)
        {
            this.root = root;
            this.val = val;
            this.children = new List<TemaryTree<T>>(3);
        }
        public TemaryTree(T val)
        {
            this.root = null;
            this.val = val;
            this.children = new List<TemaryTree<T>>(3);
        }
        public void Add(T val)
        {
            if (val > this.val)
            {
                this.children[2] = new TemaryTree<T>();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TemaryTree<int> tree = new TemaryTree<int>(10);
            tree.Add(15);
        }
    }
}
