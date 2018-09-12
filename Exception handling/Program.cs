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

            #region HomeWork6_A
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            //List<string> oPhone = new List<string>();
            //List<string> resultPhones = new List<string>();
            //string name;
            //string phone;
            //var currentDirr = Directory.GetCurrentDirectory();
            //string phones = currentDirr + @"\phones.txt";
            //string newPhones = currentDirr + @"\ophones.txt";
            //string resphones = currentDirr + @"\New.txt";

            //try
            //{
            //    using (StreamReader sr = new StreamReader(phones, System.Text.Encoding.Default))
            //    {
            //        string line;
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            string[] arrdigits = line.Split(new char[] { '_', '/' }, 2);
            //            name = arrdigits[1];
            //            phone = arrdigits[0];
            //            phoneBook.Add(name, phone);
            //            oPhone.Add(phone);
            //            if (ConvertToNewStand(phone) != null )
            //            {
            //                resultPhones.Add(ConvertToNewStand(phone));
            //            }
            //            Console.WriteLine($"{name} / {phone}");
            //        }
            //    }
            //    using (StreamWriter sw = new StreamWriter(newPhones, false, System.Text.Encoding.Default))
            //    {
            //        foreach (var phon in oPhone)
            //        {
            //            sw.WriteLine(phon);
            //        }
            //    }
            //    using (StreamReader sr = new StreamReader(newPhones, System.Text.Encoding.Default))
            //    {
            //        string line;
            //        Console.WriteLine("");
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine($"{line}");
            //        }
            //    }
            //    using (StreamWriter sw = new StreamWriter(resphones, false, System.Text.Encoding.Default))
            //    {
            //        foreach (var resultPhone in resultPhones)
            //        {
            //            sw.WriteLine(resultPhone);
            //        }
            //    }
            //    using (StreamReader sr = new StreamReader(resphones, System.Text.Encoding.Default))
            //    {
            //        string line;
            //        Console.WriteLine("");
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine($"{line}");
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.ReadKey();
            #endregion

            #region HomeWork6_B
            int count = 0;
            int startVal = 1;
            int endVal = 100;
            bool readFile = false;
            string key;
            string line;

            Console.Write("Choose method for enter digits(c-console,f-file): ");
            key = Console.ReadLine();
            if (key.ToLower() == "f")
            {
                readFile = true;
            }
            else if (key.ToLower() == "c")
            {
                readFile = false;
            }

            if (readFile)
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    while ((line = sr.ReadLine()) != null && count < 10 && startVal < 99)
                    {
                        try
                        {
                            Console.Write($"Enter {count + 1} digit: ");
                            if (ReaNumber(startVal, endVal, line))
                            {
                                Console.WriteLine($"\nDigit in range [{startVal} , {endVal}] {int.Parse(line)}");
                                startVal = int.Parse(line);
                                count++;
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.Error.WriteLine(e.Message);
                        }
                    }
                }
            }
            else
            {
                while (count < 10 && startVal < 99)
                {
                    try
                    {
                        Console.Write($"Enter {count + 1} digit: ");
                        line = Console.ReadLine();
                        if (ReaNumber(startVal, endVal, line))
                        {
                            Console.WriteLine($"\nDigit in range [{startVal} , {endVal}] {int.Parse(line)}");
                            startVal = int.Parse(line);
                            count++;
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.Error.WriteLine(e.Message);
                    }
                }
            }
            #endregion
        }

        private static bool ReaNumber(int start, int end, string val)
        {
            int digit;
            if (int.TryParse(val, out digit))
            {
                return digit > start && digit < end;
            }
            else
            {
                throw new FormatException(
                    "value not a digit");
            }
        }

        private static string ConvertToNewStand(string phone)
        {
            Int64 ph;
            if (Int64.TryParse(phone, out ph))
            {
                if (phone.Length == 9)
                {
                    return "+380" + phone;
                }
                else if (phone.Length == 10)
                {
                    return "+38" + phone;
                }
                else if (phone.Length == 11)
                {
                    return "+3" + phone;
                }
            }
            return null;
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
