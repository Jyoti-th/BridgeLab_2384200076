using System;

class QueueUsingStack
{
    private int[] stack1;
    private int[] stack2;
    private int size;
    private int top1, top2;

    public QueueUsingStack(int size)
    {
        this.size = size;
        stack1 = new int[size];
        stack2 = new int[size];
        top1 = -1; 
        top2 = -1;  
    }

    public void Enqueue(int value)
    {
        if (top1 == size - 1)
        {
            Console.WriteLine("Queue is overflow, Can't Insert more.");
            return;
        }
        stack1[++top1] = value;
        Console.WriteLine("The Value " + value + " is Added.");
        Console.WriteLine("------------------------------------------");
    }

    public void Dequeue()
    {
        if (top2 == -1) // If stack2 is empty, move elements from stack1
        {
            if (top1 == -1)
            {
                Console.WriteLine("Queue is underflow, no elements to remove.");
                return;
            }
            while (top1 >= 0)
            {
                stack2[++top2] = stack1[top1--];
            }
        }

        int deletedValue = stack2[top2--]; 
        Console.WriteLine("Element " + deletedValue + " is deleted.");

        
        Console.WriteLine("--- Elements in Queue ---");
        if (top2 == -1) 
        {
            for (int i = 0; i <= top1; i++)
            {
                Console.Write(stack1[i] + " ");
            }
        }
        else
        {
            for (int i = top2; i >= 0; i--)
            {
                Console.Write(stack2[i] + " ");
            }
        }
        Console.WriteLine("\n------------------------------------------");
    }

}
