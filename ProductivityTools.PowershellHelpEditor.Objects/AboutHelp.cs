using System;
using System.Text;

namespace ProductivityTools.PowershellHelpEditor.Files
{
    public class AboutHelp
    {
        public string Topic { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Examples { get; set; }
        public string Keywords { get; set; }
        public string SeeAlso { get; set; }

        public void SaveFile(string destination)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(AboutHelpLabels.Topic);
            AppendValue(sb, this.Topic);
            sb.Append(AboutHelpLabels.ShorDescription);
            AppendValue(sb, this.ShortDescription);
            sb.Append(AboutHelpLabels.LongDescription);
            AppendValue(sb, this.LongDescription);
            sb.Append(AboutHelpLabels.Examples);
            AppendValue(sb, this.Examples);
            sb.Append(AboutHelpLabels.Keywords);
            AppendValue(sb, this.Keywords);
            sb.Append(AboutHelpLabels.SeeAlso);
            AppendValue(sb, this.SeeAlso);
            var r = sb.ToString();
        }

        private void AppendValue(StringBuilder sb, string value)
        {
            sb.AppendLine();
            sb.AppendTabulator();
            sb.Append(value);
            sb.AppendTwoLines();
        }

    }
}
