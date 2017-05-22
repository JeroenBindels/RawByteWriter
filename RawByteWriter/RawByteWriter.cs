using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace RawByteWriter
{
    public partial class RawByteWriter : Form
    {
        private string _sourceFile;
        private string _outputFile;

        public RawByteWriter()
        {
            InitializeComponent();
            _sourceFile = "";
        }

        private void WriteBytes(int start, int length)
        {
            byte[] bytes = new byte[length];
            using (BinaryReader reader = new BinaryReader(new FileStream(_sourceFile, FileMode.Open)))
            {
                reader.BaseStream.Seek(start, SeekOrigin.Begin);
                reader.Read(bytes, 0, length);
                reader.Close();
            }
            using (BinaryWriter writer = new BinaryWriter(new FileStream(_outputFile, FileMode.Create)))
            {
                writer.Write(bytes);
                writer.Close();
            }
            MessageBox.Show("Extraction complete!");
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
                if (File.Exists(fd.FileName))
                    FileSelected(fd.FileName);
        }

        private void FileSelected(string file)
        {
            _sourceFile = file;
            FileInfo fi = new FileInfo(_sourceFile);
            lblSelectedFile.Text = fi.Name;
            ToolTip tt = new ToolTip();
            tt.ToolTipTitle = fi.Name;
            tt.SetToolTip(lblSelectedFile, fi.FullName);
            btnSelectOutput.Enabled = true;
        }

        private void btnSelectOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.CreatePrompt = false;
            sfd.OverwritePrompt = true;
            if (File.Exists(_sourceFile))
                sfd.InitialDirectory = Directory.GetParent(_sourceFile).FullName;
            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                _outputFile = sfd.FileName;
                GatherForExtraction();
            }
        }

        private void GatherForExtraction()
        {
            int start = GetInt(txtStart.Text, rdbStartHex.Checked);
            int length = GetInt(txtLength.Text, rdbLengthHex.Checked);
            WriteBytes(start, length);
        }

        private int GetInt(string number, bool isHex)
        {
            if (number == "")
                return 0;
            if (isHex)
                return int.Parse(number, System.Globalization.NumberStyles.HexNumber);
            return Convert.ToInt32(number);
        }

        private string GetHex(string number)
        {
            int n = Convert.ToInt32(number);
            return n.ToString("x");
        }

        private void rdbStartHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbStartHex.Checked)
                txtStart.Text = GetHex(txtStart.Text);
            else
                txtStart.Text = GetInt(txtStart.Text, true).ToString();
        }

        private void rdbLengthHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLengthHex.Checked)
                txtLength.Text = GetHex(txtLength.Text);
            else
                txtLength.Text = GetInt(txtLength.Text, true).ToString();
        }
    }
}
