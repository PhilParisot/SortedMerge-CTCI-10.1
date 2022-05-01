


var result = SortedMerge(new List<int> { 1, 4, 6, 7, 9 }, new int[] { 2, 3, 5, 6, 9 });
System.Console.WriteLine();

static int[] SortedMerge(List<int> A, int[] B)
{
    int IndexA = 0;
    foreach (int i in B)
    {
        while (A[IndexA] < i)
        {
            IndexA++;
        }
        A.Insert(IndexA, i);
    }
    return A.ToArray();
}