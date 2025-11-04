
int[] favoriteNumbers = { 7, 3, 9, 1, 5 };


Array.Sort(favoriteNumbers);
Console.WriteLine("Sorted Array (Ascending): " + string.Join(" ", favoriteNumbers));

Array.Reverse(favoriteNumbers);
Console.WriteLine("Reversed Array (Descending): " + string.Join(" ", favoriteNumbers));


int searchNumber = 5;
int index = Array.IndexOf(favoriteNumbers, searchNumber);
Console.WriteLine($"Position of number {searchNumber}: {index}");