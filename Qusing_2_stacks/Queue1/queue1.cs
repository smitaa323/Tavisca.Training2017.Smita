using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack;
namespace Queue1
{
    public class queue1
    {
        private stack1 stack_inside, stack_outside;
        private int size_of_queue;



        public bool Enqueue(int data)
        {
            if (stack_inside.push(data))
            {
                return true;
            }
            else return false;
        }

        public void Dequeue()
        {
            int i = stack_inside.pop(), temp;
            while (i != int.MaxValue)
            {
                stack_outside.push(i);
                i = stack_inside.pop();
            }
            temp = stack_outside.pop();
            i = stack_outside.pop();
            while (i != int.MaxValue)
            {
                stack_inside.push(i);
                i = stack_outside.pop();
            }

        }

        public void Display()
        {
            stack_inside.display();
        }

        public queue1(int SizeOfQueue)
        {
            stack_inside = new stack1(SizeOfQueue);
            stack_outside = new stack1(SizeOfQueue);
            size_of_queue = SizeOfQueue;
        }
    }
}
