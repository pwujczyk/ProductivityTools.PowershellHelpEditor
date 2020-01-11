using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace ProductivityTools.PowershellHelpEditor
{
    public class MainVM
    {
        public ICommand OpenAboutWindowCommand { get; }
        public ICommand OpeFileDialogCommand { get; }

        private string ModuleDirectory { get; set; }

      
        private string psm1directory;
        public string Psm1Directory
        {
            get
            {
                if (string.IsNullOrEmpty(psm1directory))
                {
                    psm1directory = FindPsm1(ModuleDirectory);
                }
                return psm1directory;
            }
        }

        public MainVM()
        {
            this.OpenAboutWindowCommand = new CommandHandler(OpenAbout, () => true);
            this.OpeFileDialogCommand = new CommandHandler(OpenFileDialog, () => true);
        }

        private void OpenAbout()
        {
            About about = new About(this.Psm1Directory);
            about.ShowDialog();
        }

        private void OpenFileDialog()
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            CommonFileDialogResult result = dialog.ShowDialog();
            this.ModuleDirectory = dialog.FileName;
        }

        string FindPsm1(string path)
        {
            var files=System.IO.Directory.GetFiles(path, "*.psm1");
            if (files.Any())
            {
                return path;
            }
            else
            {
                var dirs=System.IO.Directory.GetDirectories(path);
                foreach(var dir in dirs)
                {
                    path = FindPsm1(dir);
                    if(!string.IsNullOrEmpty(path))
                    {
                        return path;
                    }
                }
            }

            return string.Empty;

        }
    }
}
