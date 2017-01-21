
namespace lab16
{
    public class qSort
    {
        public void Sort(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = arr[left + (right - left) / 2];

            while (i <= j)
            {
                while (arr[i].CompareTo(pivot) < 0)
                {
                    int u = arr[i].CompareTo(pivot);
                    i++;
                }

                while (arr[j].CompareTo(pivot) > 0)
                {
                    int u = arr[j].CompareTo(pivot);
                    j--;
                }

                if (i <= j)
                {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                    j--;
                }

                if (left < j)
                {
                    Sort(arr, left, j);
                }

                if (i < right)
                {
                    Sort(arr, i, right);
                }
            }
        }
    }
}
