using System.IO;

namespace FileHandling
{
    public static class GlobalVariables
    {
        public static string strFilesLocs = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
        public static string strFilesLocsWithFilesName = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "\\Files\\F1.txt";

        public static string strOutPutResult = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "\\OutPut\\Result01.txt";
    }
}
