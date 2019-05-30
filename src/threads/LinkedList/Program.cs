 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    //a linkedlist is made up nodes which are sequentially connected using links
    public class Node
    {
        //our node class will contain 2 data members: a. element that stores the node's data
        //and a link to store reference to next data(address to next node)
        public object Element;
        public Node Next;
        //default constructor that creates an empty Node
        public Node()
        {
            Element = null;
            Next = null;
        }
        //constructor that assigns data to the Element member and sets
        //the Link member to null.
        public Node(object element)
        {
            Element = element;
        }

        public object header { get; set; }
    }
    //used to create linkage for the nodes of our linked list
    public class LinkedList
    {
        //only data member in LinkedList
        public Node header;

        //constructor to instantiate the List
        public LinkedList()
        {
            header = new Node("Header");
        }
        public void AddFront(int data)
        {
            //create a new Node
            Node newNode = new Node();
            if (header == null)
            {
                header = newNode;
                return; 
            }
            //set it's next to the current head
            newNode.Next = header;
            //set current head be the new head
            header = newNode;

        }

        

        private Node Find(Object item)
        {
            Node current = new Node();
            current = header;
            while (current.header != item)
            {
                current = current.Next;
            }
            return current;
        }
        public void Insert(object newItem, object after)
        {
            Node current = new Node();//create a new empty node
            Node newNode = new Node(newItem);//assign data to newNode 
            current = Find(after);//find the next node after newNode
            newNode.Next = current.Next;
            current.Next = newNode;
        }
        //remove a node
        public Node FindPrevious(Object n)
        {
            Node current = header;//start at header
            //if we loop through and find out that the current node link is not null and current node link element is not n
            while (!(current.Next == null) && (current.Next.Element != n))
            {
                current = current.Next;               
            }
            return current;
        }
        public void Remove(Object n)
        {
            Node p = FindPrevious(n);
            if (!(p.Next == null))
            {
                p.Next = p.Next.Next; 
            }
        }
        //PrintList
        public void PrintList()
        {
            Node current = new Node();
            current = header;
            while (!(current.Next == null))
            {
                Console.WriteLine(current.Next.Element);
                current = current.Next;
            }
        }


}
    class Program
    {
        static void Main(string[] args)
        {
            //Generic LinkedList
            LinkedList<string> myList = new LinkedList<string>();
            var Fname = myList.AddLast("Fred");           
            var Lname = myList.AddAfter(Fname, "Kamau");
            var dev = myList.AddLast("C# Guru");
            // To get the count of nodes in LinkedList s
            // before removing all the nodes 
            Console.WriteLine("Total nodes in myList are : " + myList.Count);

            // Displaying the nodes in LinkedList 
            foreach (string i in myList)
            {
                Console.WriteLine(i);
            }
            // Removing the first node from the LinkedList 
            myList.Remove(myList.First);



        }
       
    }
}
