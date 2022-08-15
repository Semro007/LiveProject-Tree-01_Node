using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NaryNode<T>
{
    public T Value { get; set; }
    public List<NaryNode<T>>? Children { get; set; }

    // Constructor
    public NaryNode (T pValue) {
        Value = pValue;
        Children = new List<NaryNode<T>>();
    }

    public void AddChild(NaryNode<T> pNewNode)
    {
        Children.Add(pNewNode);
    }
    
    public override String ToString()
    {
        String retValue = $"{Value}:";
        foreach (NaryNode<T> child in Children)
            retValue += $" {child.Value}";
        return retValue;
    }

}

public class TestNary
{
    static void Main()
    {
        // Test NaryNode class
        NaryNode<String> testTree = new NaryNode<String>("Root");
        NaryNode<String> nodeA = new NaryNode<String>("A");
        NaryNode<String> nodeB = new NaryNode<String>("B");
        NaryNode<String> nodeC = new NaryNode<String>("C");
        NaryNode<String> nodeD = new NaryNode<String>("D");
        NaryNode<String> nodeE = new NaryNode<String>("E");
        NaryNode<String> nodeF = new NaryNode<String>("F");
        NaryNode<String> nodeG = new NaryNode<String>("G");
        NaryNode<String> nodeH = new NaryNode<String>("H");
        NaryNode<String> nodeI = new NaryNode<String>("I");

        testTree.AddChild(nodeA);
        testTree.AddChild(nodeB);
        testTree.AddChild(nodeC);
        nodeA.AddChild(nodeD);
        nodeA.AddChild(nodeE);
        nodeC.AddChild(nodeF);
        nodeD.AddChild(nodeG);
        nodeF.AddChild(nodeH);
        nodeF.AddChild(nodeI);

        // Use Queue to print node values
        Queue<NaryNode<String>> prtQueue = new Queue<NaryNode<String>>();
        prtQueue.Enqueue(testTree);
        while (prtQueue.Count != 0)
        {
            NaryNode<String> elem = prtQueue.Dequeue();
            Console.WriteLine(elem);
            foreach (NaryNode<String> child in elem.Children)
                prtQueue.Enqueue(child);
        }

    }

}

