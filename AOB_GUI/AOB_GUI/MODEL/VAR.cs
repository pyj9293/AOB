using System;
using System.IO;

namespace AOB_GUI.MODEL
{

    public class VAR
    {
        private static string AppDir = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\..\\");
        private string ConfigDir = Path.Combine(AppDir, "Config"); 

        public string getPath()
        {
            return ConfigDir;
        }
    }
}
