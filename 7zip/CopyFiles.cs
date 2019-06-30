using System;
using System.Collections.Generic;
using System.Text;
/*
 * Created by Liviu Chile (2019-06-30) 
 * For the technical test from MobileXpense
 * ######################################
 * This will read everything from the source file, and copy into the target path. 
 * Both paths are saved into an .ini file.
 * *
 */
namespace _7zip
{
    class CopyFiles
    {
        public static void copyFiles() {
            //    string source = @"C:\Users\PanTeraS\Desktop\Input";
            //  string target = @"C:\Users\PanTeraS\Desktop\destinatieNoua";

        var IniFile = new IniFile(@"C:\Users\PanTeraS\Desktop\Settings.ini");

        string source = IniFile.Read("CopyFiles", "source");
        string target = IniFile.Read("CopyFiles", "target");

            if (System.IO.Directory.Exists(source))
            {
                string[] files = System.IO.Directory.GetFiles(source);
                foreach (string s in files)
                {
                   string filename = System.IO.Path.GetFileName(s);
        string destination = System.IO.Path.Combine(target, filename);
        System.IO.File.Copy(s, destination, true);
                }
}
            else
            {
                Console.WriteLine("Source path doesnt exist!!");
            }
           
        }
    }
}
