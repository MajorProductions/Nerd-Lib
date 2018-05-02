

namespace NerdLib.Data
{
    
    public static class Modification
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

        public static bool DoubleNegative(bool[] input)
        {
            int result = 0;
            foreach (bool num in input)
            {
                if (num) { result++; }
                else { result--; }
            }
            return System.Convert.ToBoolean(result);
        }
    }
    public static class String
    {
    }
}
