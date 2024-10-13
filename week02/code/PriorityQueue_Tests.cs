using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: enqueue 3 different items with different priorities: 1st ouran (1), 2nd Ultraman (3), and 3rd Horimita (2)
    // this test makes sure the items are dequeued in order of their priority
    // Expected Result: Order based on priority: Ultraman, Horimiya, and Ouran
    // Defect(s) Found: expected Horimya but Ultraman dequeue instead
     public void EnqueueDequeue_ReturnsItemsInPriorityOrder()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Ouran", 1);
        queue.Enqueue("Ultraman", 3);
        queue.Enqueue("Horimiya", 2);

        Assert.AreEqual("Ultraman", queue.Dequeue());
        Assert.AreEqual("Horimiya", queue.Dequeue());
        Assert.AreEqual("Ouran", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue the items with the same priority (3), chech if FIFO is used in PriorityQueue
    // Expected Result: FIFO: Ouran, Ultraman, Horimiya
    // Defect(s) Found: expected Ouran but it was Ultraman that was dequeued instead
    public void Dequeue_WithEqualPriority_ReturnsItemsInFIFOOrder()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Ouran", 3);
        queue.Enqueue("Ultraman", 3);
        queue.Enqueue("Horimiya", 3);

        Assert.AreEqual("Ouran", queue.Dequeue());
        Assert.AreEqual("Ultraman", queue.Dequeue());
        Assert.AreEqual("Horimiya", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: Test that the queue throws InvalidOperationException when attempting to dequeue from an empty queue
    // Expected Result: The queue should throw an InvalidOperationException when Dequeue() is called on an empty queue
    // Defect(s) Found: No errors
    [ExpectedException(typeof(InvalidOperationException))]
    public void Dequeue_ThrowsExceptionWhenEmpty()
    {
        var queue = new PriorityQueue();
        queue.Dequeue(); //
    }

    [TestMethod]
    // Scenario: Enqueue itemes and dequeue all of them then add a new item
    // Expected Result: The added item should be dequeue correctly
    // Defect(s) Found: expected Horimiya but Ultraman was dequeued instead 
    public void EnqueueAfterDequeue_HandlesNewItems()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Ouran", 1);
        queue.Enqueue("Ultraman", 3);
        queue.Dequeue();
        queue.Dequeue();

        queue.Enqueue("Horimiya", 2);

        Assert.AreEqual("Horimiya", queue.Dequeue());
    }
}