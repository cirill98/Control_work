string[] array1 = new string[5] {"control", "work", "45", "2", "cat"};
string[] array2 = new string[array1.Length];
for (int i = 0; i < array1.Length; i++)
{
    int count = 0;
    if (array1[i].Length <= 3)
    {
        array2[count] = array1[i];
        Console.Write($"{array2[count]} ");
        count++;
    }
}