using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bitcoin
{
    class SafteyCheck
    {

        public bool CheckIfFileExists()
        {
            string path = @"C:\Users\VVL\Desktop\Test Subject\storage.xml";

            return File.Exists(path);
        }

    }
}
