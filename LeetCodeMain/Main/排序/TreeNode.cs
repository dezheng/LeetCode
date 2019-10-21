using System;
using System.Collections.Generic;
using System.Text;

namespace Main.排序
{
    public class Node<T>
    {
        public Node(T value)
        {
            Data = value;
            Left = null;
            Right = null;
        }
        public Node()
        {
            Data = default(T);
            Left = null;
            Right = null;
        }
        public Node(T value, Node<T> lChild, Node<T> rChild)
        {
            Data = value;
            Left = lChild;
            Right = rChild;
        }
        public T Data { get; set; }

        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }
    }
    public class LinkBinaryTree<T>
    {
        public Node<T> Root { get; }

        public LinkBinaryTree()
        {
            Root = null;
        }
        public LinkBinaryTree(T value)
        {
            Node<T> p = new Node<T>(value);
            Root = p;
        }
        //三种深度遍历
        //中序遍历 LNR
        public void InOrder(Node<T> node)
        {
            if (Root == null)
                return;
            if (node != null)
            {
                InOrder(node.Left);
                Console.Write(node.Data);
                InOrder(node.Right);
            }
        }
        //先序遍历 NLR
        public void PreOrder(Node<T> node)
        {
            if (Root == null)
                return;
            if (node != null)
            {
                Console.Write(node.Data);
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }
        //后序遍历 LRN
        public void PostOrder(Node<T> node)
        {
            if (Root == null)
                return;
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.Write(node.Data);
            }
        }
        //-------广度遍历----------使用队列
        public void BFS(Node<T> root)
        {
            if (root == null)
                return;
            var queue = new Queue<Node<T>>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                Console.WriteLine(node.Data);
                if (node.Left != null)
                    queue.Enqueue(node.Left);
                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
        }

        //-------深度遍历----------使用栈
        public void DFS(Node<T> root)
        {
            if (root == null)
                return;
            var stack = new Stack<Node<T>>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                Console.WriteLine(node.Data);
                if (node.Right != null)
                    stack.Push(node.Right);
                if (node.Left != null)
                    stack.Push(node.Left);
            }
        }

        public void DFS2(Node<T> root) => DepthTraversal(root);

        private void DepthTraversal(Node<T> root)
        {
            if (root == null) return;
            Console.WriteLine(root.Data);
            DepthTraversal(root.Left);
            DepthTraversal(root.Right);
        }

        public void Mirror(Node<T> root)
        {
            if (root == null)
            {
                return;
            }
            Node<T> temp = root.Left;
            root.Left = root.Right;
            root.Right = temp;
            if (root.Left != null)
            {
                Mirror(root.Left);
            }
            if (root.Right != null)
            {
                Mirror(root.Right);
            }
        }
    }
}
