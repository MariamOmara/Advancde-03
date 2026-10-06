//using System;
//using System.Collections.Generic;
////Exercise 6
//class Program
//{
//    static void Main()
//    {
//        // Create a Stack for browser history
//        Stack<string> browserHistory = new Stack<string>();

//        // 1. Push 5 URLs
//        browserHistory.Push("google.com");
//        browserHistory.Push("github.com");
//        browserHistory.Push("stackoverflow.com");
//        browserHistory.Push("youtube.com");
//        browserHistory.Push("claude.ai");

//        // 2. Use Peek to see the current page
//        Console.WriteLine($"Current Page: {browserHistory.Peek()}");

//        // 3. Press "back" 3 times using Pop
//        Console.WriteLine("\nGoing Back:");

//        for (int i = 0; i < 3; i++)
//        {
//            string page = browserHistory.Pop();

//            Console.WriteLine($"Leaving: {page}");
//        }

//        // 4. Print the current page after going back
//        Console.WriteLine($"\nCurrent Page After Going Back: {browserHistory.Peek()}");

//        // 5. Try TryPop on the stack
//        // The stack is not empty yet, so TryPop will succeed.
//        bool success = browserHistory.TryPop(out string pageAfterTryPop);

//        Console.WriteLine($"\nTryPop succeeded: {success}");

//        if (success)
//        {
//            Console.WriteLine($"Page removed by TryPop: {pageAfterTryPop}");
//        }
//    }
//}