using System;

namespace Unit1
{
    class Stack
    {
        private string[] stack = new string[8];
        private int top;
        private int max;

        public Stack(int size)
        {
            stack = new string[size];
            top = -1;
            max = size;
        }

        //Push method for inserting 
        public void push(string item)
        {
            if (top == max - 1)
            {
                return;
            }
            else
            {
                stack[++top] = item;
            }
        }

        //Pop method for removing an element
        public int pop()
        {
            if (top == -1)
            {
                return -1;
            }
            else
            {
                return top--;
            }
        }

        //Print method for printing the size of the stack
        public void Size()
        {
            Console.Write("\n" + "The size of the stack is: ");
            Console.WriteLine(stack.Length);
        }

        //Display method for printing each item in the stack
        public void Print()
        {
            Console.Write("The Items in the stack are: ");
            foreach (string item in stack)
                Console.Write(item + ", ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Create an array-based data structure for the stack
            Stack Things = new Stack(8);

            //Display the size of the stack
            Things.Size();

            //Display the elements in the stack
            Things.Print();

            //Store all of the elements on the stack using the push method
            Things.push("LCD");
            Things.push("LED");
            Things.push("Mobile");
            Things.push("Charger");
            Things.push("Speaker");
            Things.push("Mouse");
            Things.push("Keyboard");
            Things.push("Laptop");

            //Extract the top three elements
            Things.pop();
            Things.pop();
            Things.pop();

            //Display the size of the stack
            Things.Size();

            //Display all of the elements that are stored on the stack
            Things.Print();
        }
    }
}
