﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int total = 0;
float average = 0;

Array.Sort(array);
foreach (int index in array)
{
    Console.Write(index + ", ");

    total += index;
    average = (float)total / array.Length;
};
Console.WriteLine(average);
Console.ReadLine();

int[,] matrix = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
Console.WriteLine(matrix[1, 1]);
Console.ReadLine();