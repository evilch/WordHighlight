using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using MSWord = Microsoft.Office.Interop.Word;

namespace EvilchUtil.WordHighlight
{
    public enum HighlightType
    {
        Greedy,
        Strict,
    }
    [DebuggerDisplay("Word={Word},{Type}")]
    public class HighlightWord
    {
        public static readonly string[] DefaultHightlightWords = "fuck,suck,sex,cunt,pussy,slut,bitch,whore,cock,dick,sperm,cum,nasty,dirty,kinky,pee,piss,ass,horny,nipple,breast,gang,bang,spank,slap".Split(',');
        public static readonly MSWord.WdColor[] Colors = new MSWord.WdColor[]
        {
            MSWord.WdColor.wdColorAqua,
            MSWord.WdColor.wdColorBrightGreen,
            MSWord.WdColor.wdColorLightBlue,
            MSWord.WdColor.wdColorLightGreen,
            MSWord.WdColor.wdColorLightOrange,
            MSWord.WdColor.wdColorLightTurquoise,
            MSWord.WdColor.wdColorSeaGreen,
            MSWord.WdColor.wdColorSkyBlue,
        };

        protected int Index
        {
            get;
            private set;
        }
        private static int WordCounter = 0;

        public string Word
        {
            get;
            private set;
        }

        public HighlightType Type
        {
            get;
            set;
        }

        public HighlightWord(string word)
        {
            Word = word;
            Index = WordCounter++;
        }

        public MSWord.WdColor BackgroundColor
        {
            get { return Colors[Index % Colors.Length]; }
        }

        public override int GetHashCode()
        {
            return Word.GetHashCode();
        }

        internal bool Matches(string s)
        {
            switch(Type)
            {
            case HighlightType.Strict:
                return s.Equals(Word, StringComparison.OrdinalIgnoreCase);
            case HighlightType.Greedy:
                return s.IndexOf(Word, StringComparison.OrdinalIgnoreCase) >= 0;
            default:
                throw new NotSupportedException("some Type not supported");
            }
        }

        internal static void ResetWordCount()
        {
            WordCounter = 0;
        }
    }

    internal static class StringExtension
    {
        public static bool IsMatchesWords(this string s, ICollection<HighlightWord> words)
        {
            foreach (HighlightWord w in words)
            {
                if (w.Matches(s))
                    return true;
            }
            return false;
        }

        public static bool IsPartOfList_IgnoreCase(this string s, out int index, params string[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (s.IndexOf(list[i], StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    index = i;
                    return true;
                }
            }
            index = -1;
            return false;
        }
    }
}
