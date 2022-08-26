void Output(float[] array)
{
    for (int i = 0; i < array.Length; ++i)
        Console.WriteLine(array[i]);
}

float DiffBetweenMaxAndMin(float[] array)
{
    float difference, max = array[0], min = array[0];

    for (int i = 1; i < array.Length; ++i)
    {    
        if (array[i] > max)
            max = array[i];
        else
            if (min > array[i])
                min = array[i];
    }

    Console.WriteLine(max);
    Console.WriteLine(min);

    difference = max - min;

    return difference;
}

Random rnd = new Random();
float[] array = new float[5];

for (int i = 0; i < array.Length; ++i)
    array[i] = rnd.Next(-100,100);

Output(array);
Console.WriteLine();
Console.WriteLine(DiffBetweenMaxAndMin(array));