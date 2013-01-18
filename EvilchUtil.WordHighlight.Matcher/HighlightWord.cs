using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

namespace EvilchUtil.WordHighlight.Matcher
{
    public class HighlightWord
    {
        [Flags]
        public enum WordMatchType
        {
            Default     = 0x00,
            Contain     = 0x01,
            IgnoreCase  = 0x02,
            Regex       = 0x04,
        }

        public HighlightWord(string content)
        {
            Content = content;
        }

        public string Content { get; set; }
        public WordMatchType MatchType { get; set; }
        public string Style { get; set; }


        public bool Matches(string word)
        {
            if (MatchType.HasFlag(WordMatchType.Regex))
            {
                return MatchesRegex(word);
            }
            else
            {
                if (MatchType.HasFlag(WordMatchType.Contain))
                {
                    return word.IndexOf(Content, MatchType.HasFlag(WordMatchType.IgnoreCase) ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal) >= 0;
                }
                else
                {
                    return word.Equals(Content, MatchType.HasFlag(WordMatchType.IgnoreCase) ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
                }
            }
        }

        private bool MatchesRegex(string word)
        {
            return Regex.IsMatch(word, Content, MatchType.HasFlag(WordMatchType.IgnoreCase) ? RegexOptions.IgnoreCase : RegexOptions.None);
        }

        public Color BackgroundColor
        {
            get 
            {
                try
                {
                    return ColorTranslator.FromHtml(GetStyle("background"));
                }
                catch (Exception)
                {
                    return Color.Empty;
                }
            }
        }

        private Dictionary<string, string> styleDict;
        private string GetStyle(string styleKey)
        {
            styleKey = styleKey.ToLowerInvariant();
            if(styleDict == null)
            {
                styleDict = new Dictionary<string, string>();
                foreach (string kv in Style.Split(';').Select(s => s.Trim()))
                {
                    var pair = kv.Split(':');
                    if (pair.Length < 2 || string.IsNullOrWhiteSpace(pair[0]))
                    {
                        continue;
                    }
                    styleDict.Add(pair[0].Trim().ToLowerInvariant(), pair[1]);
                }
            }

            if (styleDict.ContainsKey(styleKey))
            {
                return styleDict[styleKey];
            }
            else
            {
                return null;
            }
        }

        public bool IsBold
        {
            get
            {
                try
                {
                    return GetStyle("font-weight").Trim().Equals("bold", StringComparison.OrdinalIgnoreCase);
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool IsItalic
        {
            get
            {
                try
                {
                    return GetStyle("font-style").Trim().Equals("italic", StringComparison.OrdinalIgnoreCase);
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }


        public float Size
        {
            get
            {
                try
                {
                    string pt = GetStyle("font-size").Trim().ToLowerInvariant();
                    int idx = pt.IndexOf("pt");
                    if (idx >= 0)
                    {
                        pt = pt.Substring(0, idx);
                    }
                    return float.Parse(pt);
                }
                catch (Exception)
                {
                    return float.NaN;
                }
            }
        }
    }
}
