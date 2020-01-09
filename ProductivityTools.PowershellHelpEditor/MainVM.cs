using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ProductivityTools.PowershellHelpEditor
{
    public class MainVM
    {
        public ICommand OpenAboutWindowCommand { get; }
        public ICommand OpeFileDialogCommand { get; }

        public MainVM()
        {
            this.OpenAboutWindowCommand = new CommandHandler(OpenAbout, () => true);
            this.OpeFileDialogCommand = new CommandHandler(OpenFileDialog, () => true);
        }

        private void OpenAbout()
        {
            About about = new About();
            about.ShowDialog();
        }
        
        private void OpenFileDialog()
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            CommonFileDialogResult result = dialog.ShowDialog();
        }
    }
}
