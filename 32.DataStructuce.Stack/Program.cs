using System;

namespace _32.DataStructuce.Stack
{
    class MyStack
    {
        //field
        private int capacity = 1000;
        private int[] data;
        private int top = -1;

        //constructor
        public MyStack()
        {
            data = new int[capacity];
            Console.WriteLine("Hello, I am in MyStack() contructor");
        }
        public MyStack(int newCapacity)
        {
            data = new int[newCapacity];
            Console.WriteLine("Hello, I am MyStack(int capacity) contructor");
        }
        public int Size()
        {
            return top + 1;
        }
        public bool IsEmpty()
        {
            return top == -1;
        }
        public void push(int element)
        {
            if (Size() == data.Length) throw new Exception("Stacl is full");
            data[++top] = element;

            //top = top +1;
            //data[top] = element;

            //data[top++] = element; ==// data[top] = element;
        }
        public int Top()
        {
            if (IsEmpty()) throw new Exception("Stack is Empty");
            return data[top];
        }
        public int Pop()
        {
            if (IsEmpty()) throw new Exception("Stack is Empty");
            int answer = data[top];
            top--;
            return answer;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStack gun = new MyStack(6);

            gun.push(1);
            gun.push(2);
            gun.push(3);
            gun.push(4);
            gun.push(5);
            gun.push(6);

            Console.WriteLine($"Fire: {gun.Pop()}");
            Console.WriteLine($"Fire: {gun.Pop()}");
            Console.WriteLine($"Remain: {gun.Size()}");
            Console.WriteLine($"Fire: {gun.Pop()}");
            Console.WriteLine($"Fire: {gun.Pop()}");
            Console.WriteLine($"Top bullet: {gun.Top()}");
            Console.WriteLine($"Fire: {gun.Pop()}");
            Console.WriteLine($"Fire: {gun.Pop()}");


        }
    }
}
