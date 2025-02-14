using System;

public class InsertionSort
{
	public static void Sort(int[] arr)
	{
		for (int i = 1; i < arr.Length; i++)
		{
			int curr = arr[i];
			int j = i - 1;

			while (j >= 0 && arr[j] > curr)
			{
				arr[j + 1] = arr[j];
				j--;
			}

			arr[j + 1] = curr;
		}
	}
	public static void Main(string[] args)
	{
		int[] id = { 12, 34, 21, 55, 3, 1, 8, 13 };

		Sort(id);

		foreach (int i in id)
		{
			Console.Write(i + " ");
		}
	}
}