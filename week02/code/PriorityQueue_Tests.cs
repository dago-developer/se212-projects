using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    public void TestPriorityQueue_Returns_Highest_Priority()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 5);
        pq.Enqueue("C", 3);

        string result = pq.Dequeue();

        Assert.AreEqual("B", result);
    }

    [TestMethod]
    public void TestPriorityQueue_TieBreaker_Returns_FIFO()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("X", 4);
        pq.Enqueue("Y", 4);
        pq.Enqueue("Z", 2);

        string result = pq.Dequeue();

        Assert.AreEqual("X", result);
    }

    [TestMethod]
    public void TestPriorityQueue_EmptyQueue_ThrowsException()
    {
        var pq = new PriorityQueue();

        var ex = Assert.ThrowsException<InvalidOperationException>(() => pq.Dequeue());
        Assert.AreEqual("The queue is empty.", ex.Message);
    }
}
