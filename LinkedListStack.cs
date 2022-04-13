using System;
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
