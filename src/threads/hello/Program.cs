﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;

    }
    
    class Tree : Node
    {
        public Node insert(Node root, int v)
        {
            if (root == null)
            {
                root = new Node();
                root.value = v;
            }
            else if (v < root.value)
            {
                root.left = insert(root.left, v);
            }
            else if(v > root.value)
            {
                root.right = insert(root.right, v);
            }
            return root;
          
        }
        public void traverse(Node root)
        {
            if (root == null)
            {
                return;
            }
            traverse(root.left);
            traverse(root.right);
        }
      

    }
  
    class Program
    {
        static void Main(string[] args)
        {
         

        }
    }
}
