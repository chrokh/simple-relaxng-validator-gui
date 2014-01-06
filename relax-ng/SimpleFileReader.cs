using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace relax_ng
{
    class SimpleFileReader
    {
        private string _filePath;

        public SimpleFileReader(string filePath)
        {
            _filePath = filePath;
        }

        public string Read()
        {
            try
            {
                return File.ReadAllText(_filePath);
            }
            catch (IOException e)
            {
                return "ERROR: " + e.Message;
            }
        }
    }
}
