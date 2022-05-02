
var result = SortedMerge(new List<int> { 9, 9, 10 }, new int[] { 1, 2, 3 });
System.Console.WriteLine();

static int[] SortedMerge(List<int> A, int[] B)
{
    int IndexA = 0;
    for (int i = 0; i < B.Length; i++)
    {
        while (A[IndexA] < B[i])
        {
            IndexA++;
            if (IndexA > A.Count - 1)
            {
                break;
            }
        }
        if (IndexA < A.Count)
        {
            A.Insert(IndexA, B[i]);
            IndexA++;
        }
        else
        {

            A.AddRange(B[i..]);
            break;
        }
    }
    return A.ToArray();
}