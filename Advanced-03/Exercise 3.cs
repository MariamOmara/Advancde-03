//using System;
//using System.Collections.Generic;
////Exercise 3
//class Program
//{
//    static void Main()
//    {
//        // 1. Create a Dictionary with 4 contacts
//        Dictionary<string, string> phoneBook = new Dictionary<string, string>
//        {
//            { "Ahmed", "01011111111" },
//            { "Sara", "01022222222" },
//            { "Ali", "01033333333" },
//            { "Mona", "01044444444" }
//        };

//        // 2. Add a new contact using [] syntax
//        phoneBook["Omar"] = "01055555555";

//        Console.WriteLine("Phone Book:");
//        foreach (var contact in phoneBook)
//        {
//            Console.WriteLine($"{contact.Key} -> {contact.Value}");
//        }

//        // 3. Try adding a duplicate using Add()
//        try
//        {
//            phoneBook.Add("Ahmed", "01199999999");
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"\nAdd() Error: {ex.Message}");
//        }

//        // 4. Try adding a duplicate using TryAdd()
//        bool added = phoneBook.TryAdd("Ahmed", "01199999999");

//        Console.WriteLine($"TryAdd() succeeded: {added}");

//        // 5. Search for a contact that doesn't exist
//        bool exists = phoneBook.ContainsKey("Khaled");

//        Console.WriteLine($"\nDoes Khaled exist? {exists}");

//        // 6. Get a contact with a fallback of "Not Found"
//        string phoneNumber = phoneBook.GetValueOrDefault(
//            "Khaled",
//            "Not Found"
//        );

//        Console.WriteLine($"Khaled phone number: {phoneNumber}");

//        // 7. Print all Keys on one line
//        Console.WriteLine("\nKeys:");

//        foreach (string key in phoneBook.Keys)
//        {
//            Console.Write(key + " ");
//        }

//        // Print all Values on another line
//        Console.WriteLine("\n\nValues:");

//        foreach (string value in phoneBook.Values)
//        {
//            Console.Write(value + " ");
//        }
//    }
//}