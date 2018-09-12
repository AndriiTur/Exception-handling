using System;
using System.Collections.Generic;
using System.IO;

namespace Exception_handling
{
    class Program
    {
        static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();
        static List<string> fileNames = new List<string>();
        static string path = @"\fileNames.txt";

        static void Main(string[] args)
        {
            #region Task6_1
            //double dividend;
            //double divisor;
            //double result = 0;

            //try
            //{
            //    Console.Write("Enter dividend: ");
            //    dividend = double.Parse(Console.ReadLine());
            //    Console.Write("Enter divisor: ");
            //    divisor = double.Parse(Console.ReadLine());
            //    result = Div(dividend,divisor);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.Error.WriteLine("Error: " + ex.Message);
            //}
            //catch (FormatException)
            //{
            //    Console.Error.WriteLine("Invalid double number!");
            //}
            //catch (OverflowException)
            //{
            //    Console.Error.WriteLine(
            //       "The number is too big to fit in double!");
            //}

            //if (result != 0)
            //{
            //    Console.WriteLine($"\nReult division = {result}");
            //}
            //Console.WriteLine("\nPress any key");
            //Console.ReadKey();
            #endregion

            #region Task6_2
            //double dividend;
            //double divisor;
            //List<double> result = new List<double>();
            //var currentDirr = Directory.GetCurrentDirectory();
            //string path = currentDirr + @"\data.txt";
            //string rezPath = currentDirr + @"\rez.txt";
            //try
            //{
            //    using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            //    {
            //        string line;
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            string[] arrdigits = line.Split(new char[]{'/'}, 2);
            //            dividend = double.Parse(arrdigits[0]);
            //            divisor = double.Parse(arrdigits[1]);
            //            result.Add(Div(dividend, divisor));
            //            Console.WriteLine($"{dividend} / {divisor} = {result}");
            //        }
            //    }
            //    using (StreamWriter sw = new StreamWriter(rezPath, false, System.Text.Encoding.Default))
            //    {
            //        foreach (var rezult in result)
            //        {
            //            sw.WriteLine(rezult.ToString());
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.ReadKey();
            #endregion

            #region Task6_3
            //DriveInfo di = new System.IO.DriveInfo(@"c:\");

            //if (!di.IsReady)
            //{
            //    Console.WriteLine("The drive {0} could not be read", di.Name);
            //}
            //DirectoryInfo rootDir = di.RootDirectory;
            //WalkDirectoryTree(rootDir);

            //// Write out all the files that could not be processed.
            ////Console.WriteLine("Files with restricted access:");
            ////foreach (string s in log)
            ////{
            ////    Console.WriteLine(s);
            ////}
            //// Keep the console window open in debug mode.
            //Console.WriteLine("Press any key");
            //Console.ReadKey();
            #endregion

            #region Task6_4
            //string dirName = "D:\\temp";

            //try
            //{
            //    if (Directory.Exists(dirName))
            //    {
            //        Console.WriteLine("Файлы:");
            //        string[] files = Directory.GetFiles(dirName);
            //        foreach (string s in files)
            //        {
            //            using (StreamReader sr = new StreamReader(s, System.Text.Encoding.Default))
            //            {
            //                string line;
            //                while ((line = sr.ReadLine()) != null)
            //                {
            //                    Console.WriteLine($"{s.n}: {line}");
            //                }
            //            }
            //            Console.WriteLine(s);
            //        }
            //    }
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.ReadKey();
            #endregion
        }

        public static double Div(double dividend, double divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException(
                   "Division by Zero not posible");

            return dividend / divisor;
        }

        static void WalkDirectoryTree(DirectoryInfo root)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            try
            {
                files = root.GetFiles("*.*");
            }
            catch (UnauthorizedAccessException e)
            {
                log.Add(e.Message);
            }

            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (FileInfo fi in files)
                {
                    Console.WriteLine($"\n{fi.Name}     {fi.Length}");
                    File.AppendAllText(path, $"\n{fi.Name}     {fi.Length}");
                }

                subDirs = root.GetDirectories();
                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    WalkDirectoryTree(dirInfo);
                }
            }
        }
    }
}
