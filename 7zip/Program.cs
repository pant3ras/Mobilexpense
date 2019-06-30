using System;


/*
 * Created by Liviu Chile (2019-06-30) 
 * For the technical test from MobileXpense
 * ######################################
 * This is the main file of the application
 * 
 */ 

namespace _7zip
{
    class Program
    {

        static void Main(string[] args)
        {
            //1.1 problem
            Zip.SevenZip();
            Console.WriteLine("Press any key to go to next problem");
            Console.ReadKey();
            //1.3 problem
            CopyFiles.copyFiles();
            Console.WriteLine("Press any key to go to next problem");
            Console.ReadKey();
            //1.2 problem
            MergePDF.pdf();
            Console.WriteLine("This was the last problem! Thank you");
            Console.ReadKey();


            // problem 2
        }
    }
}
