//using System;
//using System.Collections.Generic;
////Exercise 4
//class Program
//{
//    static void Main()
//    {
//        // 1. Create a HashSet with case-insensitive comparer
//        HashSet<string> emails =
//            new HashSet<string>(StringComparer.OrdinalIgnoreCase);

//        // 2. Add the given emails
//        emails.Add("ahmed@test.com");
//        emails.Add("AHMED@test.com");
//        emails.Add("sara@test.com");
//        emails.Add("Sara@Test.Com");

//        // 3. Print Count
//        Console.WriteLine($"Email Count: {emails.Count}");

//        Console.WriteLine("Stored Emails:");

//        foreach (string email in emails)
//        {
//            Console.WriteLine(email);
//        }

//        // 4. Create Set A and Set B
//        HashSet<int> setA = new HashSet<int>
//        {
//            1, 2, 3, 4, 5
//        };

//        HashSet<int> setB = new HashSet<int>
//        {
//            4, 5, 6, 7, 8
//        };

//        // 5. UnionWith
//        HashSet<int> unionSet = new HashSet<int>(setA);
//        unionSet.UnionWith(setB);

//        Console.WriteLine("\nUnionWith:");

//        foreach (int number in unionSet)
//        {
//            Console.Write(number + " ");
//        }

//        // IntersectWith
//        HashSet<int> intersectSet = new HashSet<int>(setA);
//        intersectSet.IntersectWith(setB);

//        Console.WriteLine("\n\nIntersectWith:");

//        foreach (int number in intersectSet)
//        {
//            Console.Write(number + " ");
//        }

//        // ExceptWith
//        HashSet<int> exceptSet = new HashSet<int>(setA);
//        exceptSet.ExceptWith(setB);

//        Console.WriteLine("\n\nExceptWith:");

//        foreach (int number in exceptSet)
//        {
//            Console.Write(number + " ");
//        }

//        // 6. IsSubsetOf
//        HashSet<int> subset = new HashSet<int>
//        {
//            1, 2
//        };

//        bool isSubset = subset.IsSubsetOf(setA);

//        Console.WriteLine($"\n\nIs {{1, 2}} a subset of Set A? {isSubset}");
//    }
//}