using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BinaryNode<T>
{
    public T Value { get; set; }
    public BinaryNode<T>? LeftChild { get; set; }
    public BinaryNode<T>? RightChild { get; set; }

    // Constructor
    public BinaryNode (T pValue) {
        Value = pValue;
        LeftChild = null;
        RightChild = null;
    }

    public void AddLeft(BinaryNode<T> pNewNode)
    {
        LeftChild = pNewNode;
    }
    
    public void AddRight(BinaryNode<T> pNewNode)
    {
        RightChild = pNewNode;
    }

    public override String ToString()
    {
        return $"{Value}: {((LeftChild is null) ? "null" : LeftChild.Value)} {((RightChild is null) ? "null" : RightChild.Value)}";
    }

}

public class TestBinary
{
    static void Main()
    {
        // Test NaryNode class
        BinaryNode<String> testTree = new BinaryNode<String>("Root");
        BinaryNode<String> nodeA = new BinaryNode<String>("A");
        BinaryNode<String> nodeB = new BinaryNode<String>("B");
        BinaryNode<String> nodeC = new BinaryNode<String>("C");
        BinaryNode<String> nodeD = new BinaryNode<String>("D");
        BinaryNode<String> nodeE = new BinaryNode<String>("E");
        BinaryNode<String> nodeF = new BinaryNode<String>("F");

        testTree.AddLeft(nodeA);
        testTree.AddRight(nodeB);
        nodeA.AddLeft(nodeC);
        nodeA.AddRight(nodeD);
        nodeB.AddRight(nodeE);
        nodeE.AddLeft(nodeF);

        // Use Queue to print node values
        Queue<BinaryNode<String>> prtQueue = new Queue<BinaryNode<String>>();
        prtQueue.Enqueue(testTree);
        while (prtQueue.Count != 0)
        {
            BinaryNode<String> elem = prtQueue.Dequeue();
            Console.WriteLine(elem);
            if (elem.LeftChild is not null)
                prtQueue.Enqueue(elem.LeftChild);
            if (elem.RightChild is not null)
                prtQueue.Enqueue(elem.RightChild);
        }

    }

}

