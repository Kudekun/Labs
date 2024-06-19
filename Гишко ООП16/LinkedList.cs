using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList<T>
{
    private Node<T> head;

    public LinkedList()
    {
        head = null;
    }

    public void AddFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);
        newNode.Next = head;
        head = newNode;
    }

    public void AddLast(T data)
    {
        if (head == null)
        {
            head = new Node<T>(data);
            return;
        }

        Node<T> current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = new Node<T>(data);
    }

    public void RemoveFirst()
    {
        if (head != null)
        {
            head = head.Next;
        }
    }

    public void RemoveLast()
    {
        if (head == null) 
            return;

        if (head.Next == null)
        {
            head = null;
            return;
        }

        Node<T> current = head;
        while (current.Next.Next != null)
        {
            current = current.Next;
        }

        current.Next = null;
    }

    public void Clear()
    {
        head = null;
    }

    public bool IsNull()
    {
        return head == null;
    }

    public override string ToString()
    {
        string res = string.Empty;

        Node<T> current = head;
        while (current != null)
        {
            res += current.Data + ", ";
            current = current.Next;
        }

        return res;
    }
}