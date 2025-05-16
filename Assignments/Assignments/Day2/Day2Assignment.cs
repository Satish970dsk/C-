using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Day2
{
    internal class Day2Assignment
    {
        public static void CommonValue()
        {
            int[] teamA = { 45, 78, 45, 34, 65, 89 };
            int[] teamB = { 78, 4, 8, 9, 65, 3, 7, 34 };

            for (int i = 0; i < teamB.Length; i++) {

                for (int j = 0; j < teamA.Length; j++) {

                    if (teamA[j] == teamB[i]) {
                        Console.WriteLine("common value is: "+ teamA[j]);
                    }
                }
            }
        }

        public static void ThreeByThreeMat()
        {
            int[,] a = 
            {
                {10,34,45 },
                {11,12,13},
                {21,31,41 }
            };

            for (int i = 0;i < a.GetLength(0); i++)
            {    int sum = 0;
                for (int j = 0;j < a.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        sum += a[i, j];
                    }
                }
                Console.WriteLine(sum);
                break;
            }
        }

        public static void GetData()
        {
            Object[] myObjects = new Object[5];
            myObjects[0] = "hello";
            myObjects[1] = 123;
            myObjects[2] = 123.4;
            myObjects[3] = null;
            myObjects[4] = "Mphasis";

            foreach (var item in myObjects)
            {
                if(item is string)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void PrintCountries() {
            string[] st = {"Srilanka","Singapore","India","Swedan","Canada"};

            foreach (var item in st)
            {
                if(item.StartsWith("S") && item.Length > 7)
                {
                    Console.WriteLine(item.ToUpper());
                }
            }
        }

        public static void EvenOddCount() {
            int[] nums = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            int evencount=0, oddcount=0;
            foreach (var item in nums)
            {
                if (item % 2 == 0)
                {
                    evencount++;
                }
                else
                {
                    oddcount++;
                }
            }
            Console.WriteLine($"evnen numbers count is {evencount}\nodd numbers count is {oddcount}");
        }

        public static void FindDuplicate() {
            int[] newarr = { 1, 3, 5 };
          
            foreach (var item in newarr)
            {
                Console.WriteLine(item);
            }
            int[] nums = { 1, 2, 3, 4, 5,12, 6, 7, 8,1,1, 9, 10, 11, 12, 13, 14, 4, 15 };
            for (int i = 0; i < nums.Length; i++) {
            
                for (int j = i+1; j < nums.Length; j++) {

                    if (nums[i] == nums[j])
                    {
                        Console.WriteLine("duplicate value is: " + nums[j]);
                        break;

                    }

                }
               
            }
        }

        public static void MergeTwoArrays() {
            int[] a = { 1, 2,5,8,9,10,11,12,13,14,15 };
            int[] b = { 21,31,41,51,61,10 };
            int[] c = new int[a.Length + b.Length];
           
            Array.Copy(a,0,c,0,a.Length);
            Array.Copy(b,0,c,a.Length,b.Length);
           
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
           
        }

        public static void DisplayArray(int[] nums, bool rev = false) {

            if (rev) { 
                Array.Reverse(nums);
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }

        public static void Add2X2Mat()
        {
            int[,] matrix1 = {
                        {1, 2},
                        {3, 4}
                              };

            int[,] matrix2 = {
                    {5, 6},
                    {7, 8}
                            };

            for (int i = 0; i < matrix1.GetLength(0); i++) { 
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(matrix1[i, j] + matrix2[i,j]+" ");
                }
                Console.WriteLine();
            }
    }

        public static void SumOfEachRow()
        {
           int[,] mat = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
                            };
           
           for (int i = 0;i < mat.GetLength(0); i++)
            {
                int s = 0;
                for (int j = 0;j < mat.GetLength(1); j++)
                {
                    s += mat[i,j];
                }
                Console.WriteLine($"Row {i+1} sum is {s}");
            }
        }

        public static void Diagonal() {

            int[,] matrix = {
                    {11, 2, 3},
                    {4, 55, 6},
                    {7, 8, 99}
                            };

            for(int i = 0; i<matrix.GetLength(0); i++)
            {
                for (int j = 0;j<matrix.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        Console.Write(matrix[i,j] + " ");
                    }
                }
            }

        }

        public static void AvgOfJaggedArray()
        {
            int[][] scores = new int[][] {
                        new int[] { 80, 90 },
                        new int[] { 70, 85, 90 },
                        new int[] { 100 }
                        };
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                int n = scores[i].Length, s = 0;
                for(int j = 0; j < scores[i].Length; j++)
                {
                    s+= scores[i][j];
                }
                Console.WriteLine($"Average of  {i+1} row is {(double)s/n}");
            }
        }

        public static void LongestString(string[] str)
        {
            int cl = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i].Length>cl)
                {
                   // Console.WriteLine(str[i]);
                   cl= str[i].Length;
                    
                }
                
                
            }
            for (int i = 0;i < str.Length; i++)
            {
                if (str[i].Length == cl)
                {
                    Console.WriteLine(str[i]);
                }
            }
            
        }

        public static void JoinString()
        {
            string[] parts = { "2025", "05", "03" };
            Array.Reverse(parts);
            Console.WriteLine(String.Join("/",parts));
        }

        public static void ReplaceWord() {

            string[] techs = {
                "I love Java",
                "Java is versatile",
                "Python is cool"
                };
            techs.Contains("Java");
        }
       
}
}