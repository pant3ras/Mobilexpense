using System;
using System.IO.Compression;
using System.IO;
using Spire.Pdf;
using Spire.Doc;
using Spire.Xls;
using System.Drawing;
/*
 * Created by Liviu Chile (2019-06-30) 
 * For the technical test from MobileXpense
 * ######################################
 * This will create and decompress a zip file (outputproblemstatement1.7z)
 * 
 * All the details for the files are saved on a ini file
 * There are 2 methods, but the first one creates zip's that are corrupt.
 * *
 */
namespace _7zip
{
    class Zip
    {
        static string filename = @"C:\Users\PanTeraS\Desktop\Input\image2.jpg";
        static string outputFilename = @"C:\Users\PanTeraS\Desktop\Input\outputproblemstatement1.7z";
        //old way of zipping - complicate myself
        static void Compress()
        {
            using (FileStream inputStream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (FileStream outputStream = new FileStream(outputFilename, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (GZipStream gzip = new GZipStream(outputStream, CompressionMode.Compress))
                    {
                        inputStream.CopyTo(gzip);
                    }
                }
            }
        }

        static void Decompres()
        {
            using (FileStream inputStream = new FileStream(outputFilename, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (FileStream outputStream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (GZipStream gzip = new GZipStream(inputStream, CompressionMode.Decompress))

                    {
                        gzip.CopyTo(outputStream);
                    }
                }

            }
        }
        // the one that we use
        public static void SevenZip()
        {
            //declare the location of the ini file
            var IniFile = new IniFile(@"C:\Users\PanTeraS\Desktop\Settings.ini");

            // get the paths from the ini

            string startPath = IniFile.Read("Settings", "startPath");

            string zipPath = IniFile.Read("Settings", "zip");

            string extractPath = IniFile.Read("Settings", "extract");

            Console.WriteLine(extractPath);
            //create the zip file
            try
            {
                ZipFile.CreateFromDirectory(startPath, zipPath);
            }
            catch
            {
                Console.WriteLine("File already exists! Delete them, so we can create again the zip!");
            }

            //decompres the files. if not needed, just comment.
            try
            {
                ZipFile.ExtractToDirectory(zipPath, extractPath);
            }
            catch
            {
                Console.WriteLine("File already exists! Delete them, so we can create again the zip!");
            }



        }
    }
}
