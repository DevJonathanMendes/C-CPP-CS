class Program
{
    static void Main()
    {
        // Formas de declarar:

        // Array unidimensional.
        int[] arrInt1 = new int[2] { 0, 1 };
        int[] arrInt2 = new int[] { 0, 1 };
        int[] arrInt3 = { 0, 1 };

        // Array multidimensional.
        int[,] multiArr1 = new int[2, 2];
        int[,] multiArr2 = new int[2, 4] { { 0, 1, 2, 3}, { 4, 5, 6, 7 } };

        // Array de Arrays
        int[][,] ArrOfArr1 = new int[2][,] { new int[2, 3], new int[4, 5] };
        int[][,] ArrOfArr2 = new int[2][,] { new int[2, 2] { { 1, 2 }, { 3, 4 } }, new int[2, 2] { { 5, 6 }, { 7, 8 } } };
    }
}