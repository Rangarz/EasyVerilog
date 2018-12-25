using System;
using System.IO;
using System.Net;
using System.Text;

namespace EasyVerilog
{
    public static class FileHandler
    {
        private static string _projectPath;

        public static void SetPath(string path)
        {
            _projectPath = path + @"\";
        }
        public static void CreateFile(string filename, string text)
        {
            if (string.IsNullOrEmpty(_projectPath))
            {
                throw new Exception("Empty or Null _projectPath");
            }
            try
            {
                if (File.Exists(_projectPath + filename))
                {
                    File.Delete(_projectPath + filename);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            //If file was deleted successfully or it wasn't found
            using (var fs = File.Create(_projectPath + filename))
            {
                Byte[] data = new UTF8Encoding(true).GetBytes(text);
                fs.Write(data, 0, data.Length);
            }
        }

        public static void OpenFile(string filename, out string text)
        {
            if (string.IsNullOrEmpty(_projectPath))
            {
                throw new Exception("Empty or Null _projectPath");
            }
            text = "";
            using (var sr = File.OpenText(_projectPath + filename))
            {
                text = sr.ReadToEnd();
            }
        }


    }
}