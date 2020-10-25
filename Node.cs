using System;
using System.Collections.Generic;
using System.Text;

namespace BSTOperations
{
    class Node<T> where T : IComparable
    {
        public T data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node(T data)
        {
            this.data = data;
            Left = null;
            Right = null;
        }
    
    }
}
