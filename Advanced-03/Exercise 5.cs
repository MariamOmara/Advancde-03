//using System;
//using System.Collections.Generic;
////Exercise 5
//class Program
//{
//    static void Main()
//    {
//        // Create a Queue and add 5 documents
//        Queue<string> printQueue = new Queue<string>();

//        printQueue.Enqueue("Report.pdf");
//        printQueue.Enqueue("Invoice.pdf");
//        printQueue.Enqueue("Letter.docx");
//        printQueue.Enqueue("Resume.pdf");
//        printQueue.Enqueue("Photo.jpg");

//        // 1. Print the queue contents and Count
//        Console.WriteLine("Print Queue:");

//        foreach (string document in printQueue)
//        {
//            Console.WriteLine(document);
//        }

//        Console.WriteLine($"Count: {printQueue.Count}");

//        // 2. Use Peek to see which document will print next
//        string nextDocument = printQueue.Peek();

//        Console.WriteLine($"\nNext document: {nextDocument}");

//        // 3. Process the queue using Dequeue
//        Console.WriteLine("\nProcessing Queue:");

//        while (printQueue.Count > 0)
//        {
//            string document = printQueue.Dequeue();

//            Console.WriteLine($"Printing: {document}");
//        }

//        // 4. Try TryDequeue on the now-empty queue
//        bool success = printQueue.TryDequeue(out string remainingDocument);

//        Console.WriteLine($"\nTryDequeue succeeded: {success}");

//        if (!success)
//        {
//            Console.WriteLine("The queue is empty. No document was available.");
//        }
//    }
//}