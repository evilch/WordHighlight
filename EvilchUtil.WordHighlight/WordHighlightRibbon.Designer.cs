namespace EvilchUtil.WordHighlight
{
    partial class WordHighlightRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public WordHighlightRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            this.tabHighlightAddIn = this.Factory.CreateRibbonTab();
            this.groupHighlightMain = this.Factory.CreateRibbonGroup();
            this.btnHighlightAll = this.Factory.CreateRibbonButton();
            this.btnHighlightSelected = this.Factory.CreateRibbonButton();
            this.btnStatistics = this.Factory.CreateRibbonButton();
            this.btnMarkConversation = this.Factory.CreateRibbonButton();
            this.btnExportPdfMini = this.Factory.CreateRibbonButton();
            this.btnSaveToRepro = this.Factory.CreateRibbonButton();
            this.btnSpecialNames = this.Factory.CreateRibbonButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.tabHighlightAddIn.SuspendLayout();
            this.groupHighlightMain.SuspendLayout();
            // 
            // tabHighlightAddIn
            // 
            this.tabHighlightAddIn.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabHighlightAddIn.Groups.Add(this.groupHighlightMain);
            this.tabHighlightAddIn.KeyTip = "EV";
            this.tabHighlightAddIn.Label = "TabAddIns";
            this.tabHighlightAddIn.Name = "tabHighlightAddIn";
            // 
            // groupHighlightMain
            // 
            ribbonDialogLauncherImpl1.KeyTip = "C";
            ribbonDialogLauncherImpl1.ScreenTip = "Configure words to highlight";
            this.groupHighlightMain.DialogLauncher = ribbonDialogLauncherImpl1;
            this.groupHighlightMain.Items.Add(this.btnHighlightAll);
            this.groupHighlightMain.Items.Add(this.btnHighlightSelected);
            this.groupHighlightMain.Items.Add(this.btnSpecialNames);
            this.groupHighlightMain.Items.Add(this.btnMarkConversation);
            this.groupHighlightMain.Items.Add(this.btnStatistics);
            this.groupHighlightMain.Items.Add(this.separator1);
            this.groupHighlightMain.Items.Add(this.btnExportPdfMini);
            this.groupHighlightMain.Items.Add(this.btnSaveToRepro);
            this.groupHighlightMain.Label = "Word Highlight";
            this.groupHighlightMain.Name = "groupHighlightMain";
            this.groupHighlightMain.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.groupHighlightMain_DialogLauncherClick);
            // 
            // btnHighlightAll
            // 
            this.btnHighlightAll.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnHighlightAll.Description = "HighlightAll";
            this.btnHighlightAll.Image = global::EvilchUtil.WordHighlight.Properties.Resources.PrintEntireDocument;
            this.btnHighlightAll.KeyTip = "A";
            this.btnHighlightAll.Label = "Highlight All";
            this.btnHighlightAll.Name = "btnHighlightAll";
            this.btnHighlightAll.ScreenTip = "Highlight All";
            this.btnHighlightAll.ShowImage = true;
            this.btnHighlightAll.SuperTip = "Highlight All in the Document";
            this.btnHighlightAll.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnHighlightAll_Click);
            // 
            // btnHighlightSelected
            // 
            this.btnHighlightSelected.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnHighlightSelected.Description = "HighlightSelected";
            this.btnHighlightSelected.Image = global::EvilchUtil.WordHighlight.Properties.Resources.Page;
            this.btnHighlightSelected.KeyTip = "S";
            this.btnHighlightSelected.Label = "Highlight Selected";
            this.btnHighlightSelected.Name = "btnHighlightSelected";
            this.btnHighlightSelected.ScreenTip = "Highlight Selected";
            this.btnHighlightSelected.ShowImage = true;
            this.btnHighlightSelected.SuperTip = "Highlight Selected in the Document";
            this.btnHighlightSelected.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnHighlightSelected_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.KeyTip = "T";
            this.btnStatistics.Label = "Statistics";
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.ScreenTip = "Statistics";
            this.btnStatistics.SuperTip = "Statistics about last Highlight action";
            this.btnStatistics.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnStatistics_Click);
            // 
            // btnMarkConversation
            // 
            this.btnMarkConversation.Label = "Mark Conversation";
            this.btnMarkConversation.Name = "btnMarkConversation";
            this.btnMarkConversation.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnMarkConversation_Click);
            // 
            // btnExportPdfMini
            // 
            this.btnExportPdfMini.Label = "Export PDF(mini)";
            this.btnExportPdfMini.Name = "btnExportPdfMini";
            this.btnExportPdfMini.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnExportPdfMini_Click);
            // 
            // btnSaveToRepro
            // 
            this.btnSaveToRepro.Label = "Save To Repro";
            this.btnSaveToRepro.Name = "btnSaveToRepro";
            // 
            // btnSpecialNames
            // 
            this.btnSpecialNames.Label = "Special Names";
            this.btnSpecialNames.Name = "btnSpecialNames";
            this.btnSpecialNames.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSpecialNames_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // WordHighlightRibbon
            // 
            this.Name = "WordHighlightRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tabHighlightAddIn);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.WordHightlightRibbon_Load);
            this.tabHighlightAddIn.ResumeLayout(false);
            this.tabHighlightAddIn.PerformLayout();
            this.groupHighlightMain.ResumeLayout(false);
            this.groupHighlightMain.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabHighlightAddIn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupHighlightMain;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnHighlightAll;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnHighlightSelected;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnStatistics;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnMarkConversation;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSaveToRepro;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnExportPdfMini;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSpecialNames;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
    }

    partial class ThisRibbonCollection
    {
        internal WordHighlightRibbon WordHightlightRibbon
        {
            get { return this.GetRibbon<WordHighlightRibbon>(); }
        }
    }
}
