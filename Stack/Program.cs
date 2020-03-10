using System;

namespace Stack
{
    class StackDemo {
        private int[] s;
        private int top = -1;
        private int max = 0;

        public StackDemo(int max)
        {
            this.max = max;
            s = new int[max];
        }

        public void Push(int ele)
        {
            if (top == max - 1) Console.WriteLine("Stack Overflow");
            else
            {
                top++;
                s[top] = ele;
            }
        }

        public Boolean empty()
        {
            if (top == -1) return true;
            else return false;
        }

        public void Pop()
        {
            if (empty()) Console.WriteLine("Stack Underflow");
            else
            {
                int z = s[top];
                top--;
                Console.WriteLine("Deleted element:-" + z);
            }
        }

        public void Display()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.Write(s[i]+"");
                Console.WriteLine();
            }
        }

        public Boolean Serch(int ele)
        {
            Boolean result = false;
            for (int i = 0; i <= top; i++)
            {
                if (ele == s[i])
                {
                    result=true;
                }
                else result=false;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the capacity of stack");
            int k = Convert.ToInt32(Console.ReadLine());
            StackDemo obj = new StackDemo(k);
            while (true)
            {
                Console.WriteLine("Enter the choice");
                Console.WriteLine("1:PUSH 2:POP 3:DISPLAY 4:SEARCH 5:Exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the element to push");
                        int ele = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            obj.Push(ele);
                        }
                        catch (Exception ex) { Console.WriteLine("Error:-" + ex); }
                        break;
                    case 2:
                        try
                        {
                            obj.Pop();
                        }
                        catch (Exception ex) { Console.WriteLine("Error:-" + ex); }
                        break;
                    case 3:
                        try
                        {
                            if (obj.empty() == true) Console.WriteLine("Stack Empty");
                            else obj.Display();

                        }
                        catch (Exception ex) { Console.WriteLine("Error:-" + ex); }
                        break;
                    case 4:
                        Console.WriteLine("Enter the element to Search");
                        int searchEle = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            if (obj.Serch(searchEle)) Console.WriteLine(searchEle + " present in stack");
                            else Console.WriteLine(searchEle + " not present in stack");
                        }
                        catch (Exception ex) { Console.WriteLine("Error:-" + ex); }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
