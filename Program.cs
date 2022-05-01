


var result = SortedMerge(new List<int> { 16, 17  }, new int[] { 2, 3, 5, 6, 9, 9, 10 });
System.Console.WriteLine();                         // 1 2 3 4 5 6 6 7 9 9

static int[] SortedMerge(List<int> A, int[] B)
{
    int IndexA = 0;
    foreach (int i in B)
    {
        if (IndexA > A.Count - 1)
            A.Add(i);
        else
        {
            while (A[IndexA] < i)
            {
                IndexA++;
                if (IndexA > A.Count - 1) break;
            }
            A.Insert(IndexA, i);
            IndexA++;
        }
    }
    return A.ToArray();
}