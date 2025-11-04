List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };

fruits.Add("Orange");
fruits.Remove("Banana");

Console.WriteLine($"Your first favorite fruit is {fruits[0]}.");
Console.WriteLine($"Your second favorite fruit is {fruits[1]}.");
Console.WriteLine($"Your third favorite fruit is {fruits[2]}.");
Console.WriteLine($"An additional fruit you like is {fruits[3]}.");
Console.WriteLine($"Now, you have a total of {fruits.Count} fruits in your list.");

Dictionary<int, string> fruitDict = new Dictionary<int, string>
        {
            {1, "Apple"},
            {2, "Banana"},
            {3, "Mango"}
        };

fruitDict.Add(4, "Orange");

Console.WriteLine($"Fruit with ID 1 is {fruitDict[1]}.");
Console.WriteLine($"Fruit with ID 2 is {fruitDict[2]}.");
Console.WriteLine($"Fruit with ID 3 is {fruitDict[3]}.");
Console.WriteLine($"Fruit with ID 4 is {fruitDict[4]}.");