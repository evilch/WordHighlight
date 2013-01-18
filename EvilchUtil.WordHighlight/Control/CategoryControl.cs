using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EvilchUtil.WordHighlight.Control
{
    public partial class CategoryControl : UserControl
    {
        public CategoryControl()
        {
            InitializeComponent();
        }

        public string ConnectionString
        {
            get
            {
                return "Data Source=(local);Initial Catalog=StoryDB;Integrated Security=True";
            }
        }

        public const string UpdateSourceName = "App";

        public void LoadCategoryTree()
        {
            using (Entity.StoryDBEntities context = new Entity.StoryDBEntities(ConnectionString))
            {
                treeViewCategory.Nodes.Clear();

                var rootQ = from c in context.Categories
                            where !c.ParentCategoryId.HasValue 
                                || c.ParentCategoryId.Value == 0
                            select c;
                foreach (var n in rootQ)
                {
                    TreeNode node = treeViewCategory.Nodes.Add(n.CategoryName);
                    node.Tag = n.CategoryId;

                    LoadSubCategorys(context, node, n.CategoryId);
                }
            }
        }

        private void LoadSubCategorys(Entity.StoryDBEntities context, TreeNode parentNode, int parentCatId)
        {
            var subQ = from c in context.Categories
                        where c.ParentCategoryId.HasValue
                            && c.ParentCategoryId.Value == parentCatId
                        select c;
            foreach (var n in subQ)
            {
                TreeNode node = parentNode.Nodes.Add(n.CategoryName);
                node.Tag = n.CategoryId;

                LoadSubCategorys(context, node, n.CategoryId);
            }
        }


        private void btnNewRootCategory_Click(object sender, EventArgs e)
        {
            using (Entity.StoryDBEntities context = new Entity.StoryDBEntities(ConnectionString))
            {
                TreeNode newRoot = treeViewCategory.Nodes.Add("");
                newRoot.Tag = -1;
                newRoot.BeginEdit();
            }

        }

        private void treeViewCategory_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            using (Entity.StoryDBEntities context = new Entity.StoryDBEntities(ConnectionString))
            {
                e.CancelEdit = true;
                try
                {
                    if (!string.IsNullOrWhiteSpace(e.Label))
                    {
                        int catId = (int)e.Node.Tag;

                        int parentCatId = 0;
                        if (e.Node.Parent != null)
                        {
                            parentCatId = (int)e.Node.Parent.Tag;
                        }

                        if (catId <= 0)
                        {
                            Entity.Category cat = new Entity.Category()
                            {
                                ParentCategoryId = parentCatId,
                                CategoryName = e.Label,
                                CreateBy = UpdateSourceName,
                                CreateDate = DateTime.UtcNow,
                                UpdateBy = UpdateSourceName,
                                UpdateDate = DateTime.UtcNow,
                            };

                            context.Categories.AddObject(cat);
                            try
                            {
                                context.SaveChanges();
                                e.CancelEdit = false;
                            }
                            catch (Exception x)
                            {
                                MessageBox.Show(x.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            Entity.Category cat = (
                                from c in context.Categories
                                where c.CategoryId == catId
                                select c).SingleOrDefault();
                            cat.CategoryName = e.Label;
                            cat.UpdateBy = UpdateSourceName;
                            cat.UpdateDate = DateTime.UtcNow;
                            context.SaveChanges();
                            e.CancelEdit = false;
                        }
                    }
                }
                finally
                {
                    if (e.CancelEdit)
                        e.Node.BeginEdit();
                }
            }
        }

        private void menuCategoryNode_Opening(object sender, CancelEventArgs e)
        {
            menuItemNewSubCategory.Enabled = treeViewCategory.SelectedNode != null;
        }

        private void menuItemNewSubCategory_Click(object sender, EventArgs e)
        {
            if (treeViewCategory.SelectedNode != null)
            {
                TreeNode newNode = treeViewCategory.SelectedNode.Nodes.Add("");
                newNode.Tag = -1;
                newNode.Parent.Expand();
                newNode.BeginEdit();
            }
        }

        private void menuItemRenameCategory_Click(object sender, EventArgs e)
        {
            if (treeViewCategory.SelectedNode != null)
            {
                treeViewCategory.SelectedNode.BeginEdit();
            }
        }

    }
}
