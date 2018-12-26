using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyVerilog
{
    public static class OpenedFilesHandles
    {
        private static List<string> OpenedFiles = new List<string>();

        public static List<string> OpenedFilesNames = new List<string>();

        public static List<string> OpenedFilesText = new List<string>();

        public static void AddOpenFile(string fullname, string text)
        {
            string[] splittedName = fullname.Split('\\');

            //All of them share the same index
            OpenedFiles.Add(fullname);
            OpenedFilesNames.Add(splittedName[splittedName.Count() - 1]);
            OpenedFilesText.Add(text);
        }

        public static string GetFullName(int index)
        {
            return OpenedFiles[index];
        }
        public static int OpenedFilesCount
        {
            get
            {
                return OpenedFiles.Count();
            }
        }
        public static string GetText(int index)
        {
            return OpenedFilesText[index];
        }

        public static void SaveText(int index, string text)
        {
            if (index == -1)
            {
                OpenedFilesText[0] = text;
            }
            else
            {
                OpenedFilesText[index] = text;
            }
        }
    }
}
