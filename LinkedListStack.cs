﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class LinkedListStack
    {


        private Node top;

        //Constructor
        public LinkedListStack()
        {
            this.top = null;
        }

        //Push Data to stack
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;

            }
            this.top = node;

            //Display Added Data value
            Console.WriteLine("{0} pushed  to Stack : ", value);
        }

        //Display Data of Top
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty !");
                return;
            }
            Console.WriteLine("{0} is in the top of the Stack : ", this.top.data);
        }

        //Delee data from Top of the Stack
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty, Deletion is not Possible !");
                return;
            }
            Console.WriteLine("Popped value : {0}", this.top.data);
            Console.WriteLine("----------------------------");
            this.top = this.top.next;
        }

        //Deletion till stack Will Empty
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }

        //Display Stack
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine("Stack data : " + temp.data);
                temp = temp.next;
            }
        }
    }
}
