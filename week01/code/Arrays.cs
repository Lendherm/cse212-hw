public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Plan:
        // 1. Create a new double array with size equal to 'length'.
        // 2. Loop from i = 0 to length - 1.
        // 3. At each index i, store number * (i + 1) so the first value is
        //    1 * number, then 2 * number, then 3 * number, and so on.
        // 4. Return the filled array.

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Plan:
        // 1. Rotating right by 'amount' means the last 'amount' items move to the front.
        //    Example: {1,2,3,4,5,6,7,8,9} amount 3 -> last 3 are {7,8,9}, rest are {1,2,3,4,5,6}.
        // 2. Use GetRange to copy the last 'amount' values into a temporary list.
        // 3. Remove those last 'amount' values from the original list with RemoveRange.
        // 4. Insert the temporary list at the beginning (index 0) with InsertRange.
        // 5. This modifies 'data' in place; no return value is needed.

        List<int> end = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, end);
    }
}
