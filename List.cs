using System;
namespace Algorithm
{
	public class MyList
	{
		
		public static void Main(string[] args)
		{
            List<int> list = new List<int>();
			list.Add(8);
			list.Add(9);
			list.Add(8);
			list.Add(10);
			list.Add(13);
			list.Add(2);
			list.Add(7);
			list.Add(2);
			list.Add(1);
			list.Add(9);

			//foreach(int item in list)
			//{
			//	Console.WriteLine(item);
			//}

			Sorting obj = new Sorting();
			obj.Mergesort(list);


			foreach (int item in list)
			{
				Console.WriteLine(item);
			}


			Console.ReadLine();
		}
	}
}

