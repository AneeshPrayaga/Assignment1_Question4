using System;

namespace Assignment1_Question4
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] arr1 = { 1,3,7,6,5,6};//declaring array
            Console.WriteLine("Q4:");
            int pivot = PivotIndex(arr1);//placing array and calling pivot
            if (pivot > 0)//if pivot > 0
            {
                Console.WriteLine("The Pivot index for the given array is {0}", pivot);
            }
            else
            {
                Console.WriteLine("The given array has no Pivot index");
            }

        }
        static int PivotIndex(int[] nums)
        {
            try {
                // Creating the sum of the numbers Before/Prefix to the Elements
                // array from 0
                int n = nums.Length;//length of the array
                int[] SumOfNumbersBefore = new int[n];//new array for sum of number to the left.
                SumOfNumbersBefore[0] = nums[0];//Keeping the first index same.
                for (int i = 1; i < n; i++)//sum of numbers before the index
                    SumOfNumbersBefore[i] = SumOfNumbersBefore[i - 1] +
                                             nums[i];//new array with sum of numbers from left


                // Forming Sum of elemnts After the Elements 
                // array from Length - To the right
                int[] SumOfNumbersAfter = new int[n];//Keeping the last number same
                SumOfNumbersAfter[n - 1] = nums[n - 1];//Keeping the Right or ast idex the same
                for (int i = n - 2; i >= 0; i--)//n-2 to exlcude the last element Sum
                    SumOfNumbersAfter[i] = SumOfNumbersAfter[i + 1] +
                                             nums[i];//sum of elements from the right

                // Find the point where left and right sum are equal
                // Finding the Index to Return.
                for (int i = 1; i < n - 1; i++)
                    if (SumOfNumbersBefore[i] == SumOfNumbersAfter[i])//if sum of the left and right is equal then return the index.
                        return i;//returning the index

                return -1;//If no idex matched Then return -1
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            }
        // int LeftSum = 0;
        // int RightSUm = 0;

        // int[] MyArray = { 1, 7, 3, 6, 5, 6 };
        // int lengeth1 = MyArray.Length;
        //var x =findElement(MyArray, MyArray.Length);
        // Console.WriteLine(x);
        //Console.WriteLine(" NEW **********the length of array is " + lengeth1);

        //for(int i = 1;i <lengeth1-1; i++)
        //{
        //    //Console.WriteLine("Elements are " + MyArray[i]);
        //    for (int j = i-1; j >= 0; j--)
        //    {
        //        Console.WriteLine("element in Sum {0}", MyArray[j]);
        //        LeftSum = LeftSum + MyArray[j];

        //        Console.WriteLine("First Loop Try" + MyArray[j] + "\n");
        //    }
        //    for(int k = i+1; k<= lengeth1-1; k++)
        //    {
        //        RightSUm = RightSUm + MyArray[k];

        //    }
        //}
        //Console.WriteLine(LeftSum + "--- is left Sum");
        //Console.WriteLine(RightSUm + " ------ is right sum");
    }
}
