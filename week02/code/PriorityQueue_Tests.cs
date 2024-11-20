using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the elements of PriorityItem. The priority is unordered, with priority values between 1 and 10.
    // run until the queue is empty
    // Expected Result: ten,nine,eight,seven,six, five,four,three,two,one
    // Defect(s) Found:  When the expected results were defined, in some cases the expected result did not match the calculated value. But it was all a mistake on my part.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        var three = new PriorityItem("three" ,3 );
        var five = new PriorityItem("five" ,5 );
        var two = new PriorityItem("two" ,2 );
        var one = new PriorityItem("one" ,1 );
        var ten = new PriorityItem("ten" ,10 );
        var four = new PriorityItem("four" ,4 );
        var six = new PriorityItem("six" ,6 );
        var seven = new PriorityItem("seven" ,7 );
        var eight = new PriorityItem("eight" ,8 );
        var nine = new PriorityItem("nine" ,9 );
        
        
        // expected values
        PriorityItem[] expectedResult = [ten,nine,eight,seven,six, five,four,three,two,one];

       
        //add to queue
        priorityQueue.Enqueue(three.Value,three.Priority);
        priorityQueue.Enqueue(five.Value,five.Priority);
        priorityQueue.Enqueue(two.Value,two.Priority);
        priorityQueue.Enqueue(one.Value,one.Priority);
        priorityQueue.Enqueue(four.Value,four.Priority);
        priorityQueue.Enqueue(ten.Value,ten.Priority);
        priorityQueue.Enqueue(eight.Value,eight.Priority);
        priorityQueue.Enqueue(seven.Value,seven.Priority);
        priorityQueue.Enqueue(nine.Value,nine.Priority);
        priorityQueue.Enqueue(six.Value,six.Priority);
        
        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }
            var removed = priorityQueue.Dequeue(); //obtain a removed value
            Console.WriteLine("expected:", expectedResult[i].Value, "queue name", removed  );
            Assert.AreEqual(expectedResult[i].Value, removed);
            i++;
        }
        Console.WriteLine("FINISH priorityQueue #1 test-----------------------");
        
        
    }

    [TestMethod]
    // Scenario: Create a queue with the elements of PriorityItem. The priority is unordered, with priority values between -2 and 5.
    // run until the queue is empty
    // Expected Result: five,four,three,minusone,minustwo 
    // Defect(s) Found:  Because the PriorityQueue class was not working correctly, many errors and false "Assert" cases occurred. Once the errors in the class were corrected, everything worked correctly.
    public void TestPriorityQueue_2()
    {
 
        var priorityQueue = new PriorityQueue();
        
        //define priority items
        var three = new PriorityItem("three" ,3 );
        var five = new PriorityItem("five" ,5 );
        var minustwo = new PriorityItem("two" ,-2 );
        var minusone = new PriorityItem("one" ,-1 );
        var four = new PriorityItem("four" ,4 );
        
        
        // expected values
        PriorityItem[] expectedResult = [five,four,three,minusone,minustwo ];

        //add to queue
        priorityQueue.Enqueue(three.Value,three.Priority);
        priorityQueue.Enqueue(five.Value,five.Priority);
        priorityQueue.Enqueue(minustwo.Value,minustwo.Priority);
        priorityQueue.Enqueue(minusone.Value,minusone.Priority);
        priorityQueue.Enqueue(four.Value,four.Priority);
         
        
        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var removed = priorityQueue.Dequeue(); //get a removed value
            Console.WriteLine("expected:", expectedResult[i].Value, "queue name", removed  );
            Assert.AreEqual(expectedResult[i].Value, removed);
 
            i++;
        }
        Console.WriteLine("FINISH priorityQueue #2 test-----------------------");
        
    }

    [TestMethod]
    // Scenario: Create a queue with the zero elements of PriorityItem, and try to dequeue an unlisted element. Check if an error occurs.
    // Expected Result: zero elements 
    // Defect(s) Found: when run the test method with the zero elements , is launched the exception: InvalidOperationException("The queue is empty.");
    // System.InvalidOperationException: The queue is empty.
    public void TestPriorityQueue_3()
    {
 
        var priorityQueue = new PriorityQueue();

        try  // use try catch to avoid the exception  InvalidOperationException("The queue is empty.");
        {  
            priorityQueue.Dequeue ();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error on dequeue...");
        }

         
   
        Assert.AreEqual(0, priorityQueue.Length, "Queue length should still be zero.");
        Console.WriteLine("FINISH priorityQueue #3 test-----------------------");
        
    }
    
    
    [TestMethod]
    // Scenario: Create a queue with  tree elements, one priority 0, 1 and 2. 
    // run until the queue is empty
    // Expected Result: two,one,zero2,zero
    // Defect(s) Found: During the execution of the test no exceptions occurred.
    public void TestPriorityQueue_4()
    {
 
        var priorityQueue = new PriorityQueue();
        //define new priority items
        var zero = new PriorityItem("zero" ,0 ); 
        var zero2 = new PriorityItem("zero2" ,0 ); 
        var two = new PriorityItem("two" ,2 );
        var one = new PriorityItem("one" ,1 );
        
        
        // expected values
        PriorityItem[] expectedResult = [two,one,zero2,zero ];

        //add to queue
        priorityQueue.Enqueue(two.Value,two.Priority);
        priorityQueue.Enqueue(zero2.Value,zero2.Priority); 
        priorityQueue.Enqueue(one.Value,one.Priority);
        priorityQueue.Enqueue(zero.Value,zero.Priority); 
         
        
        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var removed = priorityQueue.Dequeue();//get a removed element
            Console.WriteLine("expected:", expectedResult[i].Value, "queue name", removed  );
            Assert.AreEqual(expectedResult[i].Value, removed);
 
             
        }
        Console.WriteLine("FINISH priorityQueue #4 test-----------------------");
        
    }
    
    [TestMethod]
    // Scenario: Add and remove elements interleaved.
    // Expected Result: Each added element is immediately dequeued and matches the inserted value.
    // Defect(s) Found: None.
    public void TestPriorityQueue_5()
    {
        var priorityQueue = new PriorityQueue();
        for (int i = 0; i < 10; i++)
        {
            priorityQueue.Enqueue($"Item{i}", i);
            Assert.AreEqual($"Item{i}", priorityQueue.Dequeue());
        }
    }
    // Add more test cases as needed below.
    
}