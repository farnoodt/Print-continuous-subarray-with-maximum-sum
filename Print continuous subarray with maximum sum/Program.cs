// See https://aka.ms/new-console-template for more information
int[] A = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
kadane(A);
Console.WriteLine("Hello, World!");


static void kadane(int[] A)
{
    int start = 0;
    int End = 0;
    int beg = 0;
    int SoFar = 0;
    int Max = 0;

    for (int i = 0; i < A.Length; i++)
    {
        Max += A[i];
        if (A[i]> Max)
        {
            Max = A[i];
            beg = i;
        }

        if (SoFar < Max)
        {
            SoFar = Max;
            start = beg;
            End = i;
        }
        
    }
    for (int i = start; i <= End; i++)
    {
        Console.WriteLine(A[i] + ", ");
    }
}