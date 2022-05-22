int[] array1 = new int[20];
int[] array2 = new int[20];

Console.WriteLine("Array 1: [{0}]", string.Join(", ", array1));
Console.WriteLine("Array 2: [{0}]", string.Join(", ", array2));

for (int i = 0; i < 20; i++)
{
    array1[i] = 2*i + 3 * (i+1) - 3*(i-1);
}

Console.WriteLine("Array 1: [{0}]", string.Join(", ", array1));

Array.Copy(array1,array2,20);

Console.WriteLine("Array 2: [{0}]", string.Join(", ", array2));