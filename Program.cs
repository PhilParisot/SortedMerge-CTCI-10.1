// Interview checklist. Just try this on your own on at least ONE problem
// Ask for valid inputs and outputs
// Whatever the interviewer says, write it down
// Develop test cases
// Don’t be afraid to do this out of order
// Don’t be afraid to come back to make more test cases
// Call the function with these conditions, print results
// Ensure your understanding of the problem
// Unless you’re given a signature, write your own signatures
// Start with the first test case
// If you think of other test cases, don’t try to solve it immediately, add it to the bottom of the list of test cases
// Finish all the other test cases, one by one



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