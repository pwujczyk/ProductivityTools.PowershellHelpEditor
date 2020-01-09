using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProductivityTools.PowershellHelpEditor
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {
        string Psm1Directory;
        public About()
        {
            InitializeComponent();
        }

        public About(string psm1Directory) : this()
        {
            this.Psm1Directory = psm1Directory;
        }
    }
}
