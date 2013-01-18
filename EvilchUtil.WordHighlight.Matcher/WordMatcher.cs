using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Reflection;
using System.Xml.Linq;

namespace EvilchUtil.WordHighlight.Matcher
{
    public class WordMatcher
    {
        public const string EventLogSource = "WordHighlightMatcher";
        public WordMatcher(string appRegKey)
        {
            AppRegKey = appRegKey;
        }

        private string AppRegKey { get; set; }

        private List<HighlightWord> highlightWords = new List<HighlightWord>();

        public void AddWord(string content, string style, HighlightWord.WordMatchType matchType)
        {
            highlightWords.Add(new HighlightWord(content)
                               {
                                       Style = style,
                                       MatchType = matchType,
                               });
        }


        public void LoadHightlightDefineFile(string defineFile  =null)
        {
            try
            {
                if (string.IsNullOrEmpty(defineFile))
                {
                    defineFile = DefineFilenameInReg;
                }

                XDocument doc = XDocument.Load(defineFile);
                if (doc.Element("WordHightDefines") != null)
                {

                    if (doc.Element("WordHightDefines").Element("Words") != null)
                    {
                        foreach (XElement wordDef in doc.Element("WordHightDefines").Element("Words").Elements("Word"))
                        {
                            AddWord((string)wordDef.Attribute("content"), (string)wordDef.Attribute("style"), ParseMatchType((string)wordDef.Attribute("type")));
                        }
                    }

                    Debug.WriteLine("{0} loaded. {1} words in list.", defineFile, highlightWords.Count);
                    if (doc.Element("WordHightDefines").Element("ReferenceFiles") != null)
                    {
                        foreach (XElement fileDefine in doc.Element("WordHightDefines").Element("ReferenceFiles").Elements("File"))
                        {
                            string path = Environment.ExpandEnvironmentVariables((string)fileDefine.Attribute("path"));
                            path = path.Replace("[MyDocuments]", System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                            path = path.Replace("[Desktop]", System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                            path = path.Replace("[ApplicationData]", System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                            path = path.Replace("[LocalApplicationData]", System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

                            if (!path.Equals(defineFile, StringComparison.OrdinalIgnoreCase))
                            {
                                LoadHightlightDefineFile(path);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                EventLog.WriteEntry(EventLogSource, ex.ToString(), EventLogEntryType.Warning);
            }
        }

        private static HighlightWord.WordMatchType ParseMatchType(string typeString)
        {
            HighlightWord.WordMatchType rtv = HighlightWord.WordMatchType.Default;
            foreach (string s in typeString.Split('|'))
            {
                rtv |= (HighlightWord.WordMatchType)Enum.Parse(typeof (HighlightWord.WordMatchType), s);
            }
            return rtv;
        }

        public const string HightlightDef = "HighlightsDef";

        private string DefineFilenameInReg
        {
            get
            {
                string defaultDef = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), HightlightDef + ".xml");
                try
                {
                    using (RegistryKey regKey = Registry.CurrentUser.OpenSubKey(AppRegKey))
                    {
                        return (string) regKey.GetValue(HightlightDef, defaultDef);
                    }
                }
                catch(Exception)
                {
                    return defaultDef;
                }
            }
        }

        public bool Match(string word, out HighlightWord hlWord)
        {
            foreach (HighlightWord hw in highlightWords)
            {
                if (hw.Matches(word))
                {
                    hlWord = hw;
                    return true;
                }
            }

            hlWord = null;
            return false;
        }

        public bool Match(string word, out string style)
        {
            HighlightWord hlWord;
            bool rtv = Match(word, out hlWord);
            style = hlWord != null ? hlWord.Style : null;
            return rtv;
        }
    }
}
