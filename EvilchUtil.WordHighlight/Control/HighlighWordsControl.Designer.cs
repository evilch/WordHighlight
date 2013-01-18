namespace EvilchUtil.WordHighlight.Control
{
    partial class HighlighWordsControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGreedWords = new System.Windows.Forms.TextBox();
            this.txtRestrictWords = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtGreedWords, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.txtRestrictWords, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(380, 220);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Greed Words: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restrict Words: ";
            // 
            // txtGreedWords
            // 
            this.txtGreedWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGreedWords.Location = new System.Drawing.Point(94, 5);
            this.txtGreedWords.Multiline = true;
            this.txtGreedWords.Name = "txtGreedWords";
            this.txtGreedWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGreedWords.Size = new System.Drawing.Size(281, 102);
            this.txtGreedWords.TabIndex = 2;
            // 
            // txtRestrictWords
            // 
            this.txtRestrictWords.AcceptsReturn = true;
            this.txtRestrictWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestrictWords.Location = new System.Drawing.Point(94, 113);
            this.txtRestrictWords.Multiline = true;
            this.txtRestrictWords.Name = "txtRestrictWords";
            this.txtRestrictWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRestrictWords.Size = new System.Drawing.Size(281, 102);
            this.txtRestrictWords.TabIndex = 3;
            // 
            // HighlighWordsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(380, 220);
            this.Name = "HighlighWordsControl";
            this.Size = new System.Drawing.Size(380, 220);
            this.Load += new System.EventHandler(this.FormHighlighWords_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtRestrictWords;
        public System.Windows.Forms.TextBox txtGreedWords;
    }
}