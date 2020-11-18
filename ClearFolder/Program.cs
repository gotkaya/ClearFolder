﻿using System;
using System.IO;

namespace ClearFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";
            DeleteAllfiles();

            DirectoryInfo rootDirectory = new DirectoryInfo(rootPath);
            foreach (DirectoryInfo dir in rootDirectory.GetDirectories())
            {
                DeleteAllFolders(dir.FullName, true);
            }



        }

        public static void DeleteAllfiles()
        {
            string rootpath = @"C:\Users\opilane\samples";
            DirectoryInfo directory = new DirectoryInfo(rootpath);

            foreach(FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }

        }

        public static void DeleteAllFolders(string directoryName, bool ifExists)
        {
          if(Directory.Exists(directoryName))
          {
                Directory.Delete(directoryName, true);
          }else if (ifExists)
          {
                throw new SystemException("No such directory to delete");
          }

        }

    }
}
