using Community.RandomOrg;
using System.Collections.Generic;
using System.Linq;
using NerdLib.Data;

namespace NerdLib.Random
{

    /// <summary>
    /// Random Generation resulting in Unique Values.
    /// </summary>
    public static class Unique
    {
        /// <summary>
        /// Get an array of random ints.
        /// </summary>
        /// <param name="digitCount">How many digits long each number will be.</param>
        /// <param name="count">How many numbers you want to generate.</param>
        /// <returns></returns>
        public static int[] GetInt(int digitCount, int count)
        {
            // Major Credit to https://stackoverflow.com/users/416574/pstrjds for the help with this section of code.
            int[] result = new int[count];
            var values = new HashSet<int>();
            for (int i = 0; i < count; ++i)
            {
                var number = GetInt(digitCount);
                while (values.Contains(number)) number = GetInt(digitCount);
                result[i] = number;
                values.Add(number);
            }
            return result;
            // End Major Credit
        }

        /// <summary>
        /// Get a single random int.
        /// </summary>
        /// <param name="digitCount">How many digits long the number will be.</param>
        /// <returns></returns>
        public static int GetInt(int digitCount)
        {
            int[] storage = new int[digitCount];
            for (int i = 0; i < digitCount; i++)
            {
                double myRandom = 1;
                for (int j = 0; j < 8; j++)
                {
                    System.Random random = new System.Random();
                    myRandom += random.NextDouble();
                }
                storage[i] = (int)System.Math.Floor(myRandom * System.Math.Pow(10, i));
            }
            return Int.Concatenate(storage);
        }
    }

    /// <summary>
    /// Random Generation resulting in Pseudo Values.
    /// </summary>
    public static class Pseudo
    {
        /// <summary>
        /// Get an array of random ints.
        /// </summary>
        /// <param name="digitCount">How many digits long each number will be.</param>
        /// <param name="count">How many numbers you want to generate.</param>
        /// <returns></returns>
        public static int[] GetInt(int digitCount, int count)
        {
            int[] result = new int[count];
            for (int i = 0; i < count; ++i)
            {
                var number = GetInt(digitCount);
                if (i != 0)
                {
                    while (result[i - 1] == number) number = GetInt(digitCount);
                }
                result[i] = number;
            }
            return result;
        }

        /// <summary>
        /// Get a single random int.
        /// </summary>
        /// <param name="digitCount">How many digits long the number will be.</param>
        /// <returns></returns>
        public static int GetInt(int digitCount)
        {
            int[] storage = new int[digitCount];
            for (int i = 0; i < digitCount; i++)
            {
                double myRandom = 1;
                for (int j = 0; j < 8; j++)
                {
                    System.Random random = new System.Random();
                    myRandom += random.NextDouble();
                }
                storage[i] = (int)System.Math.Floor(myRandom * System.Math.Pow(10, i));
            }
            return Int.Concatenate(storage);
        }
    }

    /// <summary>
    /// Random Generation resulting in Truely Random Values.
    /// </summary>
    public static class True
    {
        private static string key = "";
        private static RandomOrgClient myClient = new RandomOrgClient(key);

        /// <summary>
        /// You must do this before you call ANY other True function.
        /// </summary>
        /// <param name="key">The API Key you got from Random.Org</param>
        private static void SetKey(string key)
        {
            True.key = key;
        }

        /// <summary>
        /// Get an array of random ints.
        /// </summary>
        /// <param name="digitCount">How many digits long each number will be.</param>
        /// <param name="count">How many numbers you want to generate.</param>
        /// <returns></returns>
        public static int[] GetInt(int digitCount, int count)
        {
            var result = myClient.GenerateIntegersAsync(count, (int)System.Math.Pow(10, digitCount), (int)(System.Math.Pow(10, digitCount) * 9), false);
            return result.Result.Random.Data.ToArray();
        }

        /// <summary>
        /// Get a single random int.
        /// </summary>
        /// <param name="digitCount">How many digits long the number will be.</param>
        /// <returns></returns>
        public static int GetInt(int digitCount)
        {
            var result = myClient.GenerateIntegersAsync(1, (int)System.Math.Pow(10, digitCount), (int)(System.Math.Pow(10, digitCount) * 9), false);
            return result.Result.Random.Data[0];
        }

        public static string GetUse()
        {
            var result = myClient.GetUsageAsync();
            return result.Result.Status.ToString() + "\n" + result.Result.RequestsLeft + " requests left\n" + result.Result.BitsLeft + " bits left\n\n";
        }
    }
}
