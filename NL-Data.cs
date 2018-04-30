

namespace NerdLib.Data
{
    public static class Int
    {
        public static int Concatenate(int[] input)
        {
            string result = "";
            foreach (int num in input)
            {
                result += num.ToString();
            }
            return int.Parse(result);
        }
    }
    public static class String
    {

    }
}
