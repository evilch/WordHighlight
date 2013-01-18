using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EvilchUtil.WordHighlight
{
    public partial class FormTestIt : Form
    {
        public FormTestIt()
        {
            InitializeComponent();
        }

        private void FormTestIt_Load(object sender, EventArgs e)
        {
            categoryControl1.LoadCategoryTree();
        }
    }
}
