namespace EvilchUtil.WordHighlight.Matcher.Statistics
{
    partial class FormStatistics
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelGrids = new System.Windows.Forms.TableLayoutPanel();
            this.wordStatisticsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordStatisticsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highlightStatisticsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statisticsDataSet = new EvilchUtil.WordHighlight.Matcher.Statistics.StatisticsDataSet();
            this.highlightStatisticsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelGrids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordStatisticsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordStatisticsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightStatisticsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightStatisticsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelGrids
            // 
            this.tableLayoutPanelGrids.ColumnCount = 1;
            this.tableLayoutPanelGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGrids.Controls.Add(this.wordStatisticsDataGridView, 0, 1);
            this.tableLayoutPanelGrids.Controls.Add(this.highlightStatisticsDataGridView, 0, 0);
            this.tableLayoutPanelGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGrids.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelGrids.Name = "tableLayoutPanelGrids";
            this.tableLayoutPanelGrids.RowCount = 2;
            this.tableLayoutPanelGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelGrids.Size = new System.Drawing.Size(549, 391);
            this.tableLayoutPanelGrids.TabIndex = 0;
            // 
            // wordStatisticsDataGridView
            // 
            this.wordStatisticsDataGridView.AllowUserToAddRows = false;
            this.wordStatisticsDataGridView.AllowUserToResizeRows = false;
            this.wordStatisticsDataGridView.AutoGenerateColumns = false;
            this.wordStatisticsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordStatisticsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.wordStatisticsDataGridView.DataSource = this.wordStatisticsBindingSource;
            this.wordStatisticsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordStatisticsDataGridView.Location = new System.Drawing.Point(3, 120);
            this.wordStatisticsDataGridView.Name = "wordStatisticsDataGridView";
            this.wordStatisticsDataGridView.ReadOnly = true;
            this.wordStatisticsDataGridView.RowHeadersVisible = false;
            this.wordStatisticsDataGridView.Size = new System.Drawing.Size(543, 268);
            this.wordStatisticsDataGridView.TabIndex = 1;
            this.wordStatisticsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.wordStatisticsDataGridView_CellFormatting);
            this.wordStatisticsDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.wordStatisticsDataGridView_CellPainting);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Word";
            this.dataGridViewTextBoxColumn7.HeaderText = "Word";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Color";
            dataGridViewCellStyle3.Format = "X08";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn8.HeaderText = "Color";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RunId";
            this.dataGridViewTextBoxColumn9.HeaderText = "RunId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MatchedCount";
            this.dataGridViewTextBoxColumn10.HeaderText = "MatchedCount";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // wordStatisticsBindingSource
            // 
            this.wordStatisticsBindingSource.DataMember = "HighlightStatistics_WordStatistics";
            this.wordStatisticsBindingSource.DataSource = this.highlightStatisticsBindingSource;
            // 
            // highlightStatisticsBindingSource
            // 
            this.highlightStatisticsBindingSource.DataMember = "HighlightStatistics";
            this.highlightStatisticsBindingSource.DataSource = this.statisticsDataSet;
            // 
            // statisticsDataSet
            // 
            this.statisticsDataSet.DataSetName = "StatisticsDataSet";
            this.statisticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // highlightStatisticsDataGridView
            // 
            this.highlightStatisticsDataGridView.AllowUserToAddRows = false;
            this.highlightStatisticsDataGridView.AllowUserToDeleteRows = false;
            this.highlightStatisticsDataGridView.AllowUserToResizeRows = false;
            this.highlightStatisticsDataGridView.AutoGenerateColumns = false;
            this.highlightStatisticsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.highlightStatisticsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.highlightStatisticsDataGridView.DataSource = this.highlightStatisticsBindingSource;
            this.highlightStatisticsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.highlightStatisticsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.highlightStatisticsDataGridView.MultiSelect = false;
            this.highlightStatisticsDataGridView.Name = "highlightStatisticsDataGridView";
            this.highlightStatisticsDataGridView.ReadOnly = true;
            this.highlightStatisticsDataGridView.Size = new System.Drawing.Size(543, 111);
            this.highlightStatisticsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RunType";
            this.dataGridViewTextBoxColumn1.HeaderText = "RunType";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "WordCount";
            this.dataGridViewTextBoxColumn2.HeaderText = "WordCount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TotalMatchedCount";
            this.dataGridViewTextBoxColumn3.HeaderText = "TotalMatchedCount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RunId";
            this.dataGridViewTextBoxColumn4.HeaderText = "RunId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RunTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "RunTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RunCost";
            this.dataGridViewTextBoxColumn6.HeaderText = "RunCost";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 391);
            this.Controls.Add(this.tableLayoutPanelGrids);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(565, 400);
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStatistics_FormClosing);
            this.tableLayoutPanelGrids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordStatisticsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordStatisticsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightStatisticsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightStatisticsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGrids;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView wordStatisticsDataGridView;
        private System.Windows.Forms.DataGridView highlightStatisticsDataGridView;
        private System.Windows.Forms.BindingSource wordStatisticsBindingSource;
        private System.Windows.Forms.BindingSource highlightStatisticsBindingSource;
        private StatisticsDataSet statisticsDataSet;

    }
}