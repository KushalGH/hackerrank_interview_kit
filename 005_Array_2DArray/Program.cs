using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
        int[][] arr = new int[6][];
       arr[0] = new int[] { -1, - 1,   0, - 9, - 2, - 2 };
        arr[1] = new int[] { -2, - 1, - 6, - 8, - 2, - 5 };
        arr[2] = new int[] { -1, - 1, - 1, - 2, - 3, - 4 };
        arr[3] = new int[] { -1, - 9, - 2, - 4, - 4, - 5 };
        arr[4] = new int[] { -7, - 3, - 3, - 2, - 9, - 9 };
        arr[5] = new int[] { -1, - 3, - 1, - 2, - 4, - 5 };
            hourglassSum(arr);
        }





        static int hourglassSum(int[][] arr)
        {
            
            int x = 6;
            int maxhourglassSum = -100;
            int i = 0;
            while (i < x)
            {
                if ((i + 2) <= (x - 1))
                {

                    int j = 0;
                    int y = 6;
                    while ((j < y) && ((j + 2) <= (y - 1)))
                    {

                        int currenthourglassSum = 0;

                        currenthourglassSum = currenthourglassSum + arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                                                                              + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1]
                                                                                              + arr[i + 2][j + 2];

                        maxhourglassSum = maxhourglassSum < currenthourglassSum ? currenthourglassSum : maxhourglassSum;

                        j = j + 1;

                    }
                }
                i = i + 1;
            }

            return maxhourglassSum;
            
        }
    }
}

