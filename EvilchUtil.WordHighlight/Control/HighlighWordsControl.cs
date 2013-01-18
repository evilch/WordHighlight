using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace EvilchUtil.WordHighlight.Control
{
    public partial class HighlighWordsControl : UserControl
    {
        public HighlighWordsControl()
        {
            InitializeComponent();
        }

        private void FormHighlighWords_Load(object sender, EventArgs e)
        {
            try
            {
                using (RegistryKey softKey = Registry.LocalMachine.OpenSubKey("Software"))
                using (RegistryKey key = softKey.OpenSubKey("WordHighlight"))
                {
                    txtGreedWords.Text = string.Join(","
                        , ((string)key.GetValue("GreedyWords")).Split(new char[] { ',', ';', ' ', '\r', }, StringSplitOptions.RemoveEmptyEntries));

                    txtRestrictWords.Text = string.Join(","
                        , ((string)key.GetValue("StrictWords")).Split(new char[] { ',', ';', ' ', '\r', }, StringSplitOptions.RemoveEmptyEntries));
                }
            }
            catch { }
        }

        public void ApplyChanges()
        {
            try
            {
                using (RegistryKey softKey = Registry.LocalMachine.OpenSubKey("Software", true))
                using (RegistryKey key = softKey.CreateSubKey("WordHighlight", RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    key.SetValue("GreedyWords"
                        , string.Join(","
                            , txtGreedWords.Text.Split(new char[] { ',', ';', ' ', '\r', }, StringSplitOptions.RemoveEmptyEntries)
                        ));

                    key.SetValue("StrictWords"
                        , string.Join(","
                            , txtRestrictWords.Text.Split(new char[] { ',', ';', ' ', '\r', }, StringSplitOptions.RemoveEmptyEntries)
                        ));
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Unable to save words:" + Environment.NewLine + x.ToString());
            }
        }
    }
}
