using System;

namespace WiredBrainCoffee.StackApp;

class Program
{
    static void Main(string[] args)
    {
        var stack = new SimpleStack();
        stack.Push(1.2);
        stack.Push(3.5);
        stack.Push(4.8);
        stack.Push(1.9);

    }
}