List<string> fruits = new List<string>
{
    "Mango",
    "Apple",
    "Banana"
};


fruits.Add("Orange");


fruits.Remove("Apple");


foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}


Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
{
    { 1, "Mango" },
    { 2, "Apple" },
    { 3, "Banana" }
};


fruitDictionary.Add(4, "Orange");


foreach (KeyValuePair<int, string> item in fruitDictionary)
{
    Console.WriteLine("ID: " + item.Key + ", Fruit: " + item.Value);
}