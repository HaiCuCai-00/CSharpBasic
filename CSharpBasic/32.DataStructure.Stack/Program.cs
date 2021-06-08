using System;
using System.Collections.Generic;

namespace _32.DataStructure.Stacks
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
            //Console.WriteLine("Hello, I am in MyStack() contructor");
        }

        public MyStack(int newCapacity)
        {
            data = new int[newCapacity];
            //Console.WriteLine("Hello, I am in MyStack(int capacity) contructor");
        }

        public int Size()
        {
            return top + 1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public void Push(int element)
        {
            if (Size() == data.Length) throw new Exception("Stack is full");
            data[++top] = element;
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

            gun.Push(1);
            gun.Push(2);
            gun.Push(3);
            gun.Push(4);
            gun.Push(5);
            gun.Push(6);

            Console.WriteLine($"Fire: {gun.Pop()}");
            Console.WriteLine($"Fire: {gun.Pop()}");
            Console.WriteLine($"Remain: {gun.Size()}");
            Console.WriteLine($"Fire: {gun.Pop()}");
            Console.WriteLine($"Top bullet: {gun.Top()}");
            Console.WriteLine($"Fire: {gun.Pop()}");
            Console.WriteLine($"Fire: {gun.Pop()}");
            Console.WriteLine($"Fire: {gun.Pop()}");

            Console.ReadLine();
        }
    }
}
