using System;
namespace _12
{
    public class Node<T> where T : IComparable, IEquatable<T>
    {
        public T value;
        public Node<T> prev;
        public Node<T> left;
        public Node<T> mid;
        public Node<T> right;
        public Node(T value)
        {
            this.value = value;
        }
        public void ShowNode()
        {
            if (prev != null)
            {
                Console.WriteLine($"Родитель {prev.ToString()}");
            }
            else
                Console.WriteLine($"Начальный элемент");
            if (left != null)
            {
                Console.WriteLine($"Левый элемент: {left.ToString()}");
            }
            else
                Console.WriteLine($"Левый элемент отсутствует");
            if (right != null)
            {
                Console.WriteLine($"Правый элемент: {right.ToString()}");
            }
            else
                Console.WriteLine($"Правый элемент отсутствует");
            if (mid != null)
            {
                Console.WriteLine($"Центральный элемент: {mid.ToString()}");
            }
            else
                Console.WriteLine($"Центральный элемент отсутствует");

            Console.WriteLine($"Значение узла: {this.ToString()}");
            Console.WriteLine();
        }

        public override string ToString() { return $"{value.ToString()} "; }
    }
    public class TemaryTree<T> where T : IComparable, IEquatable<T>
    {
        public Node<T> startNode;
        private Node<T> Add(Node<T> node, Node<T> prevNode = null)
        {
            if (startNode == null)
            {
                node.prev = null;
                startNode = node;
                return node;
            }
            prevNode = prevNode == null ? startNode : prevNode;
            node.prev = prevNode;
            int res = node.value.CompareTo(prevNode.value);

            if (res > 0)
            {
                return prevNode.right == null
                                     ? (prevNode.right = node)
                                     : Add(node, prevNode.right);
            }
            if (res == 0)
            {
                return prevNode.mid == null
                                     ? (prevNode.mid = node)
                                     : Add(node, prevNode.mid);
            }
            else if (res < 0)
            {
                return prevNode.left == null
                         ? (prevNode.left = node)
                         : Add(node, prevNode.left);
            }
            return prevNode;
        }
        public Node<T> Add(T value)
        {
            return Add(new Node<T>(value));
        }
        private void ShowTree(Node<T> node)
        {
            node.ShowNode();
            if (node.left != null)
            {
                ShowTree(node.left);
            }
            if (node.mid != null)
            {
                ShowTree(node.mid);
            }
            if (node.right != null)
            {
                ShowTree(node.right);
            }
        }
        private void FindElem(Node<T> node, T num)
        {
            if (node.value.CompareTo(num) == 0)
            {
                System.Console.WriteLine("Есть элемент со значением " + num);
                return;
            }
            if (node.left != null)
            {
                FindElem(node.left, num);
            }
            if (node.mid != null)
            {
                FindElem(node.mid, num);
            }
            if (node.right != null)
            {
                FindElem(node.right, num);
            }
        }
        public void FindElem(T num)
        {
            FindElem(startNode, num);
        }
        public void ShowTree()
        {
            ShowTree(startNode);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TemaryTree<int> tree = new TemaryTree<int>();
            tree.Add(15);
            tree.Add(15);
            tree.Add(7);
            tree.Add(10);
            tree.ShowTree();
            System.Console.WriteLine();
            tree.FindElem(10);
        }
    }
}
