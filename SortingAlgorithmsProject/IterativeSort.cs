/*
 * ------------------------------------------
 * File Name: IterativeSort.cs
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
    public class IterativeSort<T> : ISort<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorts a list using the iterative selection sort
        /// </summary>
        /// <param name="values"></param>
        public void Sort(List<T> values)
        {
            var arrayLength = values.Count;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;

                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (values[j].CompareTo(values[smallestVal]) < 0)
                    {
                        smallestVal = j;
                    }
                }

                var tempVar = values[smallestVal];
                values[smallestVal] = values[i];
                values[i] = tempVar;
            }
        }
    }

}

