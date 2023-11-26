/*
 * ------------------------------------------
 * File Name: Book.cs
 * Project Name: GunJason_Project2_2210
 * ------------------------------------------
 * Author's name and email: Jason Gun jgun1062@gmail.com
 * Course Section: 901
 * Creation Date: 09/27/2023
 * ------------------------------------------
 */
using System;
using System.Text.RegularExpressions;
namespace JasonGunProject2
{
    public class Book : IComparable<Book>
    {
        ///
        ///
        ///Most of the logic done in this class was completed with the help of a tutor!
        ///
        /// 
        /// <summary>
        /// Aspects of a book (properties), made to be able to use them
        /// </summary>
        public string title { get; set; }
        public string releaseDate { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }

        /// <summary>
        /// Sets initial values for the properties of the book
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="title"></param>
        /// <param name="releaseDate"></param>
        public Book(string lastName, string firstName, string title, string releaseDate)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.title = title;
            this.releaseDate = releaseDate;
        }

        /// <summary>
        /// Make a book out of the string given by the file
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Book Parse(string str)
        {
            string[] parts = str.Split('|');

            string lastName = parts[0].Trim();
            string firstName = parts[1].Trim();
            string title = parts[2].Trim().Trim();
            string releaseDate = parts[3].Trim();

            return new Book(lastName, firstName, title, releaseDate);
        }

        /// <summary>
        /// Verify if the string given by the file is able to be converted into a book
        /// </summary>
        /// <param name="str"></param>
        /// <param name="book"></param>
        /// <returns></returns>
        public static bool TryParse(string str, out Book book)
        {
            book = null;
            try
            {
                book = Parse(str);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Makes the "book" into a string for the user to see
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{lastName}, {firstName}, \"{title}\", {releaseDate}";
        }

        /// <summary>
        /// Compare two different books of the same type by their properties, with last name being of the highest priority
        /// This method was done with the help of a tutor!
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Book other)
        {
            int lastNameComparison = string.Compare(this.lastName, other.lastName);
            if (lastNameComparison != 0)
            {
                return lastNameComparison;
            }

            int firstNameComparison = string.Compare(this.firstName, other.firstName);
            if (firstNameComparison != 0)
            {
                return firstNameComparison;
            }

            int titleComparison = string.Compare(this.title, other.title);
            if (titleComparison != 0)
            {
                return titleComparison;
            }

            return this.releaseDate.CompareTo(other.releaseDate);
        }
    }
}

