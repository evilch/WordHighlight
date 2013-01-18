using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EvilchUtil.WordHighlight.Matcher.Statistics
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        public StatisticsDataSet.HighlightStatisticsRow BeforeProcessing()
        {
            wordStatisticsBindingSource.SuspendBinding();
            highlightStatisticsBindingSource.SuspendBinding();

            return statisticsDataSet.HighlightStatistics.AddHighlightStatisticsRow
                (""
                , 0
                , 0
                , Guid.NewGuid()
                , DateTime.Now
                , TimeSpan.Zero);
        }
        
        public void AfterProcessing()
        {
            statisticsDataSet.AcceptChanges();
            wordStatisticsBindingSource.ResumeBinding();
            highlightStatisticsBindingSource.ResumeBinding();

            highlightStatisticsBindingSource.MoveLast();
        }

        public void HighlightStaticsticIncrease(StatisticsDataSet.HighlightStatisticsRow runStatistics, HighlightWord word)
        {
            StatisticsDataSet.WordStatisticsRow wordRow = statisticsDataSet.WordStatistics.FirstOrDefault(row =>
                row.Word == word.Content && row.RunId == runStatistics.RunId);
            if (wordRow == null)
            {
                wordRow = statisticsDataSet.WordStatistics.AddWordStatisticsRow
                    (word.Content
                    , word.BackgroundColor.ToArgb()
                    , runStatistics
                    , 0);
            }
            runStatistics.TotalMatchedCount++;
            wordRow.MatchedCount++;
        }

        private void wordStatisticsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (wordStatisticsDataGridView.Columns[e.ColumnIndex].DataPropertyName)
            {
            case "Color":
                {
                    Color c = Color.FromArgb((int)e.Value);
                    e.CellStyle.SelectionBackColor = c;
                    e.CellStyle.BackColor = c;
                }
                break;
            case "MatchedCount":
                if ((int)e.Value > 0)
                {
                    e.CellStyle.Font = new System.Drawing.Font(e.CellStyle.Font, FontStyle.Bold);
                    e.CellStyle.ForeColor = Color.Black;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.LightGray;
                }
                break;
            }
        }

        private void wordStatisticsDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
        }

        private void FormStatistics_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
