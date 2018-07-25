using System;
using System.IO;
using System.Collections;

namespace HackerRank.Interview.Prep
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //String intput = Environment.CommandLine.ToString();
            int[][] arr = new int[6][];
            //arr[0] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //arr[1] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //Console.WriteLine("Input --> " + arr[0][0]);

            for (int i = 0; i < 6;i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            Console.WriteLine(" Input -->" + arr[3][3]);
            //int[][] arr = new int[6][];

            for (int j = 0; j < 6;j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(arr[j][i]);
                }   
            }


            int result = hourglassSum(arr);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        static int hourglassSum(int[][] array)
        {
            int[] result = new int[16];
            int tempSum;
            int resultCount = 0;
            String sArray = "";
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    tempSum = 0;
                    sArray = "";
                    for (int i = y; i < y + 3; i++)
                    {
                        for (int j = x; j < x + 3; j++)
                        {
                            if (i == y+1)
                            {
                                if (j == x + 1)
                                {
                                    tempSum = tempSum + array[i][j];
                                    sArray = sArray + '\n' + '\t' + array[i][j] + '\t' + '\n';
                                }
                            }
                            else
                            {
                                sArray = sArray + array[i][j].ToString() + '\t';
                                tempSum = tempSum + array[i][j];
                            }
                        }
                    }
                    result[resultCount] = tempSum;
                    resultCount++;
                }
            }
            Array.Sort(result);
            return result[result.Length-1];
        }

    }
}
