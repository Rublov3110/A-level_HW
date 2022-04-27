using System;
{
    Random Random = new Random();
    int[] arrey = new int[10];
    int namber =0;

    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = Random.Next(-1000, 1000);
    }
    Console.Write("Arrey1: ");
    foreach (int i in arrey)
    {
        Console.Write($"{i} ");
        if (i > -100 & i < 100)
            namber++;
    }
    Console.WriteLine();
    Console.WriteLine($"N={namber}");
}
Console.WriteLine(new string('_', 70));
Console.WriteLine();
{
    Random Random = new Random();
    int[] arreyA = new int[20];
    int[] arreyB = new int[20];

    for (int i = 0; i < arreyA.Length; i++)
    {
        arreyA[i] = Random.Next(-1000, +1000);
    }
    Console.Write("ArreyA: ");
    foreach (int i in arreyA)
    {
        Console.Write($"{i} ");
    }

    Console.WriteLine();

    for (int i = 0; i < arreyB.Length; i++)
    {
        if (arreyA[i] <= 880)
            arreyB[i] = arreyA[i];
    }
    Array.Sort(arreyB);
    Array.Reverse(arreyB);
    Console.Write("ArreyB: ");
    for (int i = 0; i < arreyB.Length; i++)
    {
        Console.Write($"{arreyB[i]} ");
    }
}
Console.ReadLine();