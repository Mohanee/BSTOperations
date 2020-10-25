﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BSTOperations
{
    class BST<T> where T :IComparable
    {
        public Node<T> root;
        public BST()
        {
            this.root = null;
        }
        public void Insert(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node<T> current = root;
                Node<T> parent;
                while (true)
                {
                    parent = current;
                    if (data.CompareTo(current.data) < 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }

                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public void DisplayBST(Node<T> parent)
        {
            Console.WriteLine("Parent : {0}", parent.data);
            if (parent.Left != null)
            {
                Console.WriteLine("Left :" + parent.Left.data);
            }
            if (parent.Right != null)
            {
                Console.WriteLine("Right :" + parent.Right.data);
            }

            if (parent.Left != null)
            {
                DisplayBST(parent.Left);
            }
            if (parent.Right != null)
            {
                DisplayBST(parent.Right);
            }
        }

        public int Size(Node<T> node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return (Size(node.Left) + 1 + Size(node.Right));
            }
        }

        public void Search(T element)
        {
            Node<T> current = root;
            bool found = false;
            while (current != null)
            {
                if (current.data.Equals(element))
                {
                    found = true;
                    break;
                }
                else
                {
                    if (element.CompareTo(current.data) < 0)
                    {
                        current = current.Left;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
            if (found)
                Console.WriteLine("Element Found");
            else
                Console.WriteLine("Element Not Found");
        }
    }
}
