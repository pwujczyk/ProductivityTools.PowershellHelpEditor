using ProductivityTools.PowershellHelpEditor.Files;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ProductivityTools.PowershellHelpEditor.AboutWindow
{
    public class AboutVM
    {
        public ICommand AboutHelpCommand { get; }

        public AboutHelp AboutHelp { get; set; }

        public AboutVM()
        {
            this.AboutHelp = new AboutHelp();
            this.AboutHelpCommand = new CommandHandler(CreateFile, () => true);
        }

        public void CreateFile()
        {
            AboutHelp.SaveFile("S");
        }

    }
}
