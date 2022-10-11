using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proektnaya1488
{
    public partial class Form5 : Form
    {
        public bool ch { get; private set; }
        public bool Saved { get; private set; }

        public string FilePath { get; private set; }

        public Form5()
        {
            InitializeComponent();
            FilePath = string.Empty;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public void ssave()
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }
        internal void Save()
        {

            if (string.IsNullOrEmpty(FilePath)) FilePath = ChooseFileNameToSave();
            if (string.IsNullOrEmpty(FilePath)) return;
            File.WriteAllText(FilePath, richTextBox1.Text);
        }
        static string ChooseFileNameToSave()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text file (*.txt)|*.txt ";
                return sfd.ShowDialog() == DialogResult.OK ? sfd.FileName : string.Empty;
            }
        }
        static string ChoooseFileToOpen()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                return ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : string.Empty;
            }
        }
        internal void Open()
        {
            FilePath = ChoooseFileToOpen();
            if (string.IsNullOrEmpty(FilePath))
            {
                Saved = true;
                Close();
                return;
            }
            richTextBox1.Text = File.ReadAllText(FilePath);
            Text = FilePath;
        }
        public void Cut()
        {
            richTextBox1.Cut();
        }

        internal void Copy()
        {
            richTextBox1.Copy();
        }

        internal void Paste()
        {
            richTextBox1.Paste();
        }
        public void nazad()
        {
            richTextBox1.Undo();
        }
        public void povtor()
        {
            richTextBox1.Redo();
        }
        public void change()
        {

        }
        private void richTextBox1_text(object sender, FormClosingEventArgs e)
        {

            ch = true;
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Class1.Krol == "1")
            {

                if (ch == true)
                {
                    switch (
                        MessageBox.Show(string.Format("Сохранить правки в документе\r\n{0}", FilePath), "Пишущая машина системы MAGI",
                            MessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.Cancel:

                            e.Cancel = true;
                            break;
                        case DialogResult.Yes:

                            Save();
                            break;
                        case DialogResult.No:

                            e.Cancel = false;
                            break;
                    }

                }
                else
                {
                    Save();
                }
            }
        }

        private void Form5_TextChanged(object sender, EventArgs e)
        {
            ch = true;
        }
    }
}

          
     

