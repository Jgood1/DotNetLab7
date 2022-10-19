using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Dynamic;

namespace Lab7dotnet
{
    internal class Program
    {
       static void Main (string[] args)
        {
            if (Directory.Exists(args[0]))
            {
                DirectoryLookup(args[0], DateTime.Parse(args[1]));
                Console.ReadLine();
            }
        
        }
        public static void DirectoryLookup(string Path, DateTime date)
        {
            foreach (string file in Directory.GetFiles(Path))
            {
                DateTime fileDate = File.GetLastWriteTime(file);
                FileInfo fileinfo = new FileInfo(file);

                if (fileDate >= date)
                {
                    Console.WriteLine(fileinfo.Name);
                    Console.WriteLine("Time created: "+ fileinfo.CreationTime);
                    Console.WriteLine("Time Last Modified: "+fileinfo.LastAccessTime);
               

                }
            }
            foreach (string dir in Directory.GetDirectories(Path))
            {
                DirectoryLookup(dir,date);
            }
        }

        //public string GetInformation(string fileName)
        //{
        //    string information;

        //    // output that file or directory exists
        //    information = fileName + " exists\r\n\r\n";

        //    // output when file or directory was created
        //    information += "Created: " + File.GetCreationTime(fileName) + "\r\n";

        //    // output when file or directory was last modified
        //    information += "Last modified: " + File.GetLastWriteTime(fileName) + "\r\n";

        //    // output when file or directory was last accessed
        //    information += "Last accessed: " + File.GetLastAccessTime(fileName) + "\r\n" + "\r\n";

        //    return information;

        //} // end method GetInformation

    }
}
