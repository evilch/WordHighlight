namespace EvilchUtil.WordHighlight.Control
{
    partial class CategoryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewRootCategory = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewCategory = new System.Windows.Forms.TreeView();
            this.menuCategoryNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemNewSubCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRenameCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuCategoryNode.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewRootCategory});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(322, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewRootCategory
            // 
            this.btnNewRootCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNewRootCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnNewRootCategory.Image")));
            this.btnNewRootCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewRootCategory.Name = "btnNewRootCategory";
            this.btnNewRootCategory.Size = new System.Drawing.Size(63, 22);
            this.btnNewRootCategory.Text = "New Root";
            this.btnNewRootCategory.Click += new System.EventHandler(this.btnNewRootCategory_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewCategory);
            this.splitContainer1.Size = new System.Drawing.Size(322, 415);
            this.splitContainer1.SplitterDistance = 296;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeViewCategory
            // 
            this.treeViewCategory.ContextMenuStrip = this.menuCategoryNode;
            this.treeViewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCategory.LabelEdit = true;
            this.treeViewCategory.Location = new System.Drawing.Point(0, 0);
            this.treeViewCategory.Name = "treeViewCategory";
            this.treeViewCategory.Size = new System.Drawing.Size(322, 296);
            this.treeViewCategory.TabIndex = 0;
            this.treeViewCategory.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewCategory_AfterLabelEdit);
            // 
            // menuCategoryNode
            // 
            this.menuCategoryNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewSubCategory,
            this.menuItemRenameCategory});
            this.menuCategoryNode.Name = "menuCategoryNode";
            this.menuCategoryNode.Size = new System.Drawing.Size(173, 70);
            this.menuCategoryNode.Opening += new System.ComponentModel.CancelEventHandler(this.menuCategoryNode_Opening);
            // 
            // menuItemNewSubCategory
            // 
            this.menuItemNewSubCategory.Name = "menuItemNewSubCategory";
            this.menuItemNewSubCategory.Size = new System.Drawing.Size(172, 22);
            this.menuItemNewSubCategory.Text = "New Sub Category";
            this.menuItemNewSubCategory.Click += new System.EventHandler(this.menuItemNewSubCategory_Click);
            // 
            // menuItemRenameCategory
            // 
            this.menuItemRenameCategory.Name = "menuItemRenameCategory";
            this.menuItemRenameCategory.Size = new System.Drawing.Size(172, 22);
            this.menuItemRenameCategory.Text = "Rename Category";
            this.menuItemRenameCategory.Click += new System.EventHandler(this.menuItemRenameCategory_Click);
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(322, 440);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuCategoryNode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewCategory;
        private System.Windows.Forms.ToolStripButton btnNewRootCategory;
        private System.Windows.Forms.ContextMenuStrip menuCategoryNode;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewSubCategory;
        private System.Windows.Forms.ToolStripMenuItem menuItemRenameCategory;
    }
}
