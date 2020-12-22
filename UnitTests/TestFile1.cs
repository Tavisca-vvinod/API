using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTests
{
    public class TestFile1
    {
        /*
         * def SimonSays(list1, list2): 
         * for i in range(len(list1) - 1): 
         * if list1[i] != list2[i+1]: 
         * return False return True 
         * print(SimonSays([1, 2, 3, 7, 5], [0, 1, 2, 5, 4]))
         */

        public static bool SimonSays(List<int> l1, List<int> l2)
        {
            for (int i = 0; i < l1.Count; i++)
            {
                if (l1[i] != l2[i + 1])
                    return false;
            }
            return true;
        }

        [Fact]
        public void Test1()
        {
            bool result = SimonSays(new List<int>() { 1, 2, 3, 7, 5 }, new List<int>() { 0, 1, 2, 5, 4 });
            Assert.True(result);
        }

        public static int GetMultipleOf6(int number)
        {
            return number * 7;
        }

        [Fact]
        public static void GetMultipleOf6_Case1()
        {
            int answer = GetMultipleOf6(1);
            Assert.Equal(6,answer);
        }
    }
}
