using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class stack1
    {
        private int top_of_stack = -1;
        private int[] stack;


        public bool push(int data)
        {
            if (top_of_stack >= stack.Length)
            {
                return false;
            }
            else
            {
                stack[++top_of_stack] = data;
                Console.WriteLine(stack[top_of_stack]);
                return true;
            }

        }
        public int pop()
        {
            if (top_of_stack == -1)
            {
                return int.MaxValue;
            }
            else
            {
                int k = stack[top_of_stack--];
                return k;
            }
        }

        public void display()
        {
            if (top_of_stack != -1)
            {

                for (int i = 0; i < top_of_stack; i++)
                {
                    Console.WriteLine(stack[i]);
                }
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
        public stack1(int SizeOfStack)
        {
            stack = new int[SizeOfStack];
        }
    }
}
