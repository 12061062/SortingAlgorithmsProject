/*
 * ------------------------------------------
 * File Name: ISort.cs
 * Project Name: GunJason_Project2_2210
 * ------------------------------------------
 * Author's name and email: Jason Gun jgun1062@gmail.com
 * Course Section: 901
 * Creation Date: 09/27/2023
 * ------------------------------------------
 */
using System;
namespace JasonGunProject2
{
    public interface ISort<T> where T : IComparable<T>
    {
        /// <summary>
        /// Give needed structure for the recursive/iterative classes
        /// </summary>
        /// <param name="values"></param>
        void Sort(List<T> values);
    }
}

