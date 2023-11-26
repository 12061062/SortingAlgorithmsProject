/*
 * ------------------------------------------
 * File Name: Program.cs
 * Project Name: GunJason_Project2_2210
 * ------------------------------------------
 * Author's name and email: Jason Gun jgun1062@gmail.com
 * Course Section: 901
 * Creation Date: 09/27/2023
 * ------------------------------------------
 */
using static System.Collections.Specialized.BitVector32;
using System.Diagnostics;
using static System.Reflection.Metadata.BlobBuilder;
using System.Collections.Generic;

namespace JasonGunProject2;
public class Program
{
    public static void Main(string[] args)
    {

        List<Book> books = new List<Book>();
        List<Book> books2 = new List<Book>();
        List<Book> books3 = new List<Book>();
        List<Book> books4 = new List<Book>();
        List<Book> books5 = new List<Book>();
        List<Book> books6 = new List<Book>();
        List<Book> books7 = new List<Book>();
        List<Book> books8 = new List<Book>();
        List<Book> books9 = new List<Book>();
        List<Book> books10 = new List<Book>();

        string[] bookFiles = Directory.GetFiles("/Users/jasongun/Downloads/TestDataBooks");

        for (int y = 0; y < bookFiles.Length; y++)
        {
            string[] bookFileData = File.ReadAllLines(bookFiles[y]);

            foreach (string str in bookFileData)
            {
                if (Book.TryParse(str, out Book book))
                {
                    books.Add(book);
                    books2.Add(book);
                    books3.Add(book);
                    books4.Add(book);
                    books5.Add(book);
                    books6.Add(book);
                    books7.Add(book);
                    books8.Add(book);
                    books9.Add(book);
                    books10.Add(book);
                }
                else
                {

                }
            }
            Console.WriteLine($"            Selection Sort on {bookFiles[y]}");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            RecursiveSort<Book> bookMergeSort = new RecursiveSort<Book>();
            IterativeSort<Book> bookIterativeSort = new IterativeSort<Book>();
            double[] average = new double[5];
            double[] mergeAverage = new double[5];

            Stopwatch sw = new Stopwatch();
            sw.Start();
            bookIterativeSort.Sort(books);
            sw.Stop();
            Console.WriteLine($"My first selection sort took {sw.Elapsed.TotalMilliseconds}ms to run on {bookFiles[y]}");
            average[0] = sw.Elapsed.TotalMilliseconds;

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            bookIterativeSort.Sort(books2);
            sw2.Stop();
            Console.WriteLine($"My second selection sort took {sw2.Elapsed.TotalMilliseconds}ms to run on {bookFiles[y]}");
            average[1] = sw2.Elapsed.TotalMilliseconds;

            Stopwatch sw3 = new Stopwatch();
            sw3.Start();
            bookIterativeSort.Sort(books3);
            sw3.Stop();
            Console.WriteLine($"My third selection sort took {sw3.Elapsed.TotalMilliseconds}ms to run on {bookFiles[y]}");
            average[2] = sw3.Elapsed.TotalMilliseconds;

            Stopwatch sw4 = new Stopwatch();
            sw4.Start();
            bookIterativeSort.Sort(books4);
            sw4.Stop();
            Console.WriteLine($"My fourth selection sort took {sw4.Elapsed.TotalMilliseconds}ms to run on {bookFiles[y]}");
            average[3] = sw4.Elapsed.TotalMilliseconds;

            Stopwatch sw5 = new Stopwatch();
            sw5.Start();
            bookIterativeSort.Sort(books5);
            sw5.Stop();
            Console.WriteLine($"My fifth selection sort took {sw5.Elapsed.TotalMilliseconds}ms to run on {bookFiles[y]}");
            average[4] = sw5.Elapsed.TotalMilliseconds;

            double totalAvg = 0;
            foreach (double num in average)
            {
                totalAvg += num;
            }
            double averages = (double)totalAvg / average.Length;
            Console.WriteLine($"The average sort time was {averages}ms");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");


            Console.WriteLine($"            Merge Sort on {bookFiles[y]}");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            Stopwatch sw6 = new Stopwatch();
            sw6.Start();
            bookMergeSort.Sort(books6);
            sw6.Stop();
            Console.WriteLine($"My first merge sort took {sw6.Elapsed.TotalMilliseconds}ms to run on {bookFiles[y]}");
            mergeAverage[0] = sw6.Elapsed.TotalMilliseconds;

            Stopwatch sw7 = new Stopwatch();
            sw7.Start();
            bookMergeSort.Sort(books7);
            sw7.Stop();
            Console.WriteLine($"My second merge sort took {sw7.Elapsed.TotalMilliseconds}ms to run on {bookFiles[y]}");
            mergeAverage[1] = sw7.Elapsed.TotalMilliseconds;

            Stopwatch sw8 = new Stopwatch();
            sw8.Start();
            bookMergeSort.Sort(books8);
            sw8.Stop();
            Console.WriteLine($"My third merge sort took {sw8.Elapsed.TotalMilliseconds}ms to run on {bookFiles[y]}");
            mergeAverage[2] = sw8.Elapsed.TotalMilliseconds;

            Stopwatch sw9 = new Stopwatch();
            sw9.Start();
            bookMergeSort.Sort(books9);
            sw9.Stop();
            Console.WriteLine($"My fourth merge sort took {sw9.Elapsed.TotalMilliseconds}ms to run on {bookFiles[y]}");
            mergeAverage[3] = sw9.Elapsed.TotalMilliseconds;

            Stopwatch sw10 = new Stopwatch();
            sw10.Start();
            bookMergeSort.Sort(books10);
            sw10.Stop();
            Console.WriteLine($"My fifth merge sort took {sw10.Elapsed.TotalMilliseconds}ms to run on {bookFiles[y]}");
            mergeAverage[4] = sw10.Elapsed.TotalMilliseconds;

            double sum = 0;
            for (int b = 0; b < mergeAverage.Length; b++)
            {
                sum += mergeAverage[b];
            }
            double finalAvg = (double)sum / mergeAverage.Length;

            Console.WriteLine($"The average sort time was {finalAvg}ms");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        }
        Console.WriteLine("Click to continue to integer sort!");
        Console.ReadKey();

        //Integer File Starts here

        string[] files = Directory.GetFiles("/Users/jasongun/Downloads/TestDataIntegers");

        for (int i = 0; i < files.Length; i++)
        {
            try
            {
                string[] fileData = File.ReadAllLines(files[i]);

                List<int> ints = new List<int>(fileData.Length);
                List<int> ints2 = new List<int>(fileData.Length);
                List<int> ints3 = new List<int>(fileData.Length);
                List<int> ints4 = new List<int>(fileData.Length);
                List<int> ints5 = new List<int>(fileData.Length);
                List<int> ints6 = new List<int>(fileData.Length);
                List<int> ints7 = new List<int>(fileData.Length);
                List<int> ints8 = new List<int>(fileData.Length);
                List<int> ints9 = new List<int>(fileData.Length);
                List<int> ints10 = new List<int>(fileData.Length);

                double[] average = new double[5];
                double[] mergeAverage = new double[5];

                for (int it = 0; it < fileData.Length; it++)
                {
                    ints.Insert(it, Convert.ToInt32(fileData[it]));
                    ints2.Insert(it, Convert.ToInt32(fileData[it]));
                    ints3.Insert(it, Convert.ToInt32(fileData[it]));
                    ints4.Insert(it, Convert.ToInt32(fileData[it]));
                    ints5.Insert(it, Convert.ToInt32(fileData[it]));
                    ints6.Insert(it, Convert.ToInt32(fileData[it]));
                    ints7.Insert(it, Convert.ToInt32(fileData[it]));
                    ints8.Insert(it, Convert.ToInt32(fileData[it]));
                    ints9.Insert(it, Convert.ToInt32(fileData[it]));
                    ints10.Insert(it, Convert.ToInt32(fileData[it]));
                }
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"            Selection Sort on {files[i]}");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

                IterativeSort<int> selection = new IterativeSort<int>();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                selection.Sort(ints);
                sw.Stop();
                Console.WriteLine($"My first selection sort took {sw.Elapsed.TotalMilliseconds}ms to run on {files[i]}");
                average[0] = sw.Elapsed.TotalMilliseconds;


                Stopwatch sw2 = new Stopwatch();
                sw2.Start();
                selection.Sort(ints2);
                sw2.Stop();
                Console.WriteLine($"My second selection sort took {sw2.Elapsed.TotalMilliseconds}ms to run on {files[i]}");
                average[1] = sw2.Elapsed.TotalMilliseconds;


                Stopwatch sw3 = new Stopwatch();
                sw3.Start();
                selection.Sort(ints3);
                sw3.Stop();
                Console.WriteLine($"My third selection sort took {sw3.Elapsed.TotalMilliseconds}ms to run on {files[i]}");
                average[2] = sw3.Elapsed.TotalMilliseconds;


                Stopwatch sw4 = new Stopwatch();
                sw4.Start();
                selection.Sort(ints4);
                sw4.Stop();
                Console.WriteLine($"My fourth selection sort took {sw4.Elapsed.TotalMilliseconds}ms to run on {files[i]}");
                average[3] = sw4.Elapsed.TotalMilliseconds;


                Stopwatch sw5 = new Stopwatch();
                sw5.Start();
                selection.Sort(ints5);
                sw5.Stop();
                Console.WriteLine($"My fifth selection sort took {sw5.Elapsed.TotalMilliseconds}ms to run on {files[i]}");
                average[4] = sw5.Elapsed.TotalMilliseconds;


                double totalAvg = 0;
                foreach (double num in average)
                {
                    totalAvg += num;
                }
                double averages = (double)totalAvg / average.Length;
                Console.WriteLine($"The average sort time was {averages}ms");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");


                //Merge Sort Starts Here
                Console.WriteLine($"            Merge Sort on {files[i]}");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

                RecursiveSort<int> MergeSort = new RecursiveSort<int>();

                Stopwatch sw6 = new Stopwatch();
                sw6.Start();
                MergeSort.Sort(ints6);
                sw6.Stop();
                Console.WriteLine($"My first merge sort took {sw6.Elapsed.TotalMilliseconds}ms to run on {files[i]}");
                mergeAverage[0] = sw6.Elapsed.TotalMilliseconds;


                Stopwatch sw7 = new Stopwatch();
                sw7.Start();
                MergeSort.Sort(ints7);
                sw7.Stop();
                Console.WriteLine($"My second merge sort took {sw7.Elapsed.TotalMilliseconds}ms to run on {files[i]}");
                mergeAverage[1] = sw7.Elapsed.TotalMilliseconds;

                Stopwatch sw8 = new Stopwatch();
                sw8.Start();
                MergeSort.Sort(ints8);
                sw8.Stop();
                Console.WriteLine($"My third merge sort took {sw8.Elapsed.TotalMilliseconds}ms to run on {files[i]}");
                mergeAverage[2] = sw8.Elapsed.TotalMilliseconds;

                Stopwatch sw9 = new Stopwatch();
                sw9.Start();
                MergeSort.Sort(ints9);
                sw9.Stop();
                Console.WriteLine($"My fourth merge sort took {sw9.Elapsed.TotalMilliseconds}ms to run on {files[i]}");
                mergeAverage[3] = sw9.Elapsed.TotalMilliseconds;

                Stopwatch sw10 = new Stopwatch();
                sw10.Start();
                MergeSort.Sort(ints10);
                sw10.Stop();
                Console.WriteLine($"My fifth merge sort took {sw10.Elapsed.TotalMilliseconds}ms to run on {files[i]}");
                mergeAverage[4] = sw10.Elapsed.TotalMilliseconds;

                double sum = 0;
                for (int b = 0; b < mergeAverage.Length; b++)
                {
                    sum += mergeAverage[b];
                }
                double finalAvg = (double)sum / mergeAverage.Length;


                Console.WriteLine($"The average sort time was {finalAvg}ms");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            }
            catch
            {

            }
        }
        Console.ReadKey();
    }

    /// <summary>
    /// Gets the data of the file given by the user to return 
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public static List<int> LoadIntegerTestData(string filePath)
    {
        List<int> filedata = new List<int>();
        try
        {
            //Check to see if the file even exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"The file is not acceptable");
                return filedata;
            }

            // Read every line in that file
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                // verify if you can pass each line as an integer
                if (int.TryParse(line, out int number))
                {
                    filedata.Add(number);
                }
                else
                {
                    Console.WriteLine($"This was not acceptable");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"This was not acceptable");
        }

        return filedata;
    }
}