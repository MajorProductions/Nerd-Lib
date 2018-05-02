

namespace NerdLib.Data
{
    
    public static class Modification
    {

        /// <summary>
        /// Returns a series of ints from an int array.
        /// </summary>
        /// <param name="input">Only use an array that contains 8 or less digits.</param>
        /// <returns></returns>
        public static int Concatenate(int[] input)
        {
            string result = "";
            foreach (int num in input)
            {
                result += num.ToString();
            }
            return int.Parse(result);
        }

        /// <summary>
        /// Returns a double negative. One of both will result in no change.
        /// </summary>
        /// <param name="input">Bool array input.</param>
        /// <returns></returns>
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
