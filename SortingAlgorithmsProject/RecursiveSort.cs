/*
 * ------------------------------------------
 * File Name: RecursiveSort.cs
 * Project Name: GunJason_Project2_2210
 * ------------------------------------------
 * Author's name and email: Jason Gun jgun1062@gmail.com
 * Course Section: 901
 * Creation Date: 09/27/2023
 * ------------------------------------------
 */
using System;
using System.Collections.Generic;
namespace JasonGunProject2
{
    public class RecursiveSort<T> : ISort<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorts a list using the recursive merge sort
        /// </summary>
        /// <param name="values"></param>
        public void Sort(List<T> values)
        {
            if (values == null)
            {
                return;
            }

            if (values.Count <= 1)
            {
                return;
            }


            //Split the list in half
            int middle = values.Count / 2;
            List<T> left = values.GetRange(0, middle);
            List<T> right = values.GetRange(middle, values.Count - middle);

            //Sort the two halves
            Sort(left);
            Sort(right);

            //Merge the halves
            Merge(values, left, right);
        }

        /// <summary>
        /// Method for where the values are compared to be sorted
        /// </summary>
        /// <param name="mergedList"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private void Merge(List<T> mergedList, List<T> left, List<T> right)
        {
            int leftIndex = 0, rightIndex = 0, mergedIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex].CompareTo(right[rightIndex]) <= 0)
                {
                    mergedList[mergedIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    mergedList[mergedIndex] = right[rightIndex];
                    rightIndex++;
                }
                mergedIndex++;
            }

            //Get remaining values from the left and right lists
            while (leftIndex < left.Count)
            {
                mergedList[mergedIndex] = left[leftIndex];
                leftIndex++;
                mergedIndex++;
            }

            while (rightIndex < right.Count)
            {
                mergedList[mergedIndex] = right[rightIndex];
                rightIndex++;
                mergedIndex++;
            }
        }
    }

}

