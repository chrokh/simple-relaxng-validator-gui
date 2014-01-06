using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace relax_ng
{
    class AnnotatedFileReader
    {
        private string _filePath;

        public AnnotatedFileReader(string filePath)
        {
            _filePath = filePath;
        }

        public string Read()
        {
            try
            {
                string ret = "FILE WILL RELOAD ON EACH VALIDATION: \r\n";
                ret += _filePath + "\r\n";
                ret += "================================\r\n";
                ret += File.ReadAllText(_filePath);
                return ret;
            }
            catch (IOException e)
            {
                return "ERROR: " + e.Message;
            }
        }
    }
}
