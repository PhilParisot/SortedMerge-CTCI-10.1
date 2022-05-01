


var result = SortedMerge(new List<int> { 1, 4, 6, 7, 9 }, new int[] { 2, 3, 5, 6, 9 });
System.Console.WriteLine();                         // 1 2 3 4 5 6 6 7 9 9

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
        IndexA++;
    }
    return A.ToArray();
}