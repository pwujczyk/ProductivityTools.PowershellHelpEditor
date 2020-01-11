using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.PowershellHelpEditor.Files
{
    public static class StringBuilderExtensions
    {
        public static void AppendTwoLines(this StringBuilder sb)
        {
            sb.AppendLine();
            sb.AppendLine();
        }

        public static void AppendTabulator(this StringBuilder sb)
        {
            sb.Append("\t");
        }
    }
}
