//using System;
//using System.Collections.Generic;
////Exercise 2
//class Program
//{
//    static void Main()
//    {
//        // 1. Create a SortedDictionary
//        // The keys (scores) are automatically sorted in ascending order.
//        SortedDictionary<int, string> leaderboard =
//            new SortedDictionary<int, string>();

//        leaderboard.Add(500, "Ahmed");
//        leaderboard.Add(200, "Sara");
//        leaderboard.Add(800, "Ali");
//        leaderboard.Add(350, "Mona");

//        // 2. Print all entries
//        Console.WriteLine("Leaderboard:");

//        foreach (var player in leaderboard)
//        {
//            Console.WriteLine($"Score: {player.Key} - Player: {player.Value}");
//        }

//        // 3. Access the first key and first value
//        int firstKey = leaderboard.Keys.First();
//        string firstValue = leaderboard.Values.First();

//        Console.WriteLine($"\nFirst Key: {firstKey}");
//        Console.WriteLine($"First Value: {firstValue}");

//        // 4. Check if score 500 exists
//        bool score500Exists = leaderboard.ContainsKey(500);

//        Console.WriteLine($"\nDoes score 500 exist? {score500Exists}");

//        // 5. Safely get the player with score 999
//        if (leaderboard.TryGetValue(999, out string player999))
//        {
//            Console.WriteLine($"Player with score 999: {player999}");
//        }
//        else
//        {
//            Console.WriteLine("Player with score 999: Not Found");
//        }

//        // 6. Remove the player with score 200
//        leaderboard.Remove(200);

//        Console.WriteLine("\nLeaderboard after removing score 200:");

//        foreach (var player in leaderboard)
//        {
//            Console.WriteLine($"Score: {player.Key} - Player: {player.Value}");
//        }
//    }
//}