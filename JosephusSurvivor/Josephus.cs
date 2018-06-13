using System;

namespace Josephus
{
    public class JosephusSurvivor
    {
        public static int JosSurvivor(int n, int k)
        {
            int[] survivorList = new int[n];
            for (int i = 0; i < n; i++)
                survivorList[i] = i + 1;

           return getSurvivor(survivorList, k);
        }
        private static int getSurvivor(int[] survivorList, int k)
        {
            int length = survivorList.Length - 1;
            if (length == 0)
                return survivorList[0];
                else
            {
                int[] newsurvivorList = new int[length];
                for (int i = 0; i < length; i++)
                    newsurvivorList[i] = survivorList[(i + k) % survivorList.Length];
                return getSurvivor(newsurvivorList, k);                   
                }
        }
     }
}
