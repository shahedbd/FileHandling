using System;
using System.Diagnostics;
using System.IO;

namespace FileHandling
{
    public static class Helper
    {
        //Extension method 
        public static void RenameFile(this FileInfo fileInfo, string newName)
        {
            fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + newName);
        }

        public static void RenameFile(string newFileName)
        {
            FileInfo file = new FileInfo(GlobalVariables.strFilesLocsWithFilesName);
            file.RenameFile(newFileName);
        }

        public static void RenameFilesByDeleteingNewFileIfExist(string newFileName)
        {
            FileInfo file = new FileInfo(GlobalVariables.strFilesLocsWithFilesName);

            var strNewFilesLocsWithFilesName = Path.Combine(file.DirectoryName, newFileName);
            if (File.Exists(strNewFilesLocsWithFilesName)) File.Delete(strNewFilesLocsWithFilesName);

            File.Move(GlobalVariables.strFilesLocsWithFilesName, strNewFilesLocsWithFilesName);
        }

        public static void GetFileDetails()
        {
            FileInfo file = new FileInfo(GlobalVariables.strFilesLocsWithFilesName);
            string Attributes = file.Attributes.ToString();
            string CreationTime = file.CreationTime.ToString();

            string CreationTimeUtc = file.CreationTimeUtc.ToString();
            string Directory = file.Directory.ToString();

            string DirectoryName = file.DirectoryName.ToString();
            bool Exists = file.Exists;

            string Extension = file.Extension.ToString();
            string FullName = file.FullName.ToString();

            bool IsReadOnly = file.IsReadOnly;
            string LastAccessTime = file.LastAccessTime.ToString();
            string LastAccessTimeUtc = file.LastAccessTimeUtc.ToString();

            string LastWriteTime = file.LastWriteTime.ToString();
            string LastWriteTimeUtc = file.LastWriteTimeUtc.ToString();

            string Length = file.Length.ToString();
            string Name = file.Name.ToString();

            //Writte to file
            string strFileInfoDetails = file.Attributes + Environment.NewLine + file.CreationTime + Environment.NewLine;
            strFileInfoDetails = strFileInfoDetails + file.CreationTimeUtc + Environment.NewLine + file.Directory + Environment.NewLine;

            strFileInfoDetails = strFileInfoDetails + file.CreationTimeUtc + Environment.NewLine + file.Directory + Environment.NewLine;
            strFileInfoDetails = strFileInfoDetails + file.DirectoryName + Environment.NewLine + file.Exists + Environment.NewLine;

            strFileInfoDetails = strFileInfoDetails + file.Extension + Environment.NewLine + file.FullName + Environment.NewLine;
            strFileInfoDetails = strFileInfoDetails + file.IsReadOnly + Environment.NewLine + file.LastAccessTime + Environment.NewLine;

            strFileInfoDetails = strFileInfoDetails + file.LastAccessTimeUtc + Environment.NewLine + file.LastWriteTime + Environment.NewLine;
            strFileInfoDetails = strFileInfoDetails + file.LastWriteTimeUtc + Environment.NewLine + file.Length + Environment.NewLine;

            strFileInfoDetails = strFileInfoDetails + file.Name + Environment.NewLine;


            File.WriteAllText(GlobalVariables.strOutPutResult, strFileInfoDetails);
            Process.Start("notepad.exe", GlobalVariables.strOutPutResult);

        }


        public static void CreateFile()
        {
            string path = @"E:\AppServ\Example.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine("The very first line!");
                tw.Close();
            }
            else if (File.Exists(path))
            {
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine("The next line!");
                tw.Close();
            }
        }



    }
}
