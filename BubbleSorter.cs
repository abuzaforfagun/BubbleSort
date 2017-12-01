using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class BubbleSorter
    {
        public static void DoSort(int[] list)
        {
            list = Sort(list);
        }
        private static int[] Sort(int[] list)
        {
            
            for(var n = list.Length; n != 0;)
            {
                var newN = 0;
                for (int i = 1; i <= (n-1); i++)
                {
                    if(list[i-1] > list[i])
                    {
                        int temp = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = temp;
                    }
                }
                n--;
            }
            return list;
        }
    }
}
