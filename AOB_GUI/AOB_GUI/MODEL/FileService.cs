using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOB_GUI.MODEL
{
    public class FileService
    {
        private File file;

        /// <summary>
        /// 실제 파일 다이얼로그를 생성하는 함수
        /// </summary>
        /// <returns> stream </returns>
        public Stream OpenFile()
        {
            file = new File();
            OpenFileDialog fd = new OpenFileDialog();

            fd.Filter = file.FILTER;

            bool? result = fd.ShowDialog();

            file.stream = result.Value ? fd.OpenFile() : null;

            return file.stream;
        }
    }
}
