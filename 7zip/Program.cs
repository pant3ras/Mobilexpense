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

            //1.2 problem
            MergePDF.pdf();

            //1.3 problem
            CopyFiles.copyFiles();

           // problem 2
        }
    }
}
