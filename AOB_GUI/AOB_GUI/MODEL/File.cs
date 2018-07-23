using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOB_GUI.MODEL
{
    public class File
    {
        public Stream stream { get; set; }
        public string FILTER = "zip files|*.zip";
    }
}
