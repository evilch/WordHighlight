namespace EvilchUtil.WordHighlight
{
    partial class FormTestIt
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
            this.categoryControl1 = new EvilchUtil.WordHighlight.Control.CategoryControl();
            this.SuspendLayout();
            // 
            // categoryControl1
            // 
            this.categoryControl1.Location = new System.Drawing.Point(12, 12);
            this.categoryControl1.Name = "categoryControl1";
            this.categoryControl1.Size = new System.Drawing.Size(239, 238);
            this.categoryControl1.TabIndex = 0;
            // 
            // FormTestIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.categoryControl1);
            this.Name = "FormTestIt";
            this.Text = "FormTestIt";
            this.Load += new System.EventHandler(this.FormTestIt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.CategoryControl categoryControl1;
    }
}