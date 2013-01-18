using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using EvilchUtil.WordHighlight.Matcher;
using EvilchUtil.WordHighlight.Matcher.Forms;
using EvilchUtil.WordHighlight.Matcher.Statistics;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using System.Diagnostics;
using Microsoft.Win32;
using System.Windows.Forms;

namespace EvilchUtil.WordHighlight
{
    public partial class WordHighlightRibbon
    {
        public const string AppRegKey = @"Software\WordHighlight";

        public const string UndoRecord_HighlightAll = "Highlight All";
        public const string UndoRecord_HighlightSelected = "Highlight Selected";



        FormStatistics frmStatistics;
        private void WordHightlightRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            frmStatistics = new FormStatistics();
        }

        private void LoadHighlightWords()
        {
            wordMatcher = new WordMatcher(AppRegKey);
            wordMatcher.LoadHightlightDefineFile(null);
        }

        private WordMatcher wordMatcher;

        private static void RTrim(Word.Range word)
        {
            while (word.End > word.Start && Char.IsWhiteSpace(word.Text, word.Text.Length - 1))
            {
                word.SetRange(word.Start, word.End - 1);
            }
        }

        private int MarkupConversations(Word.Range range)
        {
            foreach (Word.Paragraph paragraph in range.Paragraphs)
            {
                int? start = null;
                foreach (Word.Range word in paragraph.Range.Words)
                {
                    if (string.IsNullOrWhiteSpace(word.Text))
                        continue;

                    RTrim(word);

                    if (word.End <= word.Start)
                        continue;

                    string txt = word.Text;
                    int pos = txt.IndexOf("\"");
                    if (pos >= 0)
                    {
                        if (pos > 0 && Char.IsDigit(txt[pos - 1]))
                            continue;

                        if (!start.HasValue)
                        {
                            start = word.Start + pos;
                        }
                        else
                        {
                            Word.Range conv = range.Document.Range(start.Value, word.End + pos);
                            start = null;
                            conv.Shading.BackgroundPatternColor = (WdColor)(Color.FromArgb(160, 160, 255, 255).ToArgb() & 0x00ffffff);
                        }
                    }
                }
            }
            return 0;
        }

        private StatisticsDataSet.HighlightStatisticsRow Hightlight(Word.Range range, WordMatcher matcher)
        {

            StatisticsDataSet.HighlightStatisticsRow runStatistics = frmStatistics.BeforeProcessing();


            foreach (Word.Range word in range.Words)
            {
                if (string.IsNullOrWhiteSpace(word.Text))
                    continue;

                RTrim(word);

                if (word.End <= word.Start)
                    continue;

                HighlightWord hlWord = null;
                if (matcher.Match(word.Text.Trim(), out hlWord))
                {
                    Color color = hlWord.BackgroundColor;
                    if (!color.IsEmpty)
                    {
                        word.Shading.BackgroundPatternColor = (WdColor)
                            ((color.R)
                                | (color.G << 8)
                                    | (color.B << 16));
                    }
                    word.Font.Bold = hlWord.IsBold ? 1 : 0;
                    word.Font.Italic = hlWord.IsItalic ? 1 : 0;
                    float fsize = hlWord.Size;
                    if (!float.IsNaN(fsize))
                    {
                        word.Font.Size = hlWord.Size;
                    }

                    frmStatistics.HighlightStaticsticIncrease(runStatistics, hlWord);
                }
            }

            runStatistics.RunCost = DateTime.Now - runStatistics.RunTime;

            frmStatistics.AfterProcessing();

            return runStatistics;
        }



        private void btnHighlightAll_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Application wordApp = Globals.ThisAddIn.Application;
            LoadHighlightWords();

            wordApp.UndoRecord.StartCustomRecord(UndoRecord_HighlightAll);
            Hightlight(wordApp.ActiveDocument.Content, wordMatcher).RunType = "All";
            wordApp.UndoRecord.EndCustomRecord();

        }

        private void btnHighlightSelected_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Application wordApp = Globals.ThisAddIn.Application;
            if (wordApp.Selection.Document == wordApp.ActiveDocument)
            {
                LoadHighlightWords();

                wordApp.UndoRecord.StartCustomRecord(UndoRecord_HighlightSelected);
                Hightlight(wordApp.Selection.Range, wordMatcher).RunType = "Selected";
                wordApp.UndoRecord.EndCustomRecord();
            }
        }

        private void groupHighlightMain_DialogLauncherClick(object sender, RibbonControlEventArgs e)
        {
            if (DesignMode)
            {
                FormTestIt form = new FormTestIt();
                form.ShowDialog();
            }
            else
            {
                //FormConfig from = new FormConfig();
                //from.ShowDialog();
            }
        }

        private void btnStatistics_Click(object sender, RibbonControlEventArgs e)
        {
            frmStatistics.Show();
        }

        private void btnMarkConversation_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Application wordApp = Globals.ThisAddIn.Application;
            MarkupConversations(wordApp.ActiveDocument.Content);
        }

        private void btnExportPdfMini_Click(object sender, RibbonControlEventArgs e)
        {
            using (SaveFileDialog saveDlg = new SaveFileDialog
            {
                Filter = @"*.pdf|*.pdf|*.*|*.*",
                DefaultExt = "*.pdf",
                InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            })
            {
                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    Word.Application wordApp = Globals.ThisAddIn.Application;
                    wordApp.ActiveDocument.ExportAsFixedFormat(saveDlg.FileName, WdExportFormat.wdExportFormatPDF, true, WdExportOptimizeFor.wdExportOptimizeForOnScreen);
                }
            }

        }

        private void btnSpecialNames_Click(object sender, RibbonControlEventArgs e)
        {
            using (SpecialNamesForm form = new SpecialNamesForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    WordMatcher specialMatcher = form.Matcher;

                    Word.Application wordApp = Globals.ThisAddIn.Application;
                    wordApp.UndoRecord.StartCustomRecord(UndoRecord_HighlightAll);

                    Hightlight(wordApp.ActiveDocument.Content, specialMatcher).RunType = "Special Name";
                    wordApp.UndoRecord.EndCustomRecord();
                }
            }
        }

    }
}
