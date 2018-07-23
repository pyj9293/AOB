using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AOB_GUI.MODEL;

namespace AOB_GUI.VIEWMODEL
{
    public class FileDialogViewModel : ViewModelBase
    {
        private FileService service;

        /// <summary>
        /// 생성자로 Model - FileService의 객체 생성
        /// </summary>
        public FileDialogViewModel()
        {
            service = new FileService();
        }

        /// <summary>
        /// FileService의 OpenFile함수를 실행
        /// </summary>
        /// <returns> Stream Type </returns>
        public Stream OpenFile()
        {
            return service.OpenFile();
        }

    }
}
