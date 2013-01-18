using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;

namespace EvilchUtil.WordHighlight.Matcher.Forms
{
    [ComVisible(false)] 
    public partial class SpecialNamesForm : Form
    {
        public SpecialNamesForm()
        {
            InitializeComponent();

            StyleString = "font-weight:bold;font-style:italic;font-size:11.5pt";
        }

        public string[] SpecialName
        {
            get { return txtNames.Lines.Select(s=>s.Trim()).ToArray(); }
        }

        public string StyleString { get; set; }
        public WordMatcher Matcher
        {
            get
            {
                WordMatcher matcher = new WordMatcher(string.Empty);
                foreach (string line in SpecialName)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        matcher.AddWord(line.Trim(), StyleString, HighlightWord.WordMatchType.IgnoreCase);
                    }
                }
                return matcher;
            }
        }

    }
}
