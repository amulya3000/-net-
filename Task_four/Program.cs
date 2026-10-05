int[] numbers = { 8, 21, 5, 42, 15 };

Array.Sort(numbers);

Array.Reverse(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

int position = Array.IndexOf(numbers, 21);

Console.WriteLine("Position of 21: " + position);