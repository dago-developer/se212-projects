public static class Arrays
{
    public static double[] MultiplesOf(double number, int length)
    {
             double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }


    public static void RotateListRight(List<int> data, int amount)
    {
           int splitIndex = data.Count - amount;

        List<int> end = data.GetRange(splitIndex, amount); // parte final que va al principio
        List<int> start = data.GetRange(0, splitIndex);    // parte inicial que va al final

        data.Clear();
        data.AddRange(end);
        data.AddRange(start);
    }
}
