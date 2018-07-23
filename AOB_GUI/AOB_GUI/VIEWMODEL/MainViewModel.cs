using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AOB_GUI.VIEWMODEL
{
    public class MainViewModel : ViewModelBase
    {
        private Stream stream;
        private FileDialogViewModel fileDialogViewModel;
        public DelegateCommand OpenFileDialogCmd { get; set; }

        /// <summary>
        /// 파일 다이얼로그 열기를 클릭시 생기는 리턴값의 정보를 get/set
        /// </summary>
        /// <value>return type : Stream</value>
        public Stream Stream
        {
            get { return this.stream; }
            set
            {
                this.stream = value;

                // 파일 오픈 후에 다음 실행할 함수 
            }
        }

        public MainViewModel()
        {
            Initialize();
        }

        /// <summary>
        /// The Initialize
        /// <remarks> FileDialogViewModel 객체 및 Command 객체 생성 </remarks>
        /// </summary>
        private void Initialize()
        {
            fileDialogViewModel = new FileDialogViewModel();
            OpenFileDialogCmd = new DelegateCommand(OpenFileDialog);
        }

        /// <summary>
        /// 파일 오픈 다이얼로그
        /// <remarks> 파일 오픈 커맨드가 들어왔을 때 실행되는 함수 </remarks>
        /// </summary>
        private void OpenFileDialog()
        {
            Stream = fileDialogViewModel.OpenFile();
        }

    }
}
