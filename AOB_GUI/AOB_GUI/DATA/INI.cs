using System;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Generic;

namespace AOB_GUI.MODEL
{
    public class INI
    {

        ///// INI Read & Write 
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        public string ReadINI(string iniDir, string iniFile, string section, string key)
        {
            string iniFilePath;
            StringBuilder temp = new StringBuilder(255);

            iniFilePath = Path.Combine(iniDir, iniFile);
            int i = GetPrivateProfileString(section, key, "", temp, 255, iniFilePath);
            return temp.ToString();
        }

        public void WriteINI(string iniDir, string iniFile, string section, string key, string val)
        {
            string iniFilePath;
            StringBuilder temp = new StringBuilder(255);

            iniFilePath = iniDir + "\\" + iniFile;

            DirectoryInfo di = new DirectoryInfo(iniDir);
            if (di.Exists == false)
            {
                di.Create();
            }
            WritePrivateProfileString(section, key, val, iniFilePath);
        }
    }
}
