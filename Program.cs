namespace Algorithm
{
    public class Searching
    {
        public void Linearsearch(List<int> list,int k)
        {
            foreach(int item in list)
            {
                if (item == k)
                {
                    Console.WriteLine("The item is found");
                }
            }
        }
        public void Binarysearch(List<int> list)
        {

        }
    }
    public class Sorting
    {
        public void Bubblesort(List<int> list)
        {

        }

        public void Selectionsort(List<int> list)
        {

        }

        public void Insertionsort(List<int> list)
        {

        }

        //Quick Sort Apply ...
        public void Quicksort(List<int> list)
        {
            if(list == null || list.Count == 0)
            {
                return;
            }
            QuicksortHelper(list, 0, list.Count - 1);
        }
        public void QuicksortHelper(List<int> list,int left,int right)
        {
            if (left < right)
            {
                int pivot = Partition(list, left, right);
                QuicksortHelper(list, left, pivot - 1);
                QuicksortHelper(list, pivot + 1, right);
            }
        }
        public int Partition(List<int> list, int left, int right)
        {
            int pivot = list[right];
            int i = left - 1;

            for(int j = left; j < right; j++)
            {
                if (list[j] < pivot)
                {
                    i++;
                    swap(list, i, j);
                }
            }
            swap(list, i + 1,right);
            return i + 1;
        }
        public void swap(List<int> list, int i,int j)
        {
            int temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        //Merge Sort Apply...
        public void Mergesort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return;
            }
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = list.Count / 2;
            for(int i = 0; i < middle; i++)
            {
                left.Add(list[i]);
            }
            for(int i = middle; i < list.Count; i++)
            {
                right.Add(list[i]);
            }

            Mergesort(left);
            Mergesort(right);
            Merge(left, right, list);
        }
        public void Merge(List<int> left,List<int> right, List<int> result)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int resultIndex = 0;

            while(leftIndex<left.Count() && rightIndex < right.Count())
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    result[resultIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    result[resultIndex] = right[rightIndex];
                    rightIndex++;
                }
                resultIndex++;
            }
            while (leftIndex < left.Count())
            {
                result[resultIndex] = left[leftIndex];
                leftIndex++;
                resultIndex++;
            }
            while (rightIndex < right.Count())
            {
                result[resultIndex] = right[rightIndex];
                rightIndex++;
                resultIndex++;
            }
        }
    }
}
